using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.ViewModels
{
    public class SettingVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BannedStates { get; set; }
        public string AuthModel { get; set; }
        public string AuthUser { get; set; }
        public string AuthPass { get; set; }

        public string PaypalToken { get; set; }

        public int FantaStockFactor { get; set; }
    }
}
