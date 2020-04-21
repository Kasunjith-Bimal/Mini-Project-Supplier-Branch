using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class ProcurementCategoryData
    {
        public void AddProCategory(CategoryProcuremntDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    CategoryTbl cat = new CategoryTbl();
                    cat.CategoryName = obj.CategoryName;
                    context.CategoryTbls.Add(cat);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public int getCategoryId(string cname)
        {
            int id;
            try
            {
                using(SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    id = (from record in context.CategoryTbls where cname == record.CategoryName select record.Cid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return id;
        }
    }
}
