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


        public List<CompanyRegistrationDTO> getlist()
        {
            List<CompanyRegistrationDTO> company = new List<CompanyRegistrationDTO>();
            try
            {
              company =  db.getlistdb();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return company;
        }


        public List<CompanyRegistrationDTO> Searchlist(String Search)
        {
            List<CompanyRegistrationDTO> list = new List<CompanyRegistrationDTO>();

            try
            {

               list = db.SearchlistDb(Search);
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return list; 
        }


        public void EditCompanyRegistration(CompanyRegistrationDTO  obj)
        {

            try
            {
                db.EditCompanyRegistrationDb(obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public void deleteCompany(int id)
        {
            try
            {
                db.deleteCompany(id);
            }
            catch (Exception ex)
            {
                
                throw;
            }


        }
        public void a()
        {

        }
    }
}
