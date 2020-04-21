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
    }
}
