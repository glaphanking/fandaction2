using FanDaction.Core.Models.Base;
using FanDaction.Data.Repositories;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace FanDaction.Data
{
    public class FandDbContext : DbContext
    {
        public FandDbContext()
            : base("fandaction")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new DevInitializer());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new SettingsMap());
            modelBuilder.Configurations.Add(new CategoriesMap());
        }

        public override int SaveChanges()
        {

            var app = new AppSettingsReader();
            var isServer = (bool)app.GetValue("isServer", typeof(bool));
            if (isServer)
            {
                var entityList = ChangeTracker.Entries().Where(p => p.State == EntityState.Added);

                foreach (var entity in entityList)
                {
                    if (!(entity.Entity is BaseModel)) continue;
                    (entity.Entity as BaseModel).SyncId = Guid.NewGuid();
                }
            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            var app = new AppSettingsReader();
            var isServer = (bool)app.GetValue("isServer", typeof(bool));
            if (isServer)
            {
                var entityList = ChangeTracker.Entries().Where(p => p.State == EntityState.Added);

                foreach (var entity in entityList.Where(entity => entity.Entity is BaseModel))
                {
                    ((BaseModel)entity.Entity).SyncId = Guid.NewGuid();
                }
            }

            return await base.SaveChangesAsync();
        }
    }
}