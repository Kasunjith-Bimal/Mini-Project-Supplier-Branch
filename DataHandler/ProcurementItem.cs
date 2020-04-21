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
        public List<ProcurementItemDTO> ShowGrid(int pid)
        {
           List<ProcurementItemDTO> lst = new List<ProcurementItemDTO>();
            
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                  lst = (from r1 in context.ProcumentPlans join r2 in context.CategoryTbls on r1.Cid equals r2.Cid where pid == r1.PId select new ProcurementItemDTO
                      {
                      Pid = r1.PId,
                     CategoryName = r2.CategoryName,
                     Cid = r2.Cid,
                     Serialno = r1.SerialNo,
                       ScheduleDate = r1.Sheduledate,
                       Remarks = r1.Remarks,
                       Qty = r1.Qty,
                       EstimatedUnitPrice = r1.EstimatedUnitPrice,
                       EstimatetedTotalPrice = r1.EstimatetedTotalPrice,
                       CurrentStatusofProcument = r1.CurrentStatusofProcumentPreparednessActivities,
                       LevelOfAuthority = r1.LevelOfAuthority,
                       IdentificationCode = r1.IdentificationCode,
                       ProcumentMethod = r1.ProcumentMethod,
                       SourceOfFunding = r1.SourceOfFunding,
                       PriorityStatus = r1.PriorityStatus,
                       ItemDescription = r1.ItemDescription
                      }
                      ).ToList();
                }
                
            }
            catch (Exception ex)
            {

            }
            return lst;
        }
        public void EditItem(ProcurementItemDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    ProcumentPlan item = (from r in context.ProcumentPlans where obj.Serialno == r.SerialNo select r).FirstOrDefault();
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
                    context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void DeleteItem(int serialno)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    ProcumentPlan item = (from r in context.ProcumentPlans where serialno == r.SerialNo select r).FirstOrDefault();

                    context.ProcumentPlans.Remove(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<ProcurementItemDTO> SearchItem(int index,string text,int pid)
        {
            List<ProcurementItemDTO> lst = new List<ProcurementItemDTO>();

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    if (index == 0)
                    {
                        lst = (from r1 in context.ProcumentPlans
                               join r2 in context.CategoryTbls on r1.Cid equals r2.Cid
                               where ((r1.PId== pid) && r2.CategoryName.Contains(text))
                               select new ProcurementItemDTO
                               {
                                   Pid = r1.PId,
                                   CategoryName = r2.CategoryName,
                                   Cid = r2.Cid,
                                   Serialno = r1.SerialNo,
                                   ScheduleDate = r1.Sheduledate,
                                   Remarks = r1.Remarks,
                                   Qty = r1.Qty,
                                   EstimatedUnitPrice = r1.EstimatedUnitPrice,
                                   EstimatetedTotalPrice = r1.EstimatetedTotalPrice,
                                   CurrentStatusofProcument = r1.CurrentStatusofProcumentPreparednessActivities,
                                   LevelOfAuthority = r1.LevelOfAuthority,
                                   IdentificationCode = r1.IdentificationCode,
                                   ProcumentMethod = r1.ProcumentMethod,
                                   SourceOfFunding = r1.SourceOfFunding,
                                   PriorityStatus = r1.PriorityStatus,
                                   ItemDescription = r1.ItemDescription
                               }
                            ).ToList();
                    }
                    else if(index==1)
                    {
                        lst = (from r1 in context.ProcumentPlans
                               join r2 in context.CategoryTbls on r1.Cid equals r2.Cid
                               where ((r1.PId == pid) && r1.ItemDescription.Contains(text))
                               select new ProcurementItemDTO
                               {
                                   Pid = r1.PId,
                                   CategoryName = r2.CategoryName,
                                   Cid = r2.Cid,
                                   Serialno = r1.SerialNo,
                                   ScheduleDate = r1.Sheduledate,
                                   Remarks = r1.Remarks,
                                   Qty = r1.Qty,
                                   EstimatedUnitPrice = r1.EstimatedUnitPrice,
                                   EstimatetedTotalPrice = r1.EstimatetedTotalPrice,
                                   CurrentStatusofProcument = r1.CurrentStatusofProcumentPreparednessActivities,
                                   LevelOfAuthority = r1.LevelOfAuthority,
                                   IdentificationCode = r1.IdentificationCode,
                                   ProcumentMethod = r1.ProcumentMethod,
                                   SourceOfFunding = r1.SourceOfFunding,
                                   PriorityStatus = r1.PriorityStatus,
                                   ItemDescription = r1.ItemDescription
                               }
                           ).ToList();
                    }
                }

            }
            catch (Exception ex)
            {

            }
            return lst;
        }
        public void DeleteProItem(int id)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    List<ProcumentPlan> list = (from r in context.ProcumentPlans where id == r.PId select r).ToList();
                    foreach (var item in list)
	{
                    context.ProcumentPlans.Remove(item);
                    context.SaveChanges();
	}
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
