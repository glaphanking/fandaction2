using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class Series : BaseModel
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public DateTime? DateCreated { get; set; }

        public bool Active { get; set; }

        public DateTime? StartDate { get; set; }

        public bool Seasonal { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? PublishDate { get; set; }

        public string Type { get; set; }

        public string Image { get; set; }

        public int Status { get; set; }

        public bool IsPrivate { get; set; }

        public string PrivateName { get; set; }

        public string UrlSuffix { get; set; }

        public string PrivatePassword { get; set; }

        public bool PasswordRequired { get; set; }
    }
}
