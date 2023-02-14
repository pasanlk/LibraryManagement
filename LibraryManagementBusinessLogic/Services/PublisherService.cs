using LibraryManagementData.DataModel;
using LibraryManagementViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinessLogic.Services
{
    public class PublisherService
    {
        private static LibrarySystemEntities publisherDbContext = null;

        public PublisherService() { 
            publisherDbContext = new LibrarySystemEntities();
        }

        public void AddPublisher(PublisherModel newPublisher)
        {
            try
            {
                if (newPublisher != null)
                {
                    Publisher newAddingPublisher = new Publisher()
                    {
                        publisher_id = newPublisher.publisherId,
                        name = newPublisher.name,
                        year_of_publication = newPublisher.yearOfPublication,
                    };

                    publisherDbContext.Publishers.Add(newAddingPublisher);
                    publisherDbContext.SaveChanges();
                }
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdatePublisher(PublisherModel newPublisher)
        {
            try
            {
                if (newPublisher != null)
                {
                    Publisher newUpdatingPublisher = new Publisher()
                    {
                        publisher_id = newPublisher.publisherId,
                        name = newPublisher.name,
                        year_of_publication = newPublisher.yearOfPublication,
                    };

                    publisherDbContext.Publishers.Append(newUpdatingPublisher);
                    publisherDbContext.SaveChanges();
                }
            }
            catch(Exception ex) { throw ex; }
        }


        public Publisher GetPublisher(int searchId)
        {
            try
            {
                return publisherDbContext.Publishers.Find(searchId);
            }
            catch(Exception ex) { throw ex; }
        }

        public void DeletePublisher(int searchId)
        {
            try
            {
                Publisher existing = publisherDbContext.Publishers.Find(searchId);
                publisherDbContext.Publishers.Remove(existing);
                publisherDbContext.SaveChanges();
            }
            catch(Exception ex) { throw ex; }
        }
    }
}
