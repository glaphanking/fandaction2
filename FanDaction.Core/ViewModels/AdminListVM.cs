using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.ViewModels
{
    public class AdminListVM
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public string Email { get; set; }

        public DateTime LastLogin { get; set; }
    }
}
