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


    public List<RequestCategoryDTO> Getlist()
    {
        List<RequestCategoryDTO> list = new List<RequestCategoryDTO>();

        try
        {
          list=reqcat.GetlistDb();

        }
        catch (Exception ex)
        {
            
            throw;
        }
        return list;
    }


    public List<RequestCategoryDTO> Searchtext(String search)
    {
        List<RequestCategoryDTO> list = new List<RequestCategoryDTO>();
        try
        {
            list = reqcat.Searchtextdb(search);
        }
        catch (Exception ex)
        {
            
            throw;
        }

        return list;

    }

    public void editdata(RequestCategoryDTO obj)
    {

        try
        {
            reqcat.editdatadb(obj);
        }
        catch (Exception ex)
        {
            
            throw;
        }
    }

    public void deleteCategory(int id)
    {
        try
        {
            reqcat.deleteCategorydb(id);
        }
        catch (Exception ex)
        {
            
            throw;
        }


    }
    }
}
