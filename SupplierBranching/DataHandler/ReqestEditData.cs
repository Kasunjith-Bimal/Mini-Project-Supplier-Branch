using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class ReqestEditData
    {

        public List<RequestDTO> GetdataDb()
        {
            List<RequestDTO> list = new List<RequestDTO>();
            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    var request = (from recode in context.Requests select recode).ToList();

                    foreach (var item in request)
                    {
                        RequestDTO obj = new RequestDTO();

                        obj.department = item.Department;
                        obj.idencode = item.IdentificationCode;
                        obj.reqdate = Convert.ToDateTime(item.RequisitionDate);
                        obj.reqid = item.RequestId;
                        obj.reqpersion = item.RequestPerson;


                        list.Add(obj);
                        
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }



            return list;
        }



        public List<RequestDTO> SearchDb(String Search)
        {
            List<RequestDTO> list = new List<RequestDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<Request> request = context.Requests.Where(P => P.IdentificationCode.Contains(Search)).ToList();


                    foreach (var item in request)
                    {
                        RequestDTO obj = new RequestDTO();
                        
                        obj.department = item.Department;
                        obj.idencode = item.IdentificationCode;
                        obj.reqdate = Convert.ToDateTime(item.RequisitionDate);
                        obj.reqid = item.RequestId;
                        obj.reqpersion = item.RequestPerson;

                        list.Add(obj);

                    }
                
                
                
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }



            return list;
        }

        public void EditDb(RequestDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    Request request = (from recode in context.Requests where recode.RequestId == obj.reqid select recode).FirstOrDefault();


                    request.Department = obj.department;
                    request.IdentificationCode = obj.idencode;
                    request.RequestPerson = obj.reqpersion;
                    request.RequisitionDate = obj.reqdate;


                    context.Entry(request).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

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
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    List<RequestItemDTO> list = new List<RequestItemDTO>();

                    List<RequestItem> requestid = (from recode in context.RequestItems where recode.reqid == id select recode).ToList();
                    Request req = (from recode in context.Requests where recode.RequestId == id select recode).FirstOrDefault();

                    context.Entry(req).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                            
                    foreach (var item in requestid)
                    {


                        context.RequestItems.Remove(item);
                        context.SaveChanges();
                    }
                  
                   
                  

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
