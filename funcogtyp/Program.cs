using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace Funcogtyp
{

    public class Program
    {

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
    
    public static IWebHostBuilder CreateDefaultBuilder(string[] args)
        {
            var builder = new WebHostBuilder().UseKestrel().UseContentRoot(Directory.GetCurrentDirectory()).ConfigureAppConfiguration((hostingContext, config) =>
            {
                /* setup config */
            }).ConfigureLogging((hostingContext, logging) =>
            {

                logging.SetMinimumLevel(LogLevel.Debug);
                /* setup logging */
            }).UseIISIntegration();
            return builder;
        }
    }
}












//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();
