using FanDaction.Core.Models;
using FanDaction.Core.ViewModels;
using FanDaction.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository() { }

        public CategoryRepository(FandDbContext dbContext, IFandDataAccess dataAccess)
            : base(dbContext, dataAccess)
        { }

        public IQueryable<CategoryListVM> GetCategories(string name = null)
        {
            var categories = Context.Set<Category>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(name)) categories = categories.Where(c => c.Name.StartsWith(name));

            var q = from c in categories
                    orderby c.Name
                    select new CategoryListVM
                    {
                        Id = c.Id,
                        Name = c.Name,
                        FeedPrefix = c.FeedPrefix,
                    };
            return q;
        }

        public Category AddCategory(string name = null, string prefix = null)
        {
            Category cat = new Category
            {
                Name = name,
                FeedPrefix = prefix
            };

            Context.Set<Category>().Add(cat);

            if (Context.SaveChanges() > 0)
                return cat;
            else
                return null;
        }

        public bool DoesCategoryExist(string name)
        {
            var categories = Context.Set<Category>().AsQueryable();

            if (categories.Any(c => c.Name == name))
                return true;
            else
                return false;
        }

        public int GetCategoryId(string feedPrefix)
        {
            var categories = Context.Set<Category>().AsQueryable();
            Category cat = null;
            if (categories.Any(c => c.FeedPrefix == feedPrefix))
            {
                categories = categories.Where(c => c.FeedPrefix.StartsWith(feedPrefix));
                return categories.FirstOrDefault().Id;
            }
            else
                return -1;

        }

        public bool PlayersExist(int playerId, int categoryId, string teamShort)
        {
            if ((playerId > 0) && (categoryId > 0) && (!string.IsNullOrEmpty(teamShort)))
            {
                var players = Context.Set<Player>().AsQueryable().Where(p => p.Id == playerId).Where(p => p.CategoryId == categoryId);
                int count = players.Count();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public int AddPlayers(int categoryId, string teamShort, int teamId, string firstname, string lastname, string position, int number, string teamName)
        {
            if(categoryId > 0 && !string.IsNullOrEmpty(teamShort))
            {
                Player player = new Player
                {
                    First = firstname,
                    Last = lastname,
                    TeamId = teamId,
                    Position = position,
                    Number = number,
                    CategoryId = categoryId,
                    Image = "",
                    TeamName = teamName,
                    TeamShort = teamShort,
                };

                Context.Set<Player>().Add(player);

                return Context.SaveChanges();
            }

            return -1;
        }
    }

    public class CategoriesMap : EntityTypeConfiguration<Category>
    {
        public CategoriesMap()
        {
            ToTable("Categories");
        }
    }
}
