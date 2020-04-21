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
    public partial class SectionCategoryProcumentReport : Form
    {
        ProcurementCategoryLogic procat = new ProcurementCategoryLogic();
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        AddItemPaperAdvertismentLogic addlogic = new AddItemPaperAdvertismentLogic();
        public SectionCategoryProcumentReport()
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
        private void SectionCategoryProcumentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SectionCategoryReport.ProcumentPlan' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'SectionCategoryReport.ProcumentPlan' table. You can move, or remove it, as needed.
          
         
          
            GetSourceofIdentcode();
            getProcumentDate();
            GetSource();
         
        }

        public void GetSource()
        {
            List<string> listnew = prolg.GetSource();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_category.AutoCompleteCustomSource = listn;
        }
        private void btn_procumentsearch_Click(object sender, EventArgs e)
        {
            DateTime procumentdate = Convert.ToDateTime(cmb_selectprocument.Text);
            int procmntid = addlogic.getproductId(procumentdate);

            String identificationcode = txt_sectionname.Text;

            String Categoryname = txt_category.Text;

            int cid = procat.getCategoryid(Categoryname);

            this.ProcumentPlanTableAdapter.Fill(this.SectionCategoryReport.ProcumentPlan, procmntid,identificationcode,cid);

            this.reportViewer1.RefreshReport();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView obj = new AdminView();
            obj.Show();
        }
    }
}
