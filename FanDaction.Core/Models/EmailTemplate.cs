using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class EmailTemplate : BaseModel
    {
        public string Body { get; set; }

        public string Subject { get; set; }

        public string Reserved { get; set; }

        public bool Enabled { get; set; }

        public string Token { get; set; }
    }
}
