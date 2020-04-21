using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class RequestCategoryData
    {
        public void reqCategoryAdd(RequestCategoryDTO obj)
        {
            try
            {
                using(SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    ReqCategory req = new ReqCategory();
                    req.CategoryName = obj.categoryname;
                    context.ReqCategories.Add(req);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }


        public List<RequestCategoryDTO> GetlistDb()
        {
            List<RequestCategoryDTO> list = new List<RequestCategoryDTO>();

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                  


                   List<ReqCategory> category = (from recode in context.ReqCategories select recode).ToList();


                   foreach (var item in category)
                   {
                       RequestCategoryDTO obj = new RequestCategoryDTO();


                       obj.categoryname = item.CategoryName;
                       obj.reqcid = item.Cid;

                     list.Add(obj);
                   }
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return list;
        }


        public List<RequestCategoryDTO> Searchtextdb(String search)
        {
            List<RequestCategoryDTO> list = new List<RequestCategoryDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {



                    List<ReqCategory> reqcategory = context.ReqCategories.Where(P => P.CategoryName.Contains(search)).ToList();


                    foreach (var item in reqcategory)
                    {
                        RequestCategoryDTO obj = new RequestCategoryDTO();

                        obj.reqcid = item.Cid;
                        obj.categoryname = item.CategoryName;
                        

                        list.Add(obj);

                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return list;

        }


        public void editdatadb(RequestCategoryDTO obj)
        {

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    ReqCategory category = (from recode in context.ReqCategories where recode.Cid == obj.reqcid select recode).FirstOrDefault();

                    category.CategoryName = obj.categoryname;

                    context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void deleteCategorydb(int id)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    ReqCategory delcategory = (from recode in context.ReqCategories where recode.Cid == id select recode).FirstOrDefault();

                    context.Entry(delcategory).State = System.Data.Entity.EntityState.Deleted;
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
