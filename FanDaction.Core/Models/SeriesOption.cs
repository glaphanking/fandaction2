using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class SeriesOption : BaseModel
    {
        public decimal Fee { get; set; }

        public int Players { get; set; }

        public decimal Prize { get; set; }

        public int MinPlayers { get; set; }

        public int SeriesId { get; set; }

        public bool Enabled { get; set; }

        public int Position { get; set; }

        public bool Visible { get; set; }

        public int SeriesStageId { get; set; }
    }
}
