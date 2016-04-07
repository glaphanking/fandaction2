using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
   public class QuestionOption : BaseModel
    {
        public int SeriesQuestionId { get; set; }

        public string Name { get; set; }

        public int PlayerId { get; set; }

        public string TeamShort { get; set; }

        public decimal Cost { get; set; }

        public int Points { get; set; }
    }
}
