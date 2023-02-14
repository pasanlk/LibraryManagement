using LibraryManagementData.DataModel;
using LibraryManagementViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinessLogic.Services
{
    public  class BookService
    {

        //asdfghjkkkk

        /*
         * asdfg
         * asdfgh
         */
        private static LibrarySystemEntities bookDbContext = null;

        public BookService() { 

            bookDbContext= new LibrarySystemEntities();

        }

        // addBook method 
        public void AddBook(BookModel newBook)
        {

            try {

                if (newBook != null)
                {
                    Publisher bookPublisher = new Publisher();
                    bookPublisher.publisher_id = newBook.PublisherId;
                    bookPublisher.name = newBook.Publisher.name;


                    Book newAddingBook = new Book()
                    {
                        isbn_number = newBook.IsbnNumber,
                        title = newBook.Title,
                        authno = newBook.Authno,
                        edition = newBook.Edition,
                        category = newBook.Category,
                        staff_id = newBook.StaffId,
                        publisher_id = newBook.PublisherId,
                        release_date = newBook.ReleaseDate,
                        price = newBook.Price,

                    };

                    bookDbContext.Books.Add(newAddingBook);
                    bookDbContext.SaveChanges();
                }
                




            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                var x = 5;
            }

            

            




        }

        public void UpdateBook(BookModel newBook)
        {

            try
            {
                Publisher bookPublisher = new Publisher();
                bookPublisher.publisher_id = newBook.PublisherId;
                bookPublisher.name = newBook.Publisher.name;


                Book newUpdatingBook = new Book()
                {


                    isbn_number = newBook.IsbnNumber,
                    title = newBook.Title,
                    authno = newBook.Authno,
                    edition = newBook.Edition,
                    category = newBook.Category,
                    staff_id = newBook.StaffId,
                    publisher_id = newBook.PublisherId,
                    release_date = newBook.ReleaseDate,
                    price = newBook.Price,

                };

                bookDbContext.Books.Append(newUpdatingBook);
                bookDbContext.SaveChanges();
            }
            catch(Exception ex ) { throw ex; }  

        }

        public Book  GetBook(int searchId)
        {
            try
            {
                return bookDbContext.Books.Find(searchId);
            }
            catch(Exception ex) { throw ex; }
        }

        public void DeleteBook(int searchId)
        {
            try
            {
                Book existing = bookDbContext.Books.Find(searchId);
                bookDbContext.Books.Remove(existing);
                bookDbContext.SaveChanges();
            }
            catch(Exception ex) { throw ex; }   
        }

    }
}
