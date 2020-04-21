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
    public partial class ProcumentPlanReport : Form
    {
        public ProcumentPlanReport()
        {
            InitializeComponent();
        }

        private void ProcumentPlanReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.ProcumentPlan' table. You can move, or remove it, as needed.
            this.ProcumentPlanTableAdapter.Fill(this.DataSet2.ProcumentPlan);

            this.reportViewer1.RefreshReport();
        }
    }
}
