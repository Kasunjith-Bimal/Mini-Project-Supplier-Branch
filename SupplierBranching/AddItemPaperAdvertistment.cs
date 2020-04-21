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
    public partial class AddItemPaperAdvertistment : Form
    {
        List<AddItemPaperAdvertismentDTO> returnlidt = new List<AddItemPaperAdvertismentDTO>();
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        AddItemPaperAdvertismentLogic addlogic = new AddItemPaperAdvertismentLogic();
        string cid;
        string Pid;

        public AddItemPaperAdvertistment()
        {
            InitializeComponent();
            getProcumentDate();
            SelectedProcumentitemlist();
        }
        public void GetSource()
        {
            List<string> listnew = prolg.GetSource();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_search.AutoCompleteCustomSource = listn;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmb_procument.Text != "" || txt_search.Text != "")
            {
                DateTime date = Convert.ToDateTime(cmb_procument.Text);
                int id = addlogic.getproductId(date);
                String name = txt_search.Text;

                if (name != "")
                {

                    List<ProcurementItemDTO> searchlist = addlogic.SearchCategorilogic(name, id);
                    dgv_procumentPlan.DataSource = searchlist;
                }
                else
                {

                    List<ProcurementItemDTO> list = addlogic.GetListItem(id);
                    dgv_procumentPlan.DataSource = list;
                }
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void dgv_procumentPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dgv_procumentPlan.CurrentCell.RowIndex;
                if (rowIndex != -1)
                {
                    cid =dgv_procumentPlan.Rows[rowIndex].Cells["Cid"].Value.ToString();
                    //string paperid = dgv_procumentPlan.Rows[rowIndex].Cells["Cid"].Value.ToString();
                    string item=dgv_procumentPlan.Rows[rowIndex].Cells["ItemDescription"].Value.ToString();
                    string qty=dgv_procumentPlan.Rows[rowIndex].Cells["Qty"].Value.ToString();
                    Pid=dgv_procumentPlan.Rows[rowIndex].Cells["PID"].Value.ToString();


                    txt_itemdescription.Text = item;
                    txt_quantity.Text =qty;
                }


            }
            
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_procumentPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_additemtopaperaddvertistment_Click(object sender, EventArgs e)
        {
            if (txt_itemdescription.Text != "" && txt_quantity.Text != "")
            {


                dgv_paperadd.DataSource = null;
                List<AddItemPaperAdvertismentDTO> list = new List<AddItemPaperAdvertismentDTO>();
                String itemDescription = txt_itemdescription.Text;
                String Qty = txt_quantity.Text;
                String Cid = cid;
                String PID = Pid;
                int paperid = addlogic.getPaperidlogic();
                AddItemPaperAdvertismentDTO obj = new AddItemPaperAdvertismentDTO();

                obj.cid = Convert.ToInt32(Cid);
                obj.pid = Convert.ToInt32(PID);
                obj.quantity = Convert.ToDecimal(Qty);
                obj.itemDescription = itemDescription;
                obj.paperid = paperid;
                list.Add(obj);

                returnlidt.AddRange(list);

                dgv_paperadd.DataSource = returnlidt;
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
        }

        private void btn_craeateaddvertistment_Click(object sender, EventArgs e)
        {
            addlogic.Addpaperaddvertistement(returnlidt);

            this.Hide();
            ReportViewPaperAddvertistment report = new ReportViewPaperAddvertistment();
            report.Show();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv_paperadd.SelectedRows)
            {
                returnlidt.RemoveAt(item.Index);
                dgv_paperadd.DataSource = null;
                dgv_paperadd.Update();
                dgv_paperadd.Refresh();
                dgv_paperadd.DataSource = returnlidt;
            }

        }

        public void getProcumentDate()
        {

            List<DateTime> list = new List<DateTime>();
             list = addlogic.ProcumentDatelogic();
             cmb_procument.DataSource = list;
        }


        public void SelectedProcumentitemlist()
        {
            DateTime date = Convert.ToDateTime(cmb_procument.Text);
            int productid = addlogic.getproductId(date);
            List<ProcurementItemDTO> list = addlogic.GetListItem(productid);
            dgv_procumentPlan.DataSource = list;

        }
        private void AddItemPaperAdvertistment_Load(object sender, EventArgs e)
        {
            txt_quantity.Enabled = false;
            GetSource();
            //GetSourcedb();
        }


        public void GetSourcedb()
        {
            List<string> listnew = prolg.GetSource();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_search.AutoCompleteCustomSource = listn;
        }
        private void cmb_procument_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProcumentitemlist();
        }

        private void dgv_paperadd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_bavk_Click(object sender, EventArgs e)
        {
            PaperAdvertisment obj = new PaperAdvertisment();
            this.Hide();
            obj.Show();

        }

       
    }
}
