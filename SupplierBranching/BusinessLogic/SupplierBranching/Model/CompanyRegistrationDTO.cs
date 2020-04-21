using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CompanyRegistrationDTO
    {

        public int id { get; set; }
        public int Paperid { get; set; }
        public string CompanyName  { get; set; }
        public string CompanyRegistrationNo { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
