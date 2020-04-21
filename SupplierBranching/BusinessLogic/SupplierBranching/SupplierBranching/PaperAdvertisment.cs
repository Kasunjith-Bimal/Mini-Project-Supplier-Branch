using BusinessLogic;
using Model;
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
    public partial class PaperAdvertisment : Form
    {
        PaperAdvertismentLogic logic = new PaperAdvertismentLogic();
        ProcurementCategoryLogic procat = new ProcurementCategoryLogic();
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        ProcurementLogic plg = new ProcurementLogic();
        public PaperAdvertisment()
        {
            InitializeComponent();
        }

        public void GetSource()
        {
            List<string> listnew = prolg.GetSource();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_categori.AutoCompleteCustomSource = listn;
        }
        private void txt_categori_TextChanged(object sender, EventArgs e)
        {
            GetSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_tendername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cname = txt_categori.Text;
            int cid = procat.getCategoryid(cname);
            string heading = txt_heading.Text;
            string tenderName = txt_tendername.Text;
            string tenderNo = txt_tenderno.Text;
            decimal paymentStatus = Convert.ToDecimal(txt_payemntstatus.Text);
            DateTime shouldResponseDate = Convert.ToDateTime(dtp_shouldresponseDate.Text);
            DateTime madeDate = Convert.ToDateTime(dtp_madedate.Text);
            DateTime registrationEndDate = Convert.ToDateTime(dtp_registerenddate.Text);
            DateTime registrationStartDate = Convert.ToDateTime(dtp_registerstartdate.Text);
            string registrationStartTime = txt_starttime.Text;
            string registrationEndTime = txt_endtime.Text;


            PaperAdvertismentDTO objs = new PaperAdvertismentDTO();
            objs.Cid = cid;
            objs.Heading = heading;
            objs.Tendername = tenderName;
            objs.TenderNo = tenderNo;
            objs.PaymentStatus = paymentStatus;
            objs.ShouldResponseDate = shouldResponseDate;
            objs.MadeDate = madeDate;
            objs.RegistrationEndDate = registrationEndDate;
            objs.RegistrationStartDate = registrationStartDate;
            objs.RegistrationStartTime = registrationStartTime;
            objs.RegistrationEndTime = registrationEndTime;

            logic.AddData(objs);

            AddItemPaperAdvertistment window = new AddItemPaperAdvertistment();
            this.Hide();
            window.Show();


        }

        private void PaperAdvertisment_Load(object sender, EventArgs e)
        {

        }
    }
}
