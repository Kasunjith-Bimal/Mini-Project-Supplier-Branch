using BusinessLogic;
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
    public partial class ProCategoryEditDelete : Form
    {
        ProcurementCategoryLogic prolg = new ProcurementCategoryLogic();
        public ProCategoryEditDelete()
        {
            InitializeComponent();
        }

        private void EditDeleteCategory_Load(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcumentView obj = new ProcumentView();
            obj.Show();
        }
       

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id=0;
            
            foreach (DataGridViewRow item in dgv_procategory.SelectedRows)
            {
                id = Convert.ToInt32(item.Cells["Cid"].Value.ToString());
            }
            prolg.DeleteCategory(id);
            ShowGrid();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = null;
            string cname = null;
            foreach (DataGridViewRow item in dgv_procategory.SelectedRows)
            {
                id = item.Cells["Cid"].Value.ToString();
            }
            int idno = Convert.ToInt16(id);
            cname = txt_category.Text;
            prolg.EditCategory(idno,cname);
            ShowGrid();
            
        }
        public void ShowGrid()
        {
            dgv_procategory.DataSource = prolg.ShowGrid();
            dgv_procategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
            dgv_procategory.DataSource = prolg.Search(txt_search.Text);
        }

        private void dgv_procategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = null;
            string cname = null;
            foreach (DataGridViewRow item in dgv_procategory.SelectedRows)
            {
                id = item.Cells["Cid"].Value.ToString();
                cname = item.Cells["CategoryName"].Value.ToString();

            }
            int idno = Convert.ToInt16(id);
            txt_category.Text = cname;
        }
    }
}
