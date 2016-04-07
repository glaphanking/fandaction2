using FanDaction.Core.Models;
using System.Linq;
using FanDaction.Core.ViewModels;

namespace FanDaction.Data.Interfaces
{
    public interface ISettingsRepository : IBaseRepository<FandSetting>
    {
        IQueryable<SettingVM> GetSettings(string name = null, string description = null);

        IQueryable<SettingVM> GetSettingById(int id);
    }
}
