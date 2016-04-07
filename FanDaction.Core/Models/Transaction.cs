using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models.Base;
using FanDaction.Core.ValueTypes;

namespace FanDaction.Core.Models
{
    public  class Transaction : BaseModel
    {
        public int UserId { get; set; }

        public int CCId { get; set; }

        public string IPAddress { get; set; }

        public PayMethod PayMethod { get; set; }

        public int Amount { get; set; }

        public DateTime? SubmitDate { get; set; }

        public string Comment { get; set; }
    }
}
