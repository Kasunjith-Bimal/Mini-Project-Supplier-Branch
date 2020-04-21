using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ProcurementItemDTO
    {
        public int Serialno { get; set; }
        public int Pid { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int Cid { get; set; }
        public string Remarks { get; set; }
        public decimal Qty { get; set; }
        public decimal EstimatedUnitPrice { get; set; }
        public decimal EstimatetedTotalPrice { get; set; }
        public string CurrentStatusofProcument { get; set; }
        public string LevelOfAuthority { get; set; }
        public string IdentificationCode { get; set; }
        public string ProcumentMethod { get; set; }
        public string SourceOfFunding { get; set; }
        public string PriorityStatus { get; set; }
        public string ItemDescription { get; set; }
    }
}
