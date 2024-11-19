using System.IO;
using System.Reflection;
using System.Windows.Threading;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper;
using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.DataAccess;
using PIMTool.WPF.Services;
using PIMTool.WPF.ViewModels.Pages;
using PIMTool.WPF.ViewModels.Windows;
using PIMTool.WPF.Views.Pages;
using PIMTool.WPF.Views.Windows;

using Serilog;

using Wpf.Ui;

namespace PIMTool.WPF
{
    public partial class App
    {
        private static readonly IHost _host = Host
            .CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                      .AddEnvironmentVariables();
            })
            .ConfigureServices((context, services) =>
            {
                // Configure logging
                ConfigureLogging(services, context.Configuration);

                // Configure database
                ConfigureDatabase(services, context.Configuration);

                // Configure repository wrapper
                ConfigureRepositoryWrapper(services);

                // Hosted services
                services.AddHostedService<ApplicationHostService>();

                // Page resolver service
                services.AddSingleton<IPageService, PageService>();

                // Theme manipulation
                services.AddSingleton<IThemeService, ThemeService>();

                // TaskBar manipulation
                services.AddSingleton<ITaskBarService, TaskBarService>();

                // Service containing navigation, same as INavigationWindow... but without window
                services.AddSingleton<INavigationService, NavigationService>();

                // Main window with navigation
                services.AddSingleton<INavigationWindow, MainWindow>();
                services.AddSingleton<MainWindowViewModel>();

                // Pages and their ViewModels
                services.AddSingleton<DashboardPage>();
                services.AddSingleton<DashboardViewModel>();
                services.AddSingleton<DataPage>();
                services.AddSingleton<DataViewModel>();
                services.AddSingleton<SettingsPage>();
                services.AddSingleton<SettingsViewModel>();
            })
            .Build();

        private static void ConfigureLogging(IServiceCollection services, IConfiguration configuration)
        {
            var loggerConfig = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(configuration["Logging:LogFile"]!, rollingInterval: RollingInterval.Day);

            Log.Logger = loggerConfig.CreateLogger();

            services.AddLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddSerilog(Log.Logger);
                logging.AddDebug();
            });
        }

        private static void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
            var useInMemoryDatabase = bool.Parse(configuration["UseInMemoryDatabase"]!);
            var connectionString = configuration.GetConnectionString("PIMToolDbConnection");

            if (useInMemoryDatabase)
            {
                services.AddDbContext<DbContext, PIMToolDbContext>(options =>
                    options.UseInMemoryDatabase("PIMTool_InMemoryDb")
                           .EnableSensitiveDataLogging());
            }
            else
            {
                services.AddDbContext<DbContext, PIMToolDbContext>(options =>
                    options.UseSqlServer(connectionString)
                           .EnableSensitiveDataLogging());
            }
        }

        private static void ConfigureRepositoryWrapper(IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static T? GetService<T>() where T : class
        {
            return _host.Services.GetService(typeof(T)) as T;
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            _host.Start();
        }

        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // Handle unhandled exceptions
        }
    }
}