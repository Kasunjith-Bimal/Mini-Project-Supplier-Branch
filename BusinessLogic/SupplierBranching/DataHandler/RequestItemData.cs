using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class RequestItemData
    {
        public List<string> GetSource()
        {
            List<string> sourcelist = new List<string>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    sourcelist = (from record in context.ReqCategories select record.CategoryName).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return sourcelist;
        }
        public int getCategoryId(string cname)
        {
            int id;
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    id = (from record in context.ReqCategories where cname == record.CategoryName select record.Cid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return id;
        }
        public int GetReqId()
        {
            int reqid;
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    reqid = (from record in context.Requests select record.RequestId).Max();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return reqid;
        }
        public void AddRequestItemdb(RequestItemDTO obj)
        {
            try
            {
                 using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    RequestItem req = new RequestItem();
                    req.reqcid = obj.reqcid;
                    req.reqid = obj.reqid;
                    req.Quantity = obj.quantity;
                    req.Itemdescription = obj.itemdes;
                    req.EstimatePrice = obj.estimateprice;
                    req.ItemPhoto = obj.itemphoto;
                    req.ItemSpecification = obj.itemspeci;
                    context.RequestItems.Add(req);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
