using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public bool ShowOnForm { get; set; }
        public string FeedPrefix { get; set; }
    }
}
