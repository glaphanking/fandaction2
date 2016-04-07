using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class SeriesQuestion : BaseModel
    {
        public int SeriesId { get; set; }

        public int QuestionOrder { get; set; }

        public string Question { get; set; }

        public int MaxSelections { get; set; }

        public int MinSelections { get; set; }

        public int SeriesStageId { get; set; }
    }
}
