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
    public partial class SectionProcumentPlanReoprt : Form
    {
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        AddItemPaperAdvertismentLogic addlogic = new AddItemPaperAdvertismentLogic();
        public SectionProcumentPlanReoprt()
        {
            InitializeComponent();
        }

        public void getProcumentDate()
        {

            List<DateTime> list = new List<DateTime>();
            list = addlogic.ProcumentDatelogic();
            cmb_selectprocument.DataSource = list;
        }

        public void GetSourceofIdentcode()
        {
            List<string> listnew = prolg.GetSourceIden();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_sectionname.AutoCompleteCustomSource = listn;
        }
        private void SectionProcumentPlanReoprt_Load(object sender, EventArgs e)
        {
            
            
            GetSourceofIdentcode();
            getProcumentDate();
        }
           

        private void btn_procumentsearch_Click(object sender, EventArgs e)
        {
            DateTime procumentdate = Convert.ToDateTime(cmb_selectprocument.Text);
            int procmntid = addlogic.getproductId(procumentdate);

            String identificationcode = txt_sectionname.Text;

            this.ProcumentPlanTableAdapter.Fill(this.SectionProcumentReport.ProcumentPlan,procmntid,identificationcode);
            this.reportViewer1.RefreshReport();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView add = new AdminView();
            add.Show();
        }
        
    }
}
