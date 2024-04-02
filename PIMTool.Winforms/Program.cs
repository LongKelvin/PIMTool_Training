using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(ServiceProvider.GetRequiredService<MainWindow>());
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
                    services.AddTransient<MainWindow>();
                    services.AddDbContext<DbContext, PIMToolDbContext>(options => options.UseSqlServer(connectionString));
                });
        }
    }
}