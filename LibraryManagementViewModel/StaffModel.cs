using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementViewModel
{
    public class StaffModel
    {
        public int satffId { get; set; }
        public string name { get; set; }
        public int loginId { get; set; }



        public AuthenticationSystemModel AuthenticationSystem { get; set; }
        
        public ReportModel Reports { get; set; }
        
        public StaffReaderModel StaffReader { get; set; }
    }
}
