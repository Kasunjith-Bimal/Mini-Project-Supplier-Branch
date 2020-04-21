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
    }
}
