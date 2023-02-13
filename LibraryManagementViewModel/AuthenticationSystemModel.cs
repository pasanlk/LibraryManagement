using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementViewModel
{
    public class AuthenticationSystemModel

    {
        public int loginId { get; set; }
        public string password { get; set; }

        public StaffModel Staffs { get; set; }

    }
}
