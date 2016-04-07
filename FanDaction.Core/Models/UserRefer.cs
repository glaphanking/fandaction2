using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class UserRefer : BaseModel
    {
        public bool Activated { get; set; }
        public int UserId { get; set; }
        public string ReferEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateInserted { get; set; }

        public bool UserCreated { get; set; }

        public DateTime? DateAccountCreated { get; set; }
        public bool Deposited { get; set; }

        public DateTime? DateDeposited { get; set; }

        public bool PlayedGames { get; set; }

        public DateTime? DatePlayedGames { get; set; }
    }
}
