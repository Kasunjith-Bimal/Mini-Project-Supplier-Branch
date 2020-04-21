using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierBranching
{
    public partial class ProcurementItem : Form
    {
        ProcurementCategoryLogic procat = new ProcurementCategoryLogic();
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        ProcurementLogic plg = new ProcurementLogic();
        public ProcurementItem()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ProItemAdd();
        }
        public void AddProcuremntItem()
        {
            //txt_category.Text;
        }
        public void GetSource()
        {
            List<string> listnew= prolg.GetSource();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_category.AutoCompleteCustomSource = listn;
        }

        private void txt_category_TextChanged(object sender, EventArgs e)
        {
            GetSource();
        }

        private void txt_category_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        public void ProItemAdd()
        {
            try
            {
                string cname = txt_category.Text;
                int cid = procat.getCategoryid(cname);
                int pid = plg.GetProId();
                ProcurementItemDTO obj = new ProcurementItemDTO();
                obj.Cid = cid;
                obj.Pid = pid;
                obj.Qty = Convert.ToDecimal(txt_qty.Text);
                obj.EstimatedUnitPrice = Convert.ToDecimal(txt_estimateunitprice.Text);
                obj.EstimatetedTotalPrice = Convert.ToDecimal(obj.Qty * obj.EstimatedUnitPrice);
                obj.SourceOfFunding = txt_source.Text;
                obj.ProcumentMethod = txt_procurementmethod.Text;
                obj.LevelOfAuthority = txt_levelauthority.Text;
                obj.ProcumentMethod = txt_procurementmethod.Text;
                obj.PriorityStatus = txt_currentstatus.Text;
                obj.ScheduleDate = Convert.ToDateTime(dtp_completiondate.Text);
                obj.Remarks = txt_remarks.Text;
                obj.CurrentStatusofProcument = txt_currentstatus.Text;
                obj.ItemDescription = txt_itemdes.Text;
                obj.IdentificationCode = txt_idencode.Text;
                prolg.ProcuremntItemAdd(obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
        public void GetSourceofIdentcode()
        {
            List<string> listnew = prolg.GetSourceIden();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_idencode.AutoCompleteCustomSource = listn;
        }

        private void txt_idencode_TextChanged(object sender, EventArgs e)
        {
            GetSourceofIdentcode();
        }
    }
}
