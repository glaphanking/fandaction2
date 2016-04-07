using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class SeasonalWinner : BaseModel
    {
        public int SeriesId { get; set; }
        public int SeriesGroupId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Pts { get; set; }

        public int Position { get; set; }

        public string SeriesName { get; set; }
        public int SeriesSelectionId { get; set; }
    }
}
