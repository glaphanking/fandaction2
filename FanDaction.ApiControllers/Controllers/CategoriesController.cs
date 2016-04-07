using System.Threading.Tasks;
using System.Web.Http;
using FanDaction.Core.Models;
using FanDaction.Data;
using System.Net;

namespace FanDaction.ApiControllers.Controllers
{
    [RoutePrefix("api/categories")]
    public class CategoriesController : ApiController
    {
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> Get(string name = null)
        {
            var categories = FanDRepositoryFactory.GetInstance().Categories.GetCategories(name);
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IHttpActionResult> AddCategory(string name, string prefix)
        {
            bool exists =  FanDRepositoryFactory.GetInstance().Categories.DoesCategoryExist(name);
            if (!exists)
            {
                var category = FanDRepositoryFactory.GetInstance().Categories.AddCategory(name, prefix);
                return Ok();
            }
            else
                return BadRequest("Category already exists!");
        }

        public async Task<IHttpActionResult> DeleteCategory(int id)
        {
            Category category = FanDRepositoryFactory.GetInstance().Categories.FindById(id);

            if(category != null)
            {
                var result = FanDRepositoryFactory.GetInstance().Categories.Delete(category);
                if (result > 0)
                    return Ok();
                else
                    return BadRequest("There was a problem deleting the category");
            }
            else
            {
                return BadRequest("Category Not Found!");
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> GetCategoryId(string feedPrefix)
        {
            int id = FanDRepositoryFactory.GetInstance().Categories.GetCategoryId(feedPrefix);
            if(id > 0)
            {
                return Ok(id);
            }
            else
            {
                return BadRequest("Could not find Category Id. Check the Id and try again!");
            }
        }
    }
}