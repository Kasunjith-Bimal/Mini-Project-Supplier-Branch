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
        int pid, cid, ppid=0;
        int SerialNo;
        public ProcurementItem()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_category.Text != "" || txt_idencode.Text != "" || txt_itemdes.Text != "" || txt_qty.Text != "" || txt_estimateunitprice.Text != "")
            {
                ProItemAdd();
                ShowGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            
        }

        private void txt_category_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        public void ProItemAdd()
        {
            try
            {
                string cname = txt_category.Text;
                 cid = procat.getCategoryid(cname);
                 if (dgv_itemgrid.DataSource == null)
                 {
                     pid = plg.GetProId();
                 }
                 else
                 {
                     pid = Convert.ToInt32(dgv_itemgrid.Rows[0].Cells["PID"].Value.ToString());
                 }
                ProcurementItemDTO obj = new ProcurementItemDTO();
                obj.Cid = cid;
                obj.Pid = pid;
                obj.Qty = Convert.ToDecimal(txt_qty.Text);
                obj.EstimatedUnitPrice = Convert.ToDecimal(txt_estimateunitprice.Text);
                obj.EstimatetedTotalPrice = Convert.ToDecimal(obj.Qty * obj.EstimatedUnitPrice);
                obj.SourceOfFunding = txt_source.Text;
                obj.ProcumentMethod = cmb_procurementmethod.Text;
                obj.LevelOfAuthority = txt_levelauthority.Text;
                
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
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        public void ShowGrid()
        {
            
            dgv_itemgrid.DataSource = prolg.ShowGrid(pid);
        }
        public void ShowGridEdit(int pid)
        {
            this.pid = pid;
            dgv_itemgrid.DataSource = prolg.ShowGrid(pid);
        }

        private void ProcurementItem_Load(object sender, EventArgs e)
        {
            GetSource();
            GetSourceofIdentcode();
        }

        private void dgv_itemgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_itemgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                txt_category.Text = dgv_itemgrid.Rows[rindex].Cells["CategoryName"].Value.ToString();
                txt_itemdes.Text = dgv_itemgrid.Rows[rindex].Cells["Itemdescription"].Value.ToString();
                txt_idencode.Text = dgv_itemgrid.Rows[rindex].Cells["IdentificationCode"].Value.ToString();
                txt_qty.Text = dgv_itemgrid.Rows[rindex].Cells["Qty"].Value.ToString();
                txt_estimateunitprice.Text = dgv_itemgrid.Rows[rindex].Cells["EstimatedUnitPrice"].Value.ToString();
                txt_source.Text = dgv_itemgrid.Rows[rindex].Cells["SourceOfFunding"].Value.ToString();
                cmb_procurementmethod.Text = dgv_itemgrid.Rows[rindex].Cells["ProcumentMethod"].Value.ToString();
                txt_levelauthority.Text = dgv_itemgrid.Rows[rindex].Cells["LevelOfAuthority"].Value.ToString();
                txt_currentstatus.Text = dgv_itemgrid.Rows[rindex].Cells["CurrentStatusofProcument"].Value.ToString();
                cmb_prioritystatus.Text = dgv_itemgrid.Rows[rindex].Cells["PriorityStatus"].Value.ToString();
                txt_remarks.Text = dgv_itemgrid.Rows[rindex].Cells["Remarks"].Value.ToString();
                dtp_completiondate.Text = dgv_itemgrid.Rows[rindex].Cells["ScheduleDate"].Value.ToString();
                SerialNo = Convert.ToInt32(dgv_itemgrid.Rows[rindex].Cells["Serialno"].Value.ToString());

            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_category.Text != "" || txt_idencode.Text != "" || txt_itemdes.Text != "" || txt_qty.Text != "" || txt_estimateunitprice.Text != "")
            {
                EditItem();
                ShowGrid();
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditItem()
        {
            ProcurementItemDTO obj = new ProcurementItemDTO();
            string cname = txt_category.Text;
            obj.Pid = Convert.ToInt32(dgv_itemgrid.Rows[0].Cells["Pid"].Value.ToString());
            obj.Serialno = SerialNo;
            obj.Cid = procat.getCategoryid(cname);
            obj.ItemDescription = txt_itemdes.Text;
            obj.IdentificationCode = txt_idencode.Text;
            obj.Qty = Convert.ToDecimal(txt_qty.Text);
            obj.EstimatedUnitPrice = Convert.ToDecimal(txt_estimateunitprice.Text);
            obj.EstimatetedTotalPrice = obj.Qty * obj.EstimatedUnitPrice;
            obj.SourceOfFunding = txt_source.Text;
            obj.ProcumentMethod = cmb_procurementmethod.Text;
            obj.LevelOfAuthority = txt_levelauthority.Text;
            obj.CurrentStatusofProcument = txt_currentstatus.Text;
            obj.PriorityStatus = cmb_prioritystatus.Text;
            obj.Remarks = txt_remarks.Text;
            obj.ScheduleDate = Convert.ToDateTime(dtp_completiondate.Text);
            prolg.EditItem(obj);
        }
        public void ClearFields()
        {

            txt_category.Text = "";
             txt_itemdes.Text = "";
            txt_idencode.Text ="";
            txt_qty.Text ="";
            txt_estimateunitprice.Text="";
           
            txt_source.Text = "";
            cmb_procurementmethod.Text = "";
          txt_levelauthority.Text="";
           txt_currentstatus.Text="";
           cmb_prioritystatus.Text = "";
           txt_remarks.Text="";
            dtp_completiondate.Text="";
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_itemgrid.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dgv_itemgrid.SelectedCells[0].Value.ToString());
                prolg.DeleteItem(a);
                ShowGridEdit(pid);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Select a item", "Delete Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_prioritystatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_levelauthority_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_procurementmethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_source_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_estimateunitprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_currentstatus_Click(object sender, EventArgs e)
        {

        }

        private void lbl_prioritystatus_Click(object sender, EventArgs e)
        {

        }

        private void lbl_levelauthority_Click(object sender, EventArgs e)
        {

        }

        private void lbl_procurementmethod_Click(object sender, EventArgs e)
        {

        }

        private void lbl_source_Click(object sender, EventArgs e)
        {

        }

        private void lbl_estimateunitprice_Click(object sender, EventArgs e)
        {

        }

        private void txt_currentstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_itemdes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_qty_Click(object sender, EventArgs e)
        {

        }

        private void lbl_category_Click(object sender, EventArgs e)
        {

        }

        private void dtp_completiondate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_completiondate_Click(object sender, EventArgs e)
        {

        }

        private void lbl_remarks_Click(object sender, EventArgs e)
        {

        }

        private void txt_remarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ProcumentView requestview = new ProcumentView();
            this.Hide();
            requestview.Show();
        }

        private void btn_backtopro_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcurementEdit obj = new ProcurementEdit();
            obj.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
            if (dgv_itemgrid.DataSource != null)
            {
                if (ppid == 0)
                {
                    ppid = Convert.ToInt32(dgv_itemgrid.Rows[0].Cells["PID"].Value.ToString());
                }
                if (cmb_search.SelectedIndex == 0)
                {
                    dgv_itemgrid.DataSource = prolg.SearchItem(0, txt_search.Text,ppid);
                }
                else if (cmb_search.SelectedIndex == 1)
                {
                    dgv_itemgrid.DataSource = prolg.SearchItem(1, txt_search.Text,ppid);
                }
            }
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryProcurement obj = new CategoryProcurement();
            obj.Show();
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }


            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txt_estimateunitprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }


            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            pid = plg.GetProId();
            LoadCSV obj = new LoadCSV();
            obj.GetProId(pid);
            obj.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
