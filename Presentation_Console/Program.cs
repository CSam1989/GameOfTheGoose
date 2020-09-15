using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            // Calls the Run method in App, which is replacing Main
            serviceProvider.GetService<App>().Run();
        }
        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            //Add services from other layers
            //services.AddApplication();

            //Add Settings to IOC Container
            var config = LoadConfiguration();
            // IConfiguration to IOC Container
            services.AddSingleton(config);

            // AppConfig to IOC Container
            //var appConfig = config.GetSection("BoardSettings").Get<AppConfig>();
            //services.AddSingleton(appConfig);

            //Add Services To IOC Container
            //services.AddTransient<IInputService, InputService>();

            services.AddTransient<App>();

            return services;
        }

        private static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            return builder.Build();
        }
    }
}
