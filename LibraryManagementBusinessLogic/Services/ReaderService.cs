using LibraryManagementData.DataModel;
using LibraryManagementViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinessLogic.Services
{
    public class ReaderService
    {

        private static LibrarySystemEntities readerDbContext = null;

        public ReaderService()
        {
            readerDbContext = new LibrarySystemEntities();
        }

        public void AddReader(ReaderModel newReader)
        {
            if( newReader !=null )
            {
                Reader newAddingReader = new Reader() 
                {
                    reader_id=newReader.readerId,
                    first_name=newReader.firstName,
                    last_name=newReader.lastName,
                    email=newReader.email,
                    address=newReader.address,
                    phone=newReader.phone,

                };
                readerDbContext.Readers.Add(newAddingReader);
                readerDbContext.SaveChanges();


            }

        }

        public void UpdateReader(ReaderModel newReader)
        {
            if (newReader != null)
            {
                Reader UpdatingReader = new Reader()
                {
                    reader_id = newReader.readerId,
                    first_name = newReader.firstName,
                    last_name = newReader.lastName,
                    email = newReader.email,
                    address = newReader.address,
                    phone = newReader.phone,

                };
                readerDbContext.Readers.Append(UpdatingReader);
                readerDbContext.SaveChanges();


            }

        }




    }
}
