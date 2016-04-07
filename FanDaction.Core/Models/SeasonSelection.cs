using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class SeasonSelection : BaseModel
    {
        public int UserId { get; set; }
        public int SeriesOptionId { get; set; }
        public int SeriesId { get; set; }
    }
}
