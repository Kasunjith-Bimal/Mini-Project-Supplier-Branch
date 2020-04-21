using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class RequestAddItemPageData
    {

      
        public int getPaperidDb()
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    int x = (from recode in context.RequestPaperAdds select recode.Paperid).Max();

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

                        int Rid = item.pid;
                        int cid = item.cid;
                        int paperid = item.paperid;
                        string itemdescription = item.itemDescription;
                        decimal Quantity = item.quantity;





                        ReqestPaperAdditem add = new ReqestPaperAdditem();

                        add.Cid = cid;
                        add.PaperId = paperid;
                        add.Rid = Rid;
                        add.Item = itemdescription;
                        add.Qty = Quantity;

                        context.ReqestPaperAdditems.Add(add);
                        context.SaveChanges();





                    }





                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<RequestItemDTO> GetListItem(int Reqestid)
        {
            List<RequestItemDTO> listpro = new List<RequestItemDTO>();
            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<RequestItem> pro = (from recode in context.RequestItems where recode.reqid == Reqestid select recode).ToList();

                    foreach (var item in pro)
                    {
                        RequestItemDTO obj = new RequestItemDTO();

                        obj.itemdes = item.Itemdescription;
                        obj.estimateprice = item.EstimatePrice;
                        obj.quantity = item.Quantity;
                        obj.reqid = item.reqid;
                        obj.reqcid = item.reqcid??0;

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

        public List<RequestItemDTO> SearchCategori(string name, int Reqestid)
        {
            List<RequestItemDTO> searchlist = new List<RequestItemDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    int cid = (from recodes in context.ReqCategories where recodes.CategoryName == name select recodes.Cid).FirstOrDefault();
                    List<RequestItem> Reqestitem = (from record in context.RequestItems where record.reqcid == cid && record.reqid == Reqestid select record).ToList();
                    foreach (RequestItem item in Reqestitem)
                    {
                        RequestItemDTO obj = new RequestItemDTO();

                       
                        obj.itemdes = item.Itemdescription;
                        obj.itemid = item.Itemid;
                        obj.estimateprice = item.EstimatePrice;
                        obj.quantity = item.Quantity;
                        obj.reqcid = item.reqcid??0;
                        obj.reqid = item.reqid;
                        

                        searchlist.Add(obj);
                    }
                }
            }
            catch (Exception)
            {

            }
            return searchlist;
        }

        public List<DateTime> GetReqestDatedb()
        {
            List<DateTime> ReqestDatedb = new List<DateTime>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    ReqestDatedb = context.Requests.OrderByDescending(x => x.RequestId).Select(x => x.RequisitionDate).ToList();
                
                }

            }
            catch (Exception)
            {

                throw;
            }

            return ReqestDatedb;

        }


        public int getReqestid(DateTime date)
        {
            int Requestid;

            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    Requestid = (from recode in context.Requests where recode.RequisitionDate == date select recode.RequestId).FirstOrDefault(); ;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return Requestid;

        }
    }
}
