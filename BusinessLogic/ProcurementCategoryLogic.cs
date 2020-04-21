using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProcurementCategoryLogic
    {
        ProcurementCategoryData cdata = new ProcurementCategoryData();
        public void AddProCategory(CategoryProcuremntDTO obj)
        {
            try
            {
                cdata.AddProCategory(obj);
            }
            catch (Exception ex)
            {
                
                
            }
        }
        public int getCategoryid(string cname)
        {
            int id;
            try
            {
                id = cdata.getCategoryId(cname);
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return id;
        }
        public List<CategoryProcuremntDTO> ShowGrid()
        {
            List<CategoryProcuremntDTO> li = new List<CategoryProcuremntDTO>();
            try
            {
                li = cdata.ShowGrid();
            }
            catch (Exception ex)
            {

                throw;
            }
            return li;
        }
        public List<CategoryProcuremntDTO> Search(string search)
        {
            List<CategoryProcuremntDTO> li = new List<CategoryProcuremntDTO>();
            try
            {
                li = cdata.Search(search);
            }
            catch (Exception ex)
            {

                throw;
            }
            return li;
        }
        public void EditCategory(int id, string cname)
        {
            
            try
            {
                cdata.EditCategory(id,cname);
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
                cdata.DeleteCategory(id);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
