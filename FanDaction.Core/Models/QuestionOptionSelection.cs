using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class QuestionOptionSelection : BaseModel
    {
        public int SeriesQuestionId { get; set; }
        public int Pts { get; set; }
        public int QuestionOptionId { get; set; }

        public int SeriesSelectionId { get; set; }

        public int ConfidenceChoice { get; set; }
    }
}
