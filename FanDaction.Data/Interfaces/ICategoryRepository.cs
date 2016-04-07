using FanDaction.Core.Models;
using FanDaction.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        IQueryable<CategoryListVM> GetCategories(string name = null);

        Category AddCategory(string name = null, string prefix = null);

        bool DoesCategoryExist(string name = null);

        int GetCategoryId(string feedPrefix);
    }
}
