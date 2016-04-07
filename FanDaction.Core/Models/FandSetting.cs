using FanDaction.Core.Models.Base;

namespace FanDaction.Core.Models
{
    public class FandSetting : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BannedStates { get; set; }
        public string AuthModel { get; set; }
        public string AuthUserName { get; set; }
        public string AuthPassword { get; set; }
        public string PayPalToken { get; set; }
        public int FantaStockFactor { get; set; }
    }
}
