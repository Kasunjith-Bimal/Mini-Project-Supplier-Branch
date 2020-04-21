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
        public List<CategoryProcuremntDTO> ShowGrid()
        {
            List<CategoryProcuremntDTO> li1 = new List<CategoryProcuremntDTO>();
            List<CategoryTbl> li2 = new List<CategoryTbl>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    li2 = (from record in context.CategoryTbls select record).ToList();
                }
                foreach (var item in li2)
                {
                    CategoryProcuremntDTO obj = new CategoryProcuremntDTO();
                    obj.Cid = item.Cid;
                    obj.CategoryName = item.CategoryName;
                    li1.Add(obj);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return li1;
        }
        public List<CategoryProcuremntDTO> Search(string search)
        {
            List<CategoryProcuremntDTO> li1 = new List<CategoryProcuremntDTO>();
            
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                 List<CategoryTbl> li2 = (from record in context.CategoryTbls where (record.CategoryName.Contains(search)) select record).ToList();
                foreach (var item in li2)
                {
                    CategoryProcuremntDTO obj = new CategoryProcuremntDTO();
                    obj.Cid = item.Cid;
                    obj.CategoryName = item.CategoryName;
                    li1.Add(obj);
                }
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
            return li1;
        }
        public void EditCategory(int id,string cname)
        {
           

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    CategoryTbl obj = (from record in context.CategoryTbls where (record.Cid == id) select record).FirstOrDefault();
                    obj.CategoryName = cname;
                    context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        public void DeleteCategory(int id)
        {
            

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    CategoryTbl obj = (from record in context.CategoryTbls where (record.Cid == id) select record).FirstOrDefault();
                    context.CategoryTbls.Remove(obj);
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
