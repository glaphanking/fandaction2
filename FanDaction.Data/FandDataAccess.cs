using FanDaction.Data.Interfaces;
using FanDaction.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data
{
    public class FandDataAccess : IFandDataAccess
    {
        private readonly FandDbContext _dbContext;

        #region Interfaces
        private IAdminRepository _admins;
        private ISettingsRepository _settings;
        private ICategoryRepository _categories;
        private IAutoEmailRepository _emails;
        #endregion

        public FandDataAccess()
        {
            _dbContext = new FandDbContext();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public IAdminRepository Admins => _admins ?? (_admins = new AdminRepository(_dbContext, this));
        public ISettingsRepository Settings => _settings ?? (_settings = new SettingsRepository(_dbContext, this));
        public ICategoryRepository Categories => _categories ?? (_categories = new CategoryRepository(_dbContext, this));
        public IAutoEmailRepository Emails => _emails ?? (_emails = new AutoEmailRepository(_dbContext, this));

        public void Dispose()
        {
            _admins?.Dispose();
            _settings?.Dispose();
            _categories?.Dispose();
            _emails?.Dispose();

            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
