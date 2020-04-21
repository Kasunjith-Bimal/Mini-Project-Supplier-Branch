using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RegisterPersonDTO
    {
        public int id { get; set; }
        public string IdentificationCode { get; set; }
        public string Post { get; set; }
        public string RequestPersonName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    
    }
}
