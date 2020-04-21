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
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportViewPaperAddvertistment obj = new ReportViewPaperAddvertistment();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcumentPlanReport obj = new ProcumentPlanReport();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SectionProcumentPlanReoprt obj = new SectionProcumentPlanReoprt();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Hide();
            CategoriProcumentReport obj = new CategoriProcumentReport();
            obj.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            this.Hide();
            SectionCategoryProcumentReport obj = new SectionCategoryProcumentReport();
            obj.Show();

        }

        private void ReportView_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView obj = new AdminView();
            obj.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportRequestView obj = new ReportRequestView();
            obj.Show();
        }
    }
}
