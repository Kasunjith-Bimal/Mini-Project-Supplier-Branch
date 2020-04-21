using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class ProcurementLogic
    {
       ProcurementData prodata = new ProcurementData();
       public void ProcurementAdd(ProcurementDTO obj)
       {
           try
           {
               prodata.Procurementadddb(obj);
           }
           catch(Exception ex)
           {
               throw;
           }
               
       }
       public int GetProId()
       {
           int pid;
           try
           {
              pid = prodata.GetProId();
           }
           catch (Exception ex)
           {
               throw;
           }
           return pid;
       }
    }
}
