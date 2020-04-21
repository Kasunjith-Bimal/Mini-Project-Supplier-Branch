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
    public partial class PaperAddvertitmentWindow : Form
    {
        public PaperAddvertitmentWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaperAdvertisment obj = new PaperAdvertisment();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestPaperAddvertistment obj = new RequestPaperAddvertistment();
            this.Hide();
            obj.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminView obj = new AdminView();
            obj.Show();
            this.Hide();
        }
    }
}
