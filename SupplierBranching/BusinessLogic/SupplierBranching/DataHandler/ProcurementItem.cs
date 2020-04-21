using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    
    public class ProcurementItem
    {
        public List<string> GetSource()
        {
            List<string> sourcelist = new List<string>();
            try
            {
                using(SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                   sourcelist = (from record in context.CategoryTbls select record.CategoryName).ToList(); 
                }

            }
            catch(Exception ex)
            {

            }
            return sourcelist;
        }
        public void ProcurementItemAdd(ProcurementItemDTO obj)
        {
            try
            {
                using(SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    ProcumentPlan item = new ProcumentPlan();
                    item.Cid = obj.Cid;
                    item.PId = obj.Pid;
                    item.Sheduledate = obj.ScheduleDate;
                    item.Remarks = obj.Remarks;
                    item.Qty = obj.Qty;
                    item.EstimatedUnitPrice = obj.EstimatedUnitPrice;
                    item.EstimatetedTotalPrice = obj.EstimatetedTotalPrice;
                    item.CurrentStatusofProcumentPreparednessActivities = obj.CurrentStatusofProcument;
                    item.LevelOfAuthority = obj.LevelOfAuthority;
                    item.IdentificationCode = obj.IdentificationCode;
                    item.ProcumentMethod = obj.ProcumentMethod;
                    item.SourceOfFunding = obj.SourceOfFunding;
                    item.PriorityStatus = obj.PriorityStatus;
                    item.ItemDescription = obj.ItemDescription;
                    context.ProcumentPlans.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
        public List<string> GetSourceIden()
        {
            List<string> sourcelist = new List<string>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    sourcelist = (from record in context.Sections select record.IdentificationCode).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return sourcelist;
        }
    }
}
