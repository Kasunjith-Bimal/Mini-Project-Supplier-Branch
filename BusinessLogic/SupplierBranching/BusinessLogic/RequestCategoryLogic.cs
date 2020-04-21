using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public  class RequestCategoryLogic
    {
       RequestCategoryData reqcat = new RequestCategoryData();
    public void requestCategoryAdd(RequestCategoryDTO obj)
       {
           try
           {
               reqcat.reqCategoryAdd(obj);
           }
           catch (Exception ex)
           {
               
               throw;
           }
       }
    }
}
