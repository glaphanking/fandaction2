using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class RestrictedIPAddress : BaseModel
    {
        public string IPAddr { get; set; }

        public string Comment { get; set; }

        public DateTime? LastUseDate { get; set; }
    }
}
