using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using PIMTool.Core.Wrapper;
using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.DataAccess;
using PIMTool.Winforms.Controls;
using PIMTool.Winforms.UserControls;

using Serilog;
using Serilog.Events;

namespace PIMTool.Winforms
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider;
        private static IConfiguration? _configuration;

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();

            ServiceProvider = host.Services;

            // Seed data after initializing the PIMToolDbContext
            using (var scope = ServiceProvider.CreateScope())
            {
                //var dbContext = scope.ServiceProvider.GetRequiredService<PIMToolDbContext>();
                //dbContext.Database.Migrate(); // Ensure database is created and migrated

                ////Seed data after database initialization
                //DataAccess.SampleData.SampleData.InitializeData(dbContext);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            Application.Run(mainWindow);
        }

        private static IHostBuilder CreateHostBuilder()
        {
            ConfigureConfiguration();

            //Load connection string from appsettings.json
            string connectionString = _configuration!.GetConnectionString("PIMToolDbConnection")!;

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureLogging(services);
                    services.AddDbContext<DbContext, PIMToolDbContext>(
                        options => options
                        .UseSqlServer(connectionString)
                        .LogTo(Console.WriteLine, LogLevel.Information)
                        .EnableSensitiveDataLogging());

                    ConfigureRepositoryWrapper(services);
                    services.AddSingleton<NavigationControl>();
                    services.AddTransient<MainWindow>();
                    services.AddTransient<NewProject>();
                    services.AddTransient<ProjectList>();
                });
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureConfiguration()
        {
            //Build configuration
            _configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json")
                  .Build();
        }

        public static void ConfigureLogging(this IServiceCollection services)
        {
            // Create a logger configuration
            var loggerConfig = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File($"{_configuration!["Logging:LogFile"]}", LogEventLevel.Information); // Write to file

            // Create a Serilog logger instance
            var logger = loggerConfig.CreateLogger();

            services.AddLogging(builder =>
            {
                // Clear default logging providers
                builder.ClearProviders();

                // Add console logger
                builder.AddConsole(options =>
                {
                    // Set the console logger format
                    options.FormatterName = nameof(ConsoleFormatter);

                    // Set the log level threshold for writing logs to the standard error stream
                    options.LogToStandardErrorThreshold = LogLevel.Information;
                });

                // Add Serilog as the logging provider
                builder.AddSerilog(logger, dispose: true);
                // Add debug logger
                builder.AddDebug();
            });
        }
    }
}