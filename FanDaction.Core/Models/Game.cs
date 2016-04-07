using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class Game : BaseModel
    {
        public int CategoryId { get; set; }

        public int Code { get; set; }

        public int GlobalId { get; set; }

        public string Visit { get; set; }
        public string Home { get; set; }

        public DateTime? EventDate { get; set; }

        public string Status { get; set; }
    }
}
