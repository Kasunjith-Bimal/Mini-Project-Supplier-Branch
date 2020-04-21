using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RequestDTO
    {
        public int reqid { get; set; }
        public string idencode { get; set; }
        public string department { get; set; }
        public DateTime reqdate { get; set; }
        public string reqpersion { get; set; }
    }
}