using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class SeriesStageGame : BaseModel
    {
        public int SeriesId { get; set; }

        public int GameId { get; set; }

        public int SeriesStageId { get; set; }
    }
}
