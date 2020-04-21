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
        public List<ProcurementItemDTO> SearchCategorilogic(string name, int id)
        {
            List<ProcurementItemDTO> searchlist = new List<ProcurementItemDTO>();

            try
            {

                searchlist = db.SearchCategori(name,id);

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


        public List<DateTime> ProcumentDatelogic()
        {
            List<DateTime> ListPro = new List<DateTime>();
            try
            {

                ListPro = db.ProcumentDate();





            }
            catch (Exception ex)
            {

                throw;
            }
            return ListPro;
        }

        public int getproductId(DateTime date)
        {
            int productid;

            try
            {
                productid = db.getproductId(date);
            }
            catch (Exception ex)
            {

                throw;
            }

            return productid;

        }
        public List<ProcurementItemDTO> GetListItem(int procumentid)
        {
            List<ProcurementItemDTO> list = new List<ProcurementItemDTO>();

            try
            {
             list =   db.GetListItem(procumentid);
            }
            catch (Exception)
            {
                
                throw;
            }

            return list;
        
        }
    }
}
