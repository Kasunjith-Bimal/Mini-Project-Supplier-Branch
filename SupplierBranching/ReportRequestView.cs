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
    public partial class ReportRequestView : Form
    {
        public ReportRequestView()
        {
            InitializeComponent();
        }

        private void ReportRequestView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.RequestPaperAdd' table. You can move, or remove it, as needed.
            this.RequestPaperAddTableAdapter.Fill(this.DataSet4.RequestPaperAdd);

            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ReportView obj = new ReportView();
            this.Hide();
            obj.Show();
        }
    }
}
