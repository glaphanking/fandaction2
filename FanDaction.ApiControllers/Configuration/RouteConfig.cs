using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace FanDaction.ApiControllers.Configuration
{
    public static class RouteConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new CustomHeaderHandler());
        }
    }

    public class CustomHeaderHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return base.SendAsync(request, cancellationToken).ContinueWith(
                (task) =>
                {
                    HttpResponseMessage response = task.Result;
                    response.Headers.Add("Cache-Control", "no-cache");
                    response.Headers.Add("Pragma", "no-cache");
                    return response;
                }, cancellationToken);
        }
    }
}