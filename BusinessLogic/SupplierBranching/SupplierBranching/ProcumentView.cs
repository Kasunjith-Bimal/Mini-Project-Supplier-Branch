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
    public partial class ProcumentView : Form
    {
        public ProcumentView()
        {
            InitializeComponent();
        }

        private void btn_addprocumentplan_Click(object sender, EventArgs e)
        {
            Procuremnt window = new Procuremnt();
            this.Hide();
            window.Show();
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            CategoryProcurement window = new CategoryProcurement();
            this.Hide();
            window.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminPanel window = new AdminPanel();
            this.Hide();
            window.Show();
        }
    }
}
