using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.ViewModels
{
    public class AdminVM
    {
        public int Id { get; set; }

        public string AdminName { get; set; }

        public string AdminPassword { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; set; }

        public bool CanEdit { get; set; }

        public bool CanSeeEmails { get; set; }

        public bool CanSeeCreditCards { get; set; }

        public bool CanDelete { get; set; }

        public DateTime LastLogin { get; set; }
    }
}
