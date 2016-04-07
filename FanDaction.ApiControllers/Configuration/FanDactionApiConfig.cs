using System.Web.Http;

namespace FanDaction.ApiControllers.Configuration
{
    public static class FanDactionApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            FormatterConfig.Register(config);
            RouteConfig.Register(config);
        }
    }
}