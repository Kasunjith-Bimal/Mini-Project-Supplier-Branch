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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItemPaperAdvertistment w = new AddItemPaperAdvertistment();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryProcurement w = new CategoryProcurement();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login w = new Login();
            w.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaperAdvertisment w = new PaperAdvertisment();
            w.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcumentPlanReport w = new ProcumentPlanReport();
            w.Show();
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcurementItem w = new ProcurementItem();
            w.Show();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Procuremnt w = new Procuremnt();
            w.Show();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPerson w = new RegisterPerson();
            w.Show();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections w = new Sections();
            w.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriProcumentReport w = new CategoriProcumentReport();
            w.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request w = new Request();
            w.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            this.Hide();
            RequestCategory w = new RequestCategory();
            w.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestItem w = new RequestItem();
            w.Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyRegistration w = new CompanyRegistration();
            w.Show();

        }

        private void btn_procument_Click(object sender, EventArgs e)
        {
            ProcumentView window = new ProcumentView();
            this.Hide();
            window.Show();
        }

        private void btn_reqest_Click(object sender, EventArgs e)
        {
            ReqestView window = new ReqestView();
            this.Hide();
            window.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReportViewPaperAddvertistment report = new ReportViewPaperAddvertistment();
            report.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login loginwindow = new Login();
            this.Hide();
            loginwindow.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SectionProcumentPlanReoprt report = new SectionProcumentPlanReoprt();
            report.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SectionCategoryProcumentReport report = new SectionCategoryProcumentReport();
            report.Show();
        }
    }
}
