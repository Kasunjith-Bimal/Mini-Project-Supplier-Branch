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
            AdminPanel window = new AdminPanel();
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
    }
}
