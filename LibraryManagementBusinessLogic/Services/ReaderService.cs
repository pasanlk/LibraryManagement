using LibraryManagementData.DataModel;
using LibraryManagementViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            try
            {
                if (newReader != null)
                {
                    Reader newAddingReader = new Reader()
                    {
                        reader_id = newReader.readerId,
                        first_name = newReader.firstName,
                        last_name = newReader.lastName,
                        email = newReader.email,
                        address = newReader.address,
                        phone = newReader.phone,

                    };
                    readerDbContext.Readers.Add(newAddingReader);
                    readerDbContext.SaveChanges();


                }
               
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void UpdateReader(ReaderModel newReader)
        {
            try
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
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public Reader GetReader(int searchId)
        {
            try
            {
                return readerDbContext.Readers.Find(searchId);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteReader(int searchId) {
            try
            {
                Reader existing = readerDbContext.Readers.Find(searchId);
                readerDbContext.Readers.Remove(existing);
                readerDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }




    }
}
