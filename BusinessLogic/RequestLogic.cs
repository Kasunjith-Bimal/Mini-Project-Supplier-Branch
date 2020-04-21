using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RequestLogic
    {
        RequestData reqdata = new RequestData();
        public void requestAdd(RequestDTO obj)
        {
            try
            {
                reqdata.requestAdddb(obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
