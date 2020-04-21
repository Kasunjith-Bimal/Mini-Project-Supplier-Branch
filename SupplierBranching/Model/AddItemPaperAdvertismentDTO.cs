using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class AddItemPaperAdvertismentDTO
    {

        public int id { get; set; }
        public int cid { get; set; }
        public int paperid { get; set; }
        public int pid { get; set; }
        public string itemDescription { get; set; }
        public decimal quantity{ get; set; }
     }
}
