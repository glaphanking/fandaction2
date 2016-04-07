using System.Threading.Tasks;
using System.Web.Http;
using FanDaction.Core.Models;
using FanDaction.Data;
using System.Net;

namespace FanDaction.ApiControllers.Controllers
{
    [RoutePrefix("api/players")]
    public class PlayersController : ApiController
    {
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAllPlayers(string lastname = null)
        {
            throw new System.Exception();
        }

        [HttpPost]
        public async Task<IHttpActionResult> AddPlayer(int categoryId, string teamShort, int teamId, string firstname, string lastname, string position, int number, string teamName)
        {
            throw new System.Exception();
        }

        public async Task<IHttpActionResult> GetPlayer(string lastname = null, string firstname = null)
        {
            throw new System.Exception();
        }
    }
}