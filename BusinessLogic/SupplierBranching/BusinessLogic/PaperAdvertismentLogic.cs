using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PaperAdvertismentLogic
    {
        PaperAdvertismentData db = new PaperAdvertismentData();

        public void AddData(PaperAdvertismentDTO obj)
        {
            try
            {
                db.AddDataDb(obj);
            }
            catch (Exception ex)
            {
                throw;

            }

        }
    }
}
