using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class LoginData
    {

        public bool SelectpasswordDb(RegisterPersonDTO obj)
        {
            bool isSaved = false;

            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    if (context.RequestPersons.Any(s => s.Password == obj.Password && s.Username == obj.UserName))
                    {
                        isSaved = true;

                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return isSaved;
        }
    }
}
