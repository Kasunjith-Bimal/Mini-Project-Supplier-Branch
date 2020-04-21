using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class AddItemPaperAdvertismentData
    {

        public List<ProcurementItemDTO> SearchCategori(string name,int productid)
        {
            List<ProcurementItemDTO> searchlist = new List<ProcurementItemDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                   
                    int cid = (from recodes in context.CategoryTbls where recodes.CategoryName == name select recodes.Cid).FirstOrDefault();
                    List<ProcumentPlan> procumentplan = (from record in context.ProcumentPlans where record.Cid == cid && record.PId==productid select record).ToList();
                    foreach (ProcumentPlan item in procumentplan)
                    {
                        ProcurementItemDTO obj = new ProcurementItemDTO();

                        obj.Serialno = item.SerialNo;
                        obj.ItemDescription = item.ItemDescription;
                        obj.Qty = item.Qty;
                        obj.Pid = productid;
                        obj.Cid = cid;
                        
                       
                        searchlist.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return searchlist;
        }

        public int getPaperidDb()
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    int x = (from recode in context.PaperAdds select recode.Paperid).Max();

                    return x;
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }

        public void Addpaperaddvertistement(List<AddItemPaperAdvertismentDTO> Addlist)
        {
            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    foreach (var item in Addlist)
                    {

                        int pid = item.pid;
                        int cid = item.cid;
                        int paperid = item.paperid;
                        string itemdescription = item.itemDescription;
                        decimal Quantity = item.quantity;



                      

                        PaperAddItem add = new PaperAddItem();

                        add.Cid = cid;
                        add.PaperId = paperid;
                        add.Pid = pid;
                        add.Item = itemdescription;
                        add.Qty = Quantity;

                        context.PaperAddItems.Add(add);
                        context.SaveChanges();

                       
                        

                       
                    }
                    
                   



                }

            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public List<DateTime> ProcumentDate()
        {
            List<DateTime> ListPro = new List<DateTime>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    ListPro = context.ProcumentdTbls.OrderByDescending(x => x.Date).Select(x => x.Date).ToList();



                }



            }
            catch (Exception ex)
            {
                
                throw;
            }
            return ListPro;
        }


        public int getproductId(DateTime date)
        {
            int productid;

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    productid = (from recode in context.ProcumentdTbls where recode.Date == date select recode.PID).FirstOrDefault();
                
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }

            return productid;

        }


        public List<ProcurementItemDTO> GetListItem(int procumentid)
        {
            List<ProcurementItemDTO> listpro = new List<ProcurementItemDTO>();
            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<ProcumentPlan> pro = (from recode in context.ProcumentPlans where recode.PId == procumentid select recode).ToList();

                    foreach (var item in pro)
                    {
                        ProcurementItemDTO obj = new ProcurementItemDTO();

                        obj.Cid = item.Cid??0;
                        obj.Serialno = item.SerialNo;
                        obj.ItemDescription = item.ItemDescription;
                        obj.Qty = item.Qty;
                        obj.Pid = procumentid;

                        listpro.Add(obj);

                       
                    }
                   
                }

            }
            catch (Exception)
            {
                
                throw;
            }




            return listpro;
           
        }

    }
}
