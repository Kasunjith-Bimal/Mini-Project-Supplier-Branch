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
    public partial class CategoriProcumentReport : Form
    {
        ProcurementCategoryLogic procat = new ProcurementCategoryLogic();
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        public CategoriProcumentReport()
        {
            InitializeComponent();
        }

          public void GetSource()
        {
            List<string> listnew= prolg.GetSource();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_categoriname.AutoCompleteCustomSource = listn;
        }
        private void CategoriProcumentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.ProcumentPlan' table. You can move, or remove it, as needed.
            
        }

        private void txt_categoriname_TextChanged(object sender, EventArgs e)
        {
            GetSource();
        }

        private void btn_showcategori_Click(object sender, EventArgs e)
        {
            string name =txt_categoriname.Text;
            int categoryid = procat.getCategoryid(name);

            this.ProcumentPlanTableAdapter.Fill(this.DataSet3.ProcumentPlan,categoryid);

            this.reportViewer1.RefreshReport();
        }
    }
}
