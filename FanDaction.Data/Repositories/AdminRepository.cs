using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models;
using FanDaction.Core.ViewModels;
using FanDaction.Core.ValueTypes;
using FanDaction.Data.Repositories;
using FanDaction.Data.Interfaces;

namespace FanDaction.Data.Repositories
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository() { }

        public AdminRepository(FandDbContext dbContext, IFandDataAccess dataAccess)
            : base(dbContext, dataAccess)
        { }

        public IQueryable<AdminVM> GetAdmins(string letter = null)
        {
            var admins = Context.Set<Admin>().AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(letter)) admins = admins.Where(a => a.AdminName.StartsWith(letter));

            var q = from a in admins
                    orderby a.AdminName
                    select new AdminVM
                    {
                        Id = a.Id,
                        AdminName = a.AdminName,
                        CanDelete = a.CanDelete,
                        CanEdit = a.CanGrade,
                        CanSeeCreditCards = a.CanSeeCreditCards,
                        CanSeeEmails = a.CanSeeEmails,
                        Email = a.Email,
                        IsAdmin = a.IsAdmin,
                        LastLogin = (DateTime?)a.LastLogin ?? DateTime.MinValue
                    };

            return q;
        }
    }

    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            ToTable("Admin");
        }
    }
}
