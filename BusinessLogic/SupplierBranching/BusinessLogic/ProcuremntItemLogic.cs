using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProcuremntItemLogic
    {
        ProcurementItem proitem = new ProcurementItem();
        public List<string> GetSource()
        {
            List<string> lists = new List<string>();
            
            try
            {
                lists = proitem.GetSource();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return lists;
        }
        public void ProcuremntItemAdd(ProcurementItemDTO obj)
        {
            try
            {
                proitem.ProcurementItemAdd(obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
        public List<string> GetSourceIden()
        {
            List<string> lists = new List<string>();

            try
            {
                lists = proitem.GetSourceIden();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lists;
        }
    }
}
