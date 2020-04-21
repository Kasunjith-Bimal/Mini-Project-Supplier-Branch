using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RequestItemDTO
    {
        public int itemid { get; set; }
        public int reqcid { get; set; }
        public string requestcategory { get; set; }
        public int? reqid { get; set; }
        public string itemdes { get; set; }
        public string itemspeci { get; set; }
        public decimal? quantity { get; set; }
        public decimal? estimateprice { get; set; }
        public string itemphoto { get; set; }
    }
}
