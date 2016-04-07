using System.Threading.Tasks;
using System.Web.Http;
using FanDaction.Core.Models;
using FanDaction.Data;
using System.Net;

namespace FanDaction.ApiControllers.Controllers
{
    [RoutePrefix("api/emails")]
    public class AutoEmailController : ApiController
    {
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> Get(int? number = null )
        {
            var emails = FanDRepositoryFactory.GetInstance().Emails.GetEmails(number);
            return Ok(emails);
        }

        public async Task<IHttpActionResult> GetById(int id)
        {
            var email = FanDRepositoryFactory.GetInstance().Emails.GetEmailById(id);
            if (email != null) return NotFound();

            return Ok(email);
        }

        public async Task<IHttpActionResult> UpdateEmail(int id, EmailTemplate email)
        {
            email.Id = id;
            var db = FanDRepositoryFactory.GetInstance();
            var update = await db.Emails.UpdateAsync(email);
            var result = await db.SaveAsync();

            return Ok(update);
        }

        public async Task<IHttpActionResult> AddEmailTemplate(EmailTemplate email)
        {
            EmailTemplate e = new EmailTemplate();
            var db = FanDRepositoryFactory.GetInstance();
            var add = await db.Emails.UpdateAsync(e);
            var result = await db.SaveAsync();
            return Ok(add);

        }
    }
}