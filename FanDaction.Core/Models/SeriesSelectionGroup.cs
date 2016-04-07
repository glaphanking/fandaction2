using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class SeriesSelectionGroup : BaseModel
    {
        public int SeriesOptionId { get; set; }

        public int GroupNumber { get; set; }
    }
}
