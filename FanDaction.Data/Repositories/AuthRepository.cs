using FanDaction.Core.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data.Repositories
{
    public class AuthRepository : BaseRepository<User>, IAuthRepository
    {
        public AuthRepository() { }

        public AuthRepository(FandDbContext dbContext, FandDataAccess dataAccess)
            : base(dbContext, dataAccess)
        { }

        public async Task<IdentityResult> RegisterUser(User user)
        {
          IUser User = new 
        }
    }
}
