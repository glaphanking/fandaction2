using System.Threading.Tasks;
using System.Web.Http;
using FanDaction.Core.Models;
using FanDaction.Data;

namespace FanDaction.ApiControllers.Controllers
{
    [RoutePrefix("api/admins")]
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> Get(string letter = null)
        {
            var admins = FanDRepositoryFactory.GetInstance().Admins.GetAdmins(letter);

            return Ok(admins);
        }
    }
}