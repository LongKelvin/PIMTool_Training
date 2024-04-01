using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using PIMTool.DataAccess;

namespace PIMTool.Winforms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure DI container
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Create service provider
            using (var serviceProvider = services.BuildServiceProvider())
            {
                // Resolve DbContext
                var dbContext = serviceProvider.GetRequiredService<PIMToolDbContext>();

                // Apply pending migrations (optional)
                dbContext.Database.Migrate();

                // Run the application
                Application.Run(new MainWindow());
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Build configuration
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // Load connection string from appsettings.json
            //string connectionString = config.GetConnectionString("PIMToolDbConnection")!;

            // Configure DbContext with SQL Server provider and connection string
            //services.AddDbContext<PIMToolDbContext>(options =>
            //options.UseSqlServer(connectionString));
        }
    }
}