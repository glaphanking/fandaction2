using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class SeriesSelection : BaseModel
    {
        public int SeasonSelectionId { get; set; }
        public int SeriesId { get; set; }
        public int Pts { get; set; }
        public DateTime? DateGrades { get; set; }

        public DateTime? DateSubmitted { get; set; }

        public int SeriesOptionId { get; set; }

        public int UserId { get; set; }

        public string StatusMsg { get; set; }

        public int SeriesGroupId { get; set; }
        public int Position { get; set; }
        public int SeriesStageId { get; set; }
    }
}
