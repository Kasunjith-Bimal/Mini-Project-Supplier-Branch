using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RequestPaperAdvertistmentLogic
    {

         RequestPaperAdvertistmentData db = new RequestPaperAdvertistmentData();

        public void AddData(PaperAdvertismentDTO obj)
        {
            try
            {
                db.AddDataDb(obj);
            }
            catch (Exception ex)
            {
                throw;

            }

        }


        public List<PaperAdvertismentDTO> getdatatogrid()
        {
            List<PaperAdvertismentDTO> Relist = new List<PaperAdvertismentDTO>();
            try
            {
                Relist = db.getDataGrid();
            }
            catch (Exception ex)
            {

                throw;
            }

            return Relist;
        }



        public String GetCategoryNamefromdata(int cid)
        {
            String CategoryName;
            try
            {
                CategoryName = db.GetCategoryName(cid);

            }
            catch (Exception ex)
            {

                throw;
            }

            return CategoryName;
        }



        public List<String> GetCategoryNameList()
        {
           List<String> categorynamelist =new List<String>();
            try
            {
                categorynamelist = db.GetCategoryNameListDb();

            }
            catch (Exception ex)
            {

                throw;
            }

            return categorynamelist;
        }
        public void Edit(PaperAdvertismentDTO obj)
        {
            try
            {
                db.Editdb(obj);
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void delete(int id)
        {
            try
            {

                db.deletedb(id);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
