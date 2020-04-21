using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
   public  class RequestData
    {
        public void requestAdddb(RequestDTO obj)
       {
           try
           {
               using(SuppliesBranchEntities context = new SuppliesBranchEntities())
               {
                   Request req = new Request();
                   req.IdentificationCode = obj.idencode;
                   req.Department = obj.department;
                   req.RequisitionDate = obj.reqdate;
                   req.RequestPerson = obj.reqpersion;
                   context.Requests.Add(req);
                   context.SaveChanges();
               }
           }
           catch (Exception ex)
           {
               
               throw;
           }
       }
    }
}
