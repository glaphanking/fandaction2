using FanDaction.Core.Models;
using FanDaction.Core.ViewModels;
using System.Linq;

namespace FanDaction.Data.Interfaces
{
    public interface IAdminRepository : IBaseRepository<Admin>
    {
        IQueryable<AdminVM> GetAdmins(string letter = null);
    }
}
