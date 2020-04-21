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
        public List<RequestItemDTO> ShowGrid(int reqid)
        {
            List<RequestItemDTO> list = new List<RequestItemDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    list = (from r1 in context.RequestItems
                            join r2 in context.ReqCategories on r1.reqcid equals r2.Cid
                            where r1.reqid == reqid
                            select new RequestItemDTO
                                {
                                    itemid = r1.Itemid,
                                    reqcid = r2.Cid,
                                    requestcategory = r2.CategoryName,
                                    reqid = r1.reqid,
                                    itemdes = r1.Itemdescription,
                                    itemspeci = r1.ItemSpecification,
                                    itemphoto = r1.ItemPhoto,
                                    quantity = r1.Quantity,
                                    estimateprice = r1.EstimatePrice

                                }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        public void EditItem(RequestItemDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    RequestItem req = (from r in context.RequestItems where obj.itemid == r.Itemid select r).FirstOrDefault();
                    req.reqcid = obj.reqcid;
                    req.reqid = obj.reqid;
                    req.Quantity = obj.quantity;
                    req.Itemdescription = obj.itemdes;
                    req.EstimatePrice = obj.estimateprice;
                    req.ItemPhoto = obj.itemphoto;
                    req.ItemSpecification = obj.itemspeci;
                    context.Entry(req).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteItem(int itemid)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    RequestItem req = (from r in context.RequestItems where r.Itemid == itemid select r).FirstOrDefault();

                    context.RequestItems.Remove(req);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<RequestItemDTO> SearchtextItemdescription(String search,int id)
        {
            List<RequestItemDTO> Itemlist = new List<RequestItemDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<RequestItem> reqestlist = (context.RequestItems.Where(p => p.Itemdescription.Contains(search) && (p.reqid==id))).ToList();

                    foreach (var item in reqestlist)
                    {
                        RequestItemDTO obj = new RequestItemDTO();


                        obj.estimateprice = item.EstimatePrice;
                        obj.itemdes = item.Itemdescription;
                        obj.itemid = item.Itemid;
                        obj.itemphoto = item.ItemPhoto;
                        obj.itemspeci = item.ItemSpecification;
                        obj.quantity = item.Quantity;
                        obj.reqcid = item.reqcid??0;
                        obj.reqid = item.reqid;

                        Itemlist.Add(obj);
                    }
                
                
                }

            }
            catch (Exception)
            {

                throw;
            }

            return Itemlist;
        }

        public List<RequestItemDTO> SearchtextCategoryDb(String search,int id)
        {
            List<RequestItemDTO> Itemlist = new List<RequestItemDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                   Itemlist= (from r1 in context.RequestItems
                            join r2 in context.ReqCategories on r1.reqcid equals r2.Cid
                            where (r1.reqid == id && r2.CategoryName.Contains(search))
                            select new RequestItemDTO
                            {
                                itemid = r1.Itemid,
                                reqcid = r2.Cid,
                                requestcategory = r2.CategoryName,
                                reqid = r1.reqid,
                                itemdes = r1.Itemdescription,
                                itemspeci = r1.ItemSpecification,
                                itemphoto = r1.ItemPhoto,
                                quantity = r1.Quantity,
                                estimateprice = r1.EstimatePrice

                            }).ToList();



                }

            }
            catch (Exception)
            {

                throw;
            }

            return Itemlist;
        }

    }
}
