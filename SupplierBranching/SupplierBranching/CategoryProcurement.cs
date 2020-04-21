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
    public partial class CategoryProcurement : Form
    {
        ProcurementCategoryLogic catlog = new ProcurementCategoryLogic();
        public CategoryProcurement()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddtoCategory();
            this.Hide();
            ProcurementItem obj = new ProcurementItem();
            obj.Show();
        }
        public void AddtoCategory()
        {
            try
            {
                string category = txt_category.Text;
                CategoryProcuremntDTO obj = new CategoryProcuremntDTO();
                obj.CategoryName = category;
                catlog.AddProCategory(obj);
            }
            catch (Exception ex)
            {
                
                
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ProcumentView window = new ProcumentView();
            this.Hide();
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_category.Text = "";
        }
    }
}
