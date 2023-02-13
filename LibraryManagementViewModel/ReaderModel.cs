using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementViewModel
{
    public class ReaderModel
    {
        public int readerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public virtual BookReservationModel Book_Reservation { get; set; }
        public ReportModel Reports { get; set; }
        
        public StaffReaderModel Staff_Reader { get; set; }
    }
}
