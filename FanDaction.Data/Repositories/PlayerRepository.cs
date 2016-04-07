using FanDaction.Core.Models;
using FanDaction.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository() { }

        public PlayerRepository(FandDbContext dbContext, IFandDataAccess dataAccess)
            : base(dbContext, dataAccess)
        { }

        public void AddPlayer(Player player)
        {
            var players = Context.Set<Player>().Add(player);

            Context.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            var player = Context.Set<Player>().Any(p => p.Id == id);


        }
    }
}
