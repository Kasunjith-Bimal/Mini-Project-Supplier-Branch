using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RequestEditLogic
    {
        ReqestEditData db = new ReqestEditData();
        public List<RequestDTO> Getdata()
        {
            List<RequestDTO> list = new List<RequestDTO>();
            try
            {
                list = db.GetdataDb();
            }
            catch (Exception ex)
            {
                
                throw;
            }



            return list;
        }


        public List<RequestDTO> Search(String search)
        {
            List<RequestDTO> list = new List<RequestDTO>();
            try
            {
                list = db.SearchDb(search);
            }
            catch (Exception ex)
            {

                throw;
            }



            return list;
        }


        public void Edit(RequestDTO obj)
        {
            try
            {
                db.EditDb(obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }


        public void DeleteRequest(int id)
        {

            try
            {
                db.DeleteRequest(id);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

    }
}
