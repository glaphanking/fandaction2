using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class BonusTransaction : BaseModel
    {
        public int BonusId { get; set; }
        public int UserId { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public string Comment { get; set; }
    }
}
