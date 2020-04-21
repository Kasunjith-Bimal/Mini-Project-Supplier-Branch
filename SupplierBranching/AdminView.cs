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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void btn_procument_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcumentView pro = new ProcumentView();
            pro.Show();
        }

        private void btn_reqest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReqestView req = new ReqestView();
            req.Show();
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyRegistration obj = new CompanyRegistration();
            obj.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections sec = new Sections();
            sec.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void btn_paperadvertistment_Click(object sender, EventArgs e)
        {
            PaperAdvertisment paperaddver = new PaperAdvertisment();
            this.Hide();
            paperaddver.Show();
        }

        private void btn_qutation_Click(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportView obj = new ReportView();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcumentView pro = new ProcumentView();
            pro.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReqestView req = new ReqestView();
            req.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections sec = new Sections();
            sec.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           PaperAddvertitmentWindow Papaperaddver = new PaperAddvertitmentWindow();
            this.Hide();
            Papaperaddver.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            ReportView obj = new ReportView();
            obj.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyRegistration obj = new CompanyRegistration();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPerson obj = new RegisterPerson();
            obj.Show();

        }
    }
}
