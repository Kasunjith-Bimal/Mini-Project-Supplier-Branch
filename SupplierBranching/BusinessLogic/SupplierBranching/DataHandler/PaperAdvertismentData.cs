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


    }
}
