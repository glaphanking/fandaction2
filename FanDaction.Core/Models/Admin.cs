using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class Admin : BaseModel
    {
        public string Name { get; set; }

        public string AdminName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public bool IsAdmin { get; set; }

        public bool CanGrade { get; set; }

        public bool CanSeeEmails { get; set; }

        public bool CanSeeCreditCards { get; set; }

        public bool CanDelete { get; set; }

        public string RestrictedIPAccess { get; set; }

        public DateTime? LastLogin { get; set; }

        public string LastLoginLocation { get; set; }

        public DateTime? LastPasswordUpdate { get; set; }
       
        public DateTime? CreateDate { get; set; }

        public bool IsLogged { get; set; }
    }
}
