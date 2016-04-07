using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FanDaction.Core.Models;

namespace FanDaction.Data
{
    public class DevInitializer : DropCreateDatabaseAlways<FandDbContext>
    {
        FandDbContext context;

        protected override void Seed(FandDbContext context)
        {
            var app = new AppSettingsReader();
            var isServer = (Boolean)app.GetValue("isServer", typeof(Boolean));

            if (isServer) return; //no sample data
            this.context = context;

            var startInit = DateTime.Now;

            #region Settings
            List<FandSetting> settings = new List<FandSetting>();

            var set1 = context.Set<FandSetting>().Add(new FandSetting()
            {
                Name = "Test Setting",
                Description = "Test Description",
                AuthModel = "AuthModel",
                AuthPassword = "********",
                AuthUserName = "Admin",
                BannedStates = "OH",
                FantaStockFactor = 1,
                PayPalToken = "1234567899",
                
            });

            settings.Add(set1);

            #endregion

            #region Admins
            //List<Admin> admins = new List<Admin>();
            //var a = context.Set<Admin>().Add(new Admin()
            //{
            //    AdminName = "HHill99",
            //    IsAdmin = true,
            //    CanDelete = true,
            //    CanGrade = true,
            //    CanSeeCreditCards = true,
            //    CanSeeEmails = true,
            //    Password = "propane",
            //    CreateDate = DateTime.Today,
            //    Email = "hhill@stricklandpropane.com"
            //});

            //admins.Add(a);

            #endregion

            #region Categories

            List<Category> categories = new List<Category>();
            var nfl = context.Set<Category>().Add(new Category()
            {
                Name = "NFL",
                FeedPrefix = "nfl_",
            });
            var cfb = context.Set<Category>().Add(new Category()
            {
                Name = "CFB",
                FeedPrefix = "cfb_",
            });

            var nba = context.Set<Category>().Add(new Category()
            {
                Name = "NBA",
                FeedPrefix = "nba_",
            });

            var cbb = context.Set<Category>().Add(new Category()
            {
                Name = "CBB",
                FeedPrefix = "cbb_",
            });
            var mlb = context.Set<Category>().Add(new Category()
            {
                Name = "MLB",
                FeedPrefix = "mlb_",
            });
            var nhl = context.Set<Category>().Add(new Category()
            {
                Name = "NHL",
                FeedPrefix = "nhl_",
            });
            var pga = context.Set<Category>().Add(new Category()
            {
                Name = "PGA",
                FeedPrefix = "pga_",
            });
            var horses = context.Set<Category>().Add(new Category()
            {
                Name = "Horses",
                FeedPrefix = "horses_",
            });

            categories.Add(nfl);
            categories.Add(cfb);
            categories.Add(nba);
            categories.Add(cbb);
            categories.Add(mlb);
            categories.Add(nhl);
            categories.Add(pga);
            categories.Add(horses);

            #endregion

            context.SaveChanges();
        }
    }
}
