using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper;
using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.DataAccess;

namespace PIMTool.Winforms
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

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

                // Seed data after database initialization
                //DataAccess.SampleData.SampleData.InitializeData(dbContext);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            Application.Run(mainWindow);
        }

        private static IHostBuilder CreateHostBuilder()
        {
            //Build configuration
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            //Load connection string from appsettings.json
            string connectionString = config.GetConnectionString("PIMToolDbConnection")!;

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<DbContext, PIMToolDbContext>(
                        options => options
                        .UseSqlServer(connectionString)
                        .LogTo(Console.WriteLine, LogLevel.Information)
                        .EnableSensitiveDataLogging());

                    //services.AddScoped(typeof(IGenericRepository<>), typeof(RepositoryBase<>));
                    ConfigureRepositoryWrapper(services);

                    services.AddTransient<MainWindow>();
                });
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}