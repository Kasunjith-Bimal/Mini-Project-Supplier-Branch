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
    public partial class RequestCategory : Form
    {
        RequestCategoryLogic clog = new RequestCategoryLogic();
        public RequestCategory()
        {
            InitializeComponent();
        }

        private void RequestCategory_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            categoryAdd();
            this.Hide();
                RequestItem obj = new RequestItem();
            obj.Show();
        }
        public void categoryAdd()
        {
            try
            {
                RequestCategoryDTO obj = new RequestCategoryDTO();
                obj.categoryname = txt_category.Text;
                clog.requestCategoryAdd(obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
            

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReqestView obj = new ReqestView();
            obj.Show();
        }
    }
}
