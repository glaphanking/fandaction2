using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models.Base
{
    public class BaseModel : IAuditableModel
    {
        public int Id { get; set; }
        public Guid? SyncId { get; set; }
    }

    public interface IAuditableModel
    {
    }
}
