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
    public partial class ReqestCategoryEdit : Form
    {
        RequestCategoryLogic logic = new RequestCategoryLogic();
        public ReqestCategoryEdit()
        {
            InitializeComponent();
            GetdataGrid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
        public void GetdataGrid()
        {
            List<RequestCategoryDTO> rlist = logic.Getlist();

            dgv_category.DataSource = rlist;
        }


       
        private void ReqestCategoryEdit_Load(object sender, EventArgs e)
        {

        }

        public void SelectGrid(){
            int row = dgv_category.CurrentCell.RowIndex;

            int cid = Convert.ToInt32(dgv_category.Rows[row].Cells["reqcid"].Value.ToString());
            String CategoryName = dgv_category.Rows[row].Cells["categoryname"].Value.ToString();

            txt_category.Text = CategoryName;

        }
        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectGrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String Search = txt_search.Text;

            List<RequestCategoryDTO> rlist = logic.Searchtext(Search);

            dgv_category.DataSource = rlist;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int row = dgv_category.CurrentCell.RowIndex;

            int cid = Convert.ToInt32(dgv_category.Rows[row].Cells["reqcid"].Value.ToString());
            String Catname = txt_category.Text;

            RequestCategoryDTO obj = new RequestCategoryDTO();


            obj.categoryname = Catname;
            obj.reqcid = cid;

            logic.editdata(obj);

            GetdataGrid();


          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int row = dgv_category.CurrentCell.RowIndex;

            int cid = Convert.ToInt32(dgv_category.Rows[row].Cells["reqcid"].Value.ToString());

            logic.deleteCategory(cid);

            GetdataGrid();


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_category.Text ="";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ReqestView obj = new ReqestView();
            obj.Show();
            this.Hide();
        }
    }
}
