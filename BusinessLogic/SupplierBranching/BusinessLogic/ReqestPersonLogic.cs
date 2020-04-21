using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ReqestPersonLogic
    {
        ReqestPersonData db = new ReqestPersonData();

        public void addSection(RegisterPersonDTO obj)
        {
            try
            {

                db.addSectionDb(obj);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<string> getidentificationCode()
        {
            List<string> getlist = new List<string>();
            try
            {
                getlist= db.identificationCode();
            }
            catch (Exception ex)
            {
                throw;
            }
            return getlist;
        }


    }
}
