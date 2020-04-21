using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class RequestPaperAdvertistmentData
    {

        public void AddDataDb(PaperAdvertismentDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    RequestPaperAdd paper = new RequestPaperAdd();

                    paper.Cname = obj.Categoryname;
                    paper.Heading = obj.Heading;
                    paper.MadeDate = obj.MadeDate;
                    paper.PaymentStatus = obj.PaymentStatus;
                    paper.RegistrationEndDate = obj.RegistrationEndDate;
                    paper.RegistrationEndTime = obj.RegistrationEndTime;
                    paper.RegistrationStartDate = obj.RegistrationStartDate;
                    paper.RegistrationStartTime = obj.RegistrationStartTime;
                    paper.ShouldResponseDate = obj.ShouldResponseDate;
                    paper.TenderName = obj.Tendername;
                    paper.TenderNo = obj.TenderNo;

                    context.RequestPaperAdds.Add(paper);
                    context.SaveChanges();


                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public List<PaperAdvertismentDTO> getDataGrid()
        {
            List<PaperAdvertismentDTO> relist = new List<PaperAdvertismentDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<RequestPaperAdd> data = (from recode in context.RequestPaperAdds select recode).ToList();

                    foreach (var item in data)
                    {
                        PaperAdvertismentDTO obj = new PaperAdvertismentDTO();

                        obj.Categoryname = item.Cname;
                        obj.Heading = item.Heading;
                        obj.MadeDate = item.MadeDate;
                        obj.Paperid = item.Paperid;
                        obj.PaymentStatus = item.PaymentStatus;
                        obj.RegistrationEndDate = item.RegistrationEndDate;
                        obj.RegistrationEndTime = item.RegistrationEndTime;
                        obj.RegistrationStartDate = item.RegistrationStartDate;
                        obj.RegistrationStartTime = item.RegistrationStartTime;
                        obj.ShouldResponseDate = item.ShouldResponseDate;
                        obj.Tendername = item.TenderName;
                        obj.TenderNo = item.TenderNo;


                        relist.Add(obj);


                    }


                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return relist;
        }


        public List<String> GetCategoryNameListDb()
        {
            List<String> categorynamelist = new List<String>();
            try
            {

                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    categorynamelist = (from recode in context.ReqCategories select recode.CategoryName).ToList();
                
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return categorynamelist;
        }

        public String GetCategoryName(int cid)
        {
            String CategoryName;
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    CategoryName = (from recode in context.ReqCategories where recode.Cid == cid select recode.CategoryName).FirstOrDefault();

                }

            }
            catch (Exception ex)
            {

                throw;
            }

            return CategoryName;
        }

        public void Editdb(PaperAdvertismentDTO obj)
        {


            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    RequestPaperAdd editpaperadd = (from recode in context.RequestPaperAdds where recode.Paperid == obj.Paperid select recode).FirstOrDefault();

                    editpaperadd.Heading = obj.Heading;
                    editpaperadd.Cname = obj.Categoryname;
                    editpaperadd.MadeDate = obj.MadeDate;
                    editpaperadd.PaymentStatus = obj.PaymentStatus;
                    editpaperadd.RegistrationEndDate = obj.RegistrationEndDate;
                    editpaperadd.RegistrationEndTime = obj.RegistrationEndTime;
                    editpaperadd.RegistrationStartDate = obj.RegistrationStartDate;
                    editpaperadd.RegistrationStartTime = obj.RegistrationStartTime;
                    editpaperadd.ShouldResponseDate = obj.ShouldResponseDate;
                    editpaperadd.TenderName = obj.Tendername;
                    editpaperadd.TenderNo = obj.TenderNo;


                    context.Entry(editpaperadd).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void deletedb(int id)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    RequestPaperAdd obj = (from recode in context.RequestPaperAdds where recode.Paperid == id select recode).FirstOrDefault();

                    context.RequestPaperAdds.Remove(obj);
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
