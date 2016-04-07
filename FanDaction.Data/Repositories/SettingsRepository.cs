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
    public class SettingsRepository : BaseRepository<FandSetting>, ISettingsRepository
    {
        public SettingsRepository() { }

        public SettingsRepository(FandDbContext dbContext, IFandDataAccess dataAccess)
            : base(dbContext, dataAccess)
        { }

        public IQueryable<SettingVM> GetSettings(string name = null, string description = null)
        {
            var settings = Context.Set<FandSetting>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(name)) settings = settings.Where(s => s.Name.StartsWith(name));

            var q = from s in settings
                    orderby s.Name

                    select new SettingVM
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Description = s.Description,
                        BannedStates = s.BannedStates,
                        AuthModel = s.AuthModel,
                        AuthUser = s.AuthUserName,
                        AuthPass = s.AuthPassword,
                        FantaStockFactor = s.FantaStockFactor,
                    };
            return q;
        }

        public IQueryable<SettingVM> GetSettingById(int id)
        {
            var settings = Context.Set<FandSetting>().AsQueryable();

            var q = from s in settings
                    where s.Id == id
                    select new SettingVM
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Description = s.Description,
                        BannedStates = s.BannedStates,
                        AuthModel = s.AuthModel,
                        AuthUser = s.AuthUserName,
                        AuthPass = s.AuthPassword,
                        FantaStockFactor = s.FantaStockFactor,
                    };
            return q;
        }
    }

    public class SettingsMap : EntityTypeConfiguration<FandSetting>
    {
        public SettingsMap()
        {
            ToTable("Settings");
        }
    }
}
