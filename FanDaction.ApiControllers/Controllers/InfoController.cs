using System.Reflection;
using System.Web.Http;

namespace FanDaction.ApiControllers.Controllers
{
    [RoutePrefix("api/info")]
    public class InfoController : ApiController
    {
        [HttpGet]
        [Route("version")]
        public IHttpActionResult Version()
        {
            return Ok(Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}