using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LoginLogic
    {

        LoginData db = new LoginData();
        public bool Selectpassword(RegisterPersonDTO obj)
        {
            bool isSaved = false;
            try
            {
               isSaved =db.SelectpasswordDb(obj);
                
            }
            catch (Exception ex)
            {

                throw;
            }
            return isSaved;
        }
    }
}
