using LibraryManagementData.DataModel;
using LibraryManagementViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementBusinessLogic.Services
{
    internal class StaffService
    {

        private static LibrarySystemEntities staffDbContext=null;

        public StaffService()
        {
            staffDbContext = new LibrarySystemEntities();
        }

        //add staff method 
        public void AddStaff(StaffModel newStaff)
        {



            try
            {
                if (newStaff != null)
                {
                    Staff newAddingStaff = new Staff()
                    {
                        satff_id = newStaff.satffId,
                        name = newStaff.name,
                        login_id = newStaff.loginId,
                    };


                    staffDbContext.Staffs.Add(newAddingStaff);
                    staffDbContext.SaveChanges();   
                }

                

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void UpdateStaff(StaffModel newStaff)
        {
            if(newStaff != null)
            {
                Staff newUpdatingStaff = new Staff()
                {
                    satff_id = newStaff.satffId,
                    name = newStaff.name,
                    login_id = newStaff.loginId,
                    
                };

                staffDbContext.Staffs.Append(newUpdatingStaff);
                staffDbContext.SaveChanges();   
            }
        }



    }
}
