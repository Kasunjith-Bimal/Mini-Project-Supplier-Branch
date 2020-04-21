using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AddItemPaperAdvertismentLogic
    {
        AddItemPaperAdvertismentData db = new AddItemPaperAdvertismentData();
        public List<ProcurementItemDTO> SearchCategorilogic(string name)
        {
            List<ProcurementItemDTO> searchlist = new List<ProcurementItemDTO>();

            try
            {

                searchlist = db.SearchCategori(name);

            }
            catch (Exception ex)
            {
                throw;
            }

            return searchlist;
        }

        public int getPaperidlogic()
        {
            try
            {
                return db.getPaperidDb();
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
                db.Addpaperaddvertistement(Addlist);
            }
            catch (Exception ex)
            {
                throw;

            }


        }


    }
}
