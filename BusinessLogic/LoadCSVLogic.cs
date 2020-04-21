using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class LoadCSVLogic
    {
        LoadCSVData csv = new LoadCSVData();
        public void AddtoPro(List<ProcurementItemDTO> list)
        {
            csv.AddtoPro(list);
        }
        public void AddtoProCategory(List<CategoryProcuremntDTO> list)
        {
            csv.AddtoProCategory(list);
        }
    }
}
