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
    }
}
