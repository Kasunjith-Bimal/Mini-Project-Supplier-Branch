using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
   public class ProcurementData
    {
   public void Procurementadddb(ProcurementDTO obj)
       {
           try
           {
               using(SuppliesBranchEntities context = new SuppliesBranchEntities())
               {
                   ProcumentdTbl pro = new ProcumentdTbl();
                   pro.Date = obj.Prodate;
                   context.ProcumentdTbls.Add(pro);
                   context.SaveChanges();
               }
           }
           catch (Exception ex)
           {
               
               throw;
           }
       }
   public int GetProId()
   {
       int proid;
       try
       {
           using (SuppliesBranchEntities context = new SuppliesBranchEntities())
           {
               proid = (from record in context.ProcumentdTbls select record.PID).Max();
           }
       }
       catch (Exception ex)
       {

           throw;
       }
       return proid;
   }
    }
}
