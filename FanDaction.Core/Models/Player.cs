using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class Player : BaseModel
    {
        public int TeamId { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public string Position { get; set; }
        public int Number { get; set; }

        public int CategoryId { get; set; }

        public string Image { get; set; }

        public string TeamName { get; set; }

        public string TeamShort { get; set; }
    }
}
