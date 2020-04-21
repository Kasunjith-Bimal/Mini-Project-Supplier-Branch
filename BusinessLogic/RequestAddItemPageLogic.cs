using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RequestAddItemPageLogic
    {


        RequestAddItemPageData db = new RequestAddItemPageData();


       

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
        public List<DateTime> GetReqestDate()
        {
            List<DateTime> ReqestDate = new List<DateTime>();
            try
            {

                ReqestDate = db.GetReqestDatedb();

            }
            catch (Exception)
            {

                throw;
            }

            return ReqestDate;

        }

        public List<RequestItemDTO> GetListItem(int procumentid)
        {
            List<RequestItemDTO> list = new List<RequestItemDTO>();

            try
            {
                list = db.GetListItem(procumentid);
            }
            catch (Exception)
            {

                throw;
            }

            return list;

        }
        public List<RequestItemDTO> SearchCategori(string name, int Reqestid)
        {
            List<RequestItemDTO> searchlist = new List<RequestItemDTO>();
            try
            {
                searchlist = db.SearchCategori(name, Reqestid);
            }
            catch (Exception)
            {

                throw;
            }

            return searchlist;
        }

        public int getreqestId(DateTime date)
        {
            int Requestid;

            try
            {
                Requestid = db.getReqestid(date);
            }
            catch (Exception ex)
            {

                throw;
            }

            return Requestid;

        }
    }
}
