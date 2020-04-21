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

        public List<CompanyRegistrationDTO> getlistdb()
        {
            List<CompanyRegistrationDTO> companylist = new List<CompanyRegistrationDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<CompanyRegistraion> company = (from recode in context.CompanyRegistraions select recode).ToList();

                    
                    foreach (var item in company)
                    {
                        CompanyRegistrationDTO obj = new CompanyRegistrationDTO();

                        obj.id=item.Id;
                        obj.Paperid = item.PaperId;
                        obj.TelephoneNo =  item.Phone;
                        obj.RegistrationDate =item.RegistrationDate;
                        obj.Email =item.Email;
                        obj.CompanyRegistrationNo =item.CompanyRegistrationNo;
                        obj.CompanyName =item.CompanyName;
                        obj.Address =item.Address;



                        companylist.Add(obj);
                        
                    }
                
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return companylist;
        }

        public List<CompanyRegistrationDTO> SearchlistDb(String Search)
        {
            List<CompanyRegistrationDTO> list = new List<CompanyRegistrationDTO>();

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    List<CompanyRegistraion> company = context.CompanyRegistraions.Where(p => p.CompanyName.Contains(Search)).ToList();

                    foreach (var item in company)
                    {
                        CompanyRegistrationDTO obj = new CompanyRegistrationDTO();


                        obj.Address = item.Address;
                        obj.CompanyName = item.CompanyName;
                        obj.CompanyRegistrationNo = item.CompanyRegistrationNo;
                        obj.Email = item.Email;
                        obj.id = item.Id;
                        obj.Paperid = item.PaperId;
                        obj.RegistrationDate = item.RegistrationDate;
                        obj.TelephoneNo = item.Phone;


                        list.Add(obj);

                    }
                                                  
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return list;
        }

        public void EditCompanyRegistrationDb(CompanyRegistrationDTO obj)
        {

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    CompanyRegistraion company = (from recode in context.CompanyRegistraions where recode.Id == obj.id select recode).FirstOrDefault();


                    company.Address = obj.Address;
                    company.CompanyName = obj.CompanyName;
                    company.CompanyRegistrationNo = obj.CompanyRegistrationNo;
                    company.Email = obj.Email;
                    company.Phone = obj.TelephoneNo;
                    company.RegistrationDate = obj.RegistrationDate;

                    context.Entry(company).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                   

                
                
                
                }

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

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    CompanyRegistraion company = (from recode in context.CompanyRegistraions where recode.Id == id select recode).FirstOrDefault();


                    context.Entry(company).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void dsd()
        {


        }
    }
}
