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
    public partial class ProcumentPlanReport : Form
    {
        AddItemPaperAdvertismentLogic addlogic = new AddItemPaperAdvertismentLogic();
        public ProcumentPlanReport()
        {
            InitializeComponent();
        }

        public void getProcumentDate()
        {

            List<DateTime> list = new List<DateTime>();
            list = addlogic.ProcumentDatelogic();
            cmb_selectprocument.DataSource = list;
        }

       
        private void ProcumentPlanReport_Load(object sender, EventArgs e)
        {
          
            getProcumentDate();
                // TODO: This line of code loads data into the 'DataSet2.ProcumentPlan' table. You can move, or remove it, as needed.
            //this.ProcumentPlanTableAdapter.Fill(this.DataSet2.ProcumentPlan);

            //this.reportViewer1.RefreshReport();
        }

        private void btn_procument_Click(object sender, EventArgs e)
        {
            DateTime procumentdate = Convert.ToDateTime(cmb_selectprocument.Text);
            int procmntid = addlogic.getproductId(procumentdate);
            this.ProcumentPlanTableAdapter.Fill(this.DataSet2.ProcumentPlan,procmntid);

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
