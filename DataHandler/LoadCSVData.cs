using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class LoadCSVData
    {
        public void AddtoPro(List<ProcurementItemDTO> list)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    foreach (var item in list)
                    {
                        ProcumentPlan pro = new ProcumentPlan();
                        pro.Remarks = item.Remarks;
                        pro.Sheduledate = item.ScheduleDate;
                        pro.PId = item.Pid;
                        pro.Qty = item.Qty;
                        pro.EstimatedUnitPrice = item.EstimatedUnitPrice;
                        pro.EstimatetedTotalPrice = item.EstimatetedTotalPrice;
                        pro.CurrentStatusofProcumentPreparednessActivities = item.CurrentStatusofProcument;
                        pro.LevelOfAuthority = item.LevelOfAuthority;
                        pro.IdentificationCode = item.IdentificationCode;
                        pro.Cid = item.Cid;
                        pro.ProcumentMethod = item.ProcumentMethod;
                        pro.SourceOfFunding = item.SourceOfFunding;
                        pro.PriorityStatus = item.PriorityStatus;
                        pro.ItemDescription = item.ItemDescription;
                        context.ProcumentPlans.Add(pro);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddtoProCategory(List<CategoryProcuremntDTO> list)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    foreach (var item in list)
                    {
                        CategoryTbl cat = new CategoryTbl();
                        cat.CategoryName = item.CategoryName;

                        context.CategoryTbls.Add(cat);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
