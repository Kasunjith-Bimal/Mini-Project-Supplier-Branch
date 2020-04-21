using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RequestItemLogic
    {
        RequestItemData req = new RequestItemData();
        public List<string> GetSource()
        {
            List<string> lists = new List<string>();

            try
            {
                lists = req.GetSource();
            }
            catch (Exception ex)
            {

                throw;
            }
            return lists;
        }
        public int getCategoryid(string cname)
        {
            int id;
            try
            {
                id = req.getCategoryId(cname);
            }
            catch (Exception ex)
            {

                throw;
            }
            return id;
        }
        public int GetReqId()
        {
            int reqid;
            try
            {
                reqid = req.GetReqId();
            }
            catch (Exception ex)
            {
                throw;
            }
            return reqid;
        }
        public void AddRequestItem(RequestItemDTO obj)
        {
            try
            {
                req.AddRequestItemdb(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<RequestItemDTO> ShowGrid(int reqid)
        {
            try
            {
                return req.ShowGrid(reqid);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void EditItem(RequestItemDTO obj)
        {
            try
            {
                req.EditItem(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteItem(int itemid)
        {
            try
            {
                req.DeleteItem(itemid);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<RequestItemDTO> Searchtextitem(String search,int id)
        {
            List<RequestItemDTO> Itemlist = new List<RequestItemDTO>();
            try
            {
                req.SearchtextItemdescription(search,id);
            }
            catch (Exception)
            {

                throw;
            }

            return Itemlist;
        }


        public List<RequestItemDTO> SearchtextCategory(String search,int id)
        {
            List<RequestItemDTO> Itemlist = new List<RequestItemDTO>();
            try
            {
               Itemlist =  req.SearchtextCategoryDb(search,id);
            }
            catch (Exception)
            {

                throw;
            }

            return Itemlist;
        }
    }
}
