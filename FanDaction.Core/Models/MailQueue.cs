using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class MailQueue : BaseModel
    {
        public DateTime? SubmitDate { get; set; }
        public string FromField { get; set; }
        public string ToField { get; set; }

        public string Subject { get; set; }

        public string BodyText { get; set; }

        public string BodyHtml { get; set; }

        public DateTime? DateSent { get; set; }

        public string Token { get; set; }
    }
}
