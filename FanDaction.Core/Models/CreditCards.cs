using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class CreditCards : BaseModel
    {
        public int UserId { get; set; }
        public string CardNumber { get; set; }

        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CVS { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string First { get; set; }

        public string Middle { get; set; }

        public string Last { get; set; }

        public bool Deleted { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
