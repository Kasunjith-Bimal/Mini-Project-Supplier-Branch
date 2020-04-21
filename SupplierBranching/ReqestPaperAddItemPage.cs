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
    public partial class ReqestPaperAddItemPage : Form
    {
        List<AddItemPaperAdvertismentDTO> returnlidt = new List<AddItemPaperAdvertismentDTO>();
        int cid;
        int reqid;
        RequestAddItemPageLogic addlogic = new RequestAddItemPageLogic();
        public ReqestPaperAddItemPage()
        {
            InitializeComponent();
        }

        private void ReqestPaperAddItemPage_Load(object sender, EventArgs e)
        {
            getReqesttDate();

            SelectedReqestitemlist();
        }

        public void SelectedReqestitemlist()
        {
            DateTime date = Convert.ToDateTime(cmb_reqest.Text);
            int productid = addlogic.getreqestId(date);
            List<RequestItemDTO> list = addlogic.GetListItem(productid);
            dgv_ReqestPlan.DataSource = list;

        }

        public void getReqesttDate()
        {
            List<DateTime> List = addlogic.GetReqestDate();
            cmb_reqest.DataSource = List;


            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmb_reqest.Text != "" || txt_search.Text != "")
            {
                DateTime date = Convert.ToDateTime(cmb_reqest.Text);
                int id = addlogic.getreqestId(date);
                String name = txt_search.Text;

                if (name != "")
                {

                    List<RequestItemDTO> searchlist = addlogic.SearchCategori(name, id);
                    dgv_ReqestPlan.DataSource = searchlist;
                }
                else
                {

                    List<RequestItemDTO> list = addlogic.GetListItem(id);
                    dgv_ReqestPlan.DataSource = list;
                }
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void dgv_ReqestPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dgv_ReqestPlan.CurrentCell.RowIndex;
                if (rowIndex != -1)
                {
                    cid = Convert.ToInt32(dgv_ReqestPlan.Rows[rowIndex].Cells["reqcid"].Value.ToString());
                   
                    string item = dgv_ReqestPlan.Rows[rowIndex].Cells["itemdes"].Value.ToString();
                    string qty = dgv_ReqestPlan.Rows[rowIndex].Cells["quantity"].Value.ToString();
                    reqid = Convert.ToInt32(dgv_ReqestPlan.Rows[rowIndex].Cells["reqid"].Value.ToString());


                    txt_itemdescription.Text = item;
                    txt_quantity.Text = qty;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_additemtopaperaddvertistment_Click(object sender, EventArgs e)
        {
            if (txt_itemdescription.Text != "" && txt_quantity.Text != "")
            {


                dgv_paperadd.DataSource = null;
                List<AddItemPaperAdvertismentDTO> list = new List<AddItemPaperAdvertismentDTO>();
                String itemDescription = txt_itemdescription.Text;
                String Qty = txt_quantity.Text;
                int Cid = cid;
                int Rid = reqid;
                int paperid = addlogic.getPaperidlogic();
                AddItemPaperAdvertismentDTO obj = new AddItemPaperAdvertismentDTO();

                obj.cid = Convert.ToInt32(Cid);
                obj.Reqid = Convert.ToInt32(Rid);
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

        private void btn_craeateaddvertistment_Click(object sender, EventArgs e)
        {
            addlogic.Addpaperaddvertistement(returnlidt);

            ReportRequestView window = new ReportRequestView();
            this.Hide();
            window.Show();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RequestPaperAddvertistment obj = new RequestPaperAddvertistment();
            this.Hide();
            obj.Show();
        }
    }
}
