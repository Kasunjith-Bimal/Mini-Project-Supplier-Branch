using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CompanyRegistrationLogic
    {
        CompanyRegistrationData db = new CompanyRegistrationData();
        public void addCompanyRegistration(CompanyRegistrationDTO obj)
        {
            try
            {

                db.addCompanyRegistrationDb(obj);


            }
            catch (Exception ex)
            {
                
                throw;
            }

        }
    }
}
