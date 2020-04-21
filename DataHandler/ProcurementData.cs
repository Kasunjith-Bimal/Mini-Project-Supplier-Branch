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
   public List<ProcurementDTO> ProGridShow()
   {
       List<ProcurementDTO> list = new List<ProcurementDTO>();
       List<ProcumentdTbl> prolist = new List<ProcumentdTbl>();
       try
       {
           using (SuppliesBranchEntities context = new SuppliesBranchEntities())
           {
               prolist = (from r in context.ProcumentdTbls select r).ToList();
           }
           foreach (var item in prolist)
           {
               ProcurementDTO obj = new ProcurementDTO();
               obj.PID = item.PID;
               obj.Prodate = item.Date;
               list.Add(obj);
           }
       }
       catch (Exception ex)
       {

           throw;
       }
       return list;
   }
   public void ProGridDelete(int pid)
   {
      
      
       try
       {
           using (SuppliesBranchEntities context = new SuppliesBranchEntities())
           {
               ProcumentdTbl prolist = (from r in context.ProcumentdTbls where(r.PID == pid) select r).FirstOrDefault();
               context.ProcumentdTbls.Remove(prolist);
               context.SaveChanges();
           }
       }
       catch (Exception ex)
       {

           throw;
       }
   }
    }
}
