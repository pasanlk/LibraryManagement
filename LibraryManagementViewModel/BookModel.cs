using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementViewModel
{
    public class BookModel
    {

        

        public int IsbnNumber { get; set; }
        public string Authno { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string Category { get; set; }
        public int StaffId { get; set; }
        public int PublisherId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double  Price { get; set; }

        public BookReservationModel BookReservation { get; set; }
        public virtual PublisherModel Publisher { get; set; }
    
        
}
}
