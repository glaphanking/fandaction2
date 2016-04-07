using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using FanDaction.ApiControllers;
using FanDaction.ApiControllers.Configuration;
using FanDaction.ApiControllers.Controllers;
using Microsoft.Owin.Hosting;
using Owin;

namespace FanDaction.ConsoleService
{
    class Program
    {
        static void Main(string[] args)
        {
            var dummy = new InfoController();

            string baseUri = "http://localhost:8080";

            Console.WriteLine("Starting web Server...");
            WebApp.Start<Startup>(baseUri);
            Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
            Console.ReadLine();
        }
    }

    public class Startup
    {
        // This method is required by Katana:
        public void Configuration(IAppBuilder app)
        {
            var webApiConfiguration = ConfigureWebApi();

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            // Use the extension method provided by the WebApi.Owin library:
            app.UseWebApi(webApiConfiguration);
        }


        private HttpConfiguration ConfigureWebApi()
        {
            var config = new HttpConfiguration();
            FanDactionApiConfig.Register(config);
            return config;
        }
    }
}
