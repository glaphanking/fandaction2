using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class SeriesStage : BaseModel
    {
        public int SeriesId { get; set; }
        public string Name { get; set; }
        public string Budget { get; set; }

        public string Image { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? PublishDate { get; set; }

        public int Status { get; set; }

        public int Index { get; set; }

        public int TotalSelections { get; set; }

        public bool AutoGrouping { get; set; }

        public bool AutoGrading { get; set; }


    }
}
