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

    }
}
