using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class Bonus : BaseModel
    {
        public string BonusName { get; set; }

        public string Description { get; set; }

        public Admin Admin { get; set; }

        public string PromoCode { get; set; }

        public DateTime? PromoBegin { get; set; }
        public DateTime? PromoEnd { get; set; }

        public int AddFreeBalance { get; set; }

        public bool Enabled { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool Activated { get; set; }
    }
}
