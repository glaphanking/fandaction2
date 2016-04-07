using System.Threading.Tasks;
using System.Web.Http;
using FanDaction.Core.Models;
using FanDaction.Data;
using System.Net;

namespace FanDaction.ApiControllers.Controllers
{
    [RoutePrefix("api/settings")]
    public class SettingsController : ApiController
    {
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> Get(string name= null)
        {
            var settings = FanDRepositoryFactory.GetInstance().Settings.GetSettings(name);
            return Ok(settings);
        }

        public async Task<IHttpActionResult> GetById(int id)
        {
            var setting = FanDRepositoryFactory.GetInstance().Settings.GetSettingById(id);
            if (setting != null) return NotFound();
            return Ok(setting);
        }

        public async Task<IHttpActionResult> UpdateSetting(int id, FandSetting setting)
        {
            setting.Id = id;
            var db = FanDRepositoryFactory.GetInstance();
            var update = await db.Settings.UpdateAsync(setting);
            var result = await db.SaveAsync();
            return Ok(update);
        }


        public async Task<IHttpActionResult> AddSetting(string name, string description)
        {
            FandSetting set = new FandSetting();
            set.Name = name;
            set.Description = description;

            var db = FanDRepositoryFactory.GetInstance();
            var add = await db.Settings.UpdateAsync(set);
            var result = await db.SaveAsync();
            return Ok(add);
        }

        
    }
}