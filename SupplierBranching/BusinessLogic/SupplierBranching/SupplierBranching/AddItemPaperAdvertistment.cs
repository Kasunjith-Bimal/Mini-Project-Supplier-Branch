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
            GetSource();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String name = txt_search.Text;
            List<ProcurementItemDTO> searchlist = addlogic.SearchCategorilogic(name);
            dgv_procumentPlan.DataSource = searchlist;
        
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
            dgv_paperadd.DataSource = null;
             List<AddItemPaperAdvertismentDTO> list =new List<AddItemPaperAdvertismentDTO>();
            String itemDescription = txt_itemdescription.Text;
            String Qty = txt_quantity.Text;
            String Cid = cid;
            String PID = Pid;
            int paperid = addlogic.getPaperidlogic();
            AddItemPaperAdvertismentDTO  obj = new AddItemPaperAdvertismentDTO();

            obj.cid = Convert.ToInt32(Cid);
            obj.pid = Convert.ToInt32(PID);
            obj.quantity = Convert.ToDecimal(Qty);
            obj.itemDescription = itemDescription;
            obj.paperid = paperid;
            list.Add(obj);

            returnlidt.AddRange(list);

            dgv_paperadd.DataSource = returnlidt;
            

         
        }

        private void btn_craeateaddvertistment_Click(object sender, EventArgs e)
        {
            addlogic.Addpaperaddvertistement(returnlidt);

            this.Hide();
            PaperAdvertistmentReport window = new PaperAdvertistmentReport();
            window.Show();
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

        private void AddItemPaperAdvertistment_Load(object sender, EventArgs e)
        {
            txt_quantity.Enabled = false;
        }

       
    }
}
