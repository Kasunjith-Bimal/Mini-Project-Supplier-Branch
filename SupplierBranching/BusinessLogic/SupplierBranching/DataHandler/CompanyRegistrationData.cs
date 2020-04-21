using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class CompanyRegistrationData
    {

        public void addCompanyRegistrationDb(CompanyRegistrationDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    CompanyRegistraion data = new CompanyRegistraion();

                    data.CompanyName = obj.CompanyName;
                    data.Address = obj.Address;
                    data.CompanyRegistrationNo = obj.CompanyRegistrationNo;
                    data.Email = obj.Email;
                    data.PaperId = obj.Paperid;
                    data.Phone = obj.TelephoneNo;
                    data.RegistrationDate = obj.RegistrationDate;

                    context.CompanyRegistraions.Add(data);
                    context.SaveChanges();
                 





                }



            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
