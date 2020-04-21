using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class PaperAdvertismentData
    {
        public void AddDataDb(PaperAdvertismentDTO obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    PaperAdd paper = new PaperAdd();

                    paper.Cid = obj.Cid;
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

                    context.PaperAdds.Add(paper);
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

                    List<PaperAdd> data = (from recode in context.PaperAdds select recode).ToList();

                    foreach (var item in data)
                    {
                        PaperAdvertismentDTO obj = new PaperAdvertismentDTO();

                        obj.Cid = item.Cid;
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


        public String GetCategoryName(int cid)
        {
            String CategoryName;
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    CategoryName = (from recode in context.CategoryTbls where recode.Cid == cid select recode.CategoryName).FirstOrDefault();
                
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

                    PaperAdd editpaperadd = (from recode in context.PaperAdds where recode.Paperid == obj.Paperid select recode).FirstOrDefault();

                    editpaperadd.Heading = obj.Heading;
                    editpaperadd.Cid = obj.Cid;
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

                   PaperAdd obj = (from recode in context.PaperAdds where recode.Paperid ==id select recode).FirstOrDefault();

                   context.PaperAdds.Remove(obj);
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
