using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class ReqestPersonData
    {
        public void addSectionDb(RegisterPersonDTO obj)
        {

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    RequestPerson registeradddetails = new RequestPerson();


                    registeradddetails.IdentificationCode = obj.IdentificationCode;
                    registeradddetails.Password = obj.Password;
                    registeradddetails.Post = obj.Post;
                    registeradddetails.RequestPersonName = obj.RequestPersonName;
                    registeradddetails.Username = obj.UserName;
                   


                    context.RequestPersons.Add(registeradddetails);
                    context.SaveChanges();



                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public List<string> identificationCode()
        {
            List<string> returnidentificationcode = new List<string>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                   returnidentificationcode = (from recode in context.Sections select recode.IdentificationCode).ToList();
                    


                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return returnidentificationcode;
        }


        public List<RegisterPersonDTO> getallvalues()
        {
            List<RegisterPersonDTO> list = new List<RegisterPersonDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    var select = from a in context.RequestPersons select a;
                    foreach (var item in select)
                    {
                        RegisterPersonDTO dto = new RegisterPersonDTO();
                        dto.id = item.Id;
                        dto.IdentificationCode = item.IdentificationCode;
                        dto.Post = item.Post;
                        dto.RequestPersonName = item.RequestPersonName;
                        dto.UserName = item.Username;
                        dto.Password = item.Password;
                        list.Add(dto);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }


        public void deleteregisterperson(int id)
        {
            
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                   
                    var z = context.RequestPersons.Where(x => x.Id == id).FirstOrDefault();

                    context.Entry(z).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();

                
                
                
                }

            }
            catch (Exception)
            {

                throw;
            }

           
        }

    }
}
