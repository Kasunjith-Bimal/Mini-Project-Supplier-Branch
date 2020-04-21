using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaperAdvertismentDTO
    {
        public String Categoryname { get; set; }
        public int Paperid { get; set; }
        public string Heading { get; set; }
        public string Tendername { get; set; }
        public string TenderNo { get; set; }
        public decimal PaymentStatus { get; set; }
        public DateTime ShouldResponseDate  { get; set; }
        public DateTime MadeDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public DateTime RegistrationStartDate { get; set; }
        public string RegistrationStartTime { get; set; }
        public string RegistrationEndTime { get; set; }
    }
}
