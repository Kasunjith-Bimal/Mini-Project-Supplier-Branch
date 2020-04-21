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
    public partial class ReqestView : Form
    {
        public ReqestView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminView window = new AdminView();
            this.Hide();
            window.Show();
        }

        private void btn_addrequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request obj = new Request();
            obj.Show();
        }

        private void btn_requestcat_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestCategory obj = new RequestCategory();
            obj.Show();
        }

        private void ReqestView_Load(object sender, EventArgs e)
        {

        }

        private void btn_editrequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestEdit obj = new RequestEdit();
            obj.Show();
        }

        private void btn_editreqCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReqestCategoryEdit obj = new ReqestCategoryEdit();
            obj.Show();
        }

        private void btn_deleterequest_Click(object sender, EventArgs e)
        {

        }
    }
}
