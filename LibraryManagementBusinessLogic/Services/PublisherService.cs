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
            if(newPublisher !=null)
            {
                Publisher newAddingPublisher = new Publisher()
                {
                    publisher_id=newPublisher.publisherId,
                    name= newPublisher.name,
                    year_of_publication=newPublisher.yearOfPublication,
                };

                publisherDbContext.Publishers.Add(newAddingPublisher);
                publisherDbContext.SaveChanges();   
            }
        }

        public void UpdatePublisher(PublisherModel newPublisher)
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
    }
}
