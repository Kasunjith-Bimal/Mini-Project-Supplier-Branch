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
    public partial class RequestPaperAddvertistment : Form
    {
        RequestPaperAdvertistmentLogic logic = new RequestPaperAdvertistmentLogic();
        public RequestPaperAddvertistment()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (txt_categori.Text != "" && txt_heading.Text != "" && txt_tendername.Text != "" &&
                txt_tenderno.Text != "" && txt_payemntstatus.Text != "" && txt_starttime.Text != "" && txt_endtime.Text != "")
            {
                string cname = txt_categori.Text;

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
                objs.Categoryname = cname;
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



                ReqestPaperAddItemPage window = new ReqestPaperAddItemPage();
                this.Hide();
                window.Show();
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Getdata()
        {
            List<PaperAdvertismentDTO> getlist = new List<PaperAdvertismentDTO>();
            getlist = logic.getdatatogrid();
            dgv_papaeradvertistment.DataSource = getlist;
        }
        public void GetSource()
        {
            List<string> listnew = logic.GetCategoryNameList();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_categori.AutoCompleteCustomSource = listn;
        }
        private void RequestPaperAddvertistment_Load(object sender, EventArgs e)
        {
            Getdata();

            GetSource();
        }


        public void SelectDataGrid()
        {
            int row = dgv_papaeradvertistment.CurrentCell.RowIndex;


            String Heading = dgv_papaeradvertistment.Rows[row].Cells["Heading"].Value.ToString();

            String CategoryName = dgv_papaeradvertistment.Rows[row].Cells["CategoryName"].Value.ToString();

            String TenderName = dgv_papaeradvertistment.Rows[row].Cells["Tendername"].Value.ToString();
            String TenderNo = dgv_papaeradvertistment.Rows[row].Cells["TenderNo"].Value.ToString();
            String Payementstatus = dgv_papaeradvertistment.Rows[row].Cells["PaymentStatus"].Value.ToString();
            DateTime Registrationstartdate = Convert.ToDateTime(dgv_papaeradvertistment.Rows[row].Cells["RegistrationStartDate"].Value.ToString());
            DateTime Registrationenddate = Convert.ToDateTime(dgv_papaeradvertistment.Rows[row].Cells["RegistrationEndDate"].Value.ToString());
            DateTime Shouderesponsedate = Convert.ToDateTime(dgv_papaeradvertistment.Rows[row].Cells["ShouldResponseDate"].Value.ToString());
            DateTime Madedate = Convert.ToDateTime(dgv_papaeradvertistment.Rows[row].Cells["MadeDate"].Value.ToString());
            String Registrationstrarttime = dgv_papaeradvertistment.Rows[row].Cells["RegistrationStartTime"].Value.ToString();
            String Registrationendtime = dgv_papaeradvertistment.Rows[row].Cells["RegistrationEndTime"].Value.ToString();

            txt_heading.Text = Heading;
            txt_payemntstatus.Text = Payementstatus;
            txt_categori.Text = CategoryName;
            txt_endtime.Text = Registrationendtime;
            txt_starttime.Text = Registrationstrarttime;
            txt_tendername.Text = TenderName;
            txt_tenderno.Text = TenderNo;
            dtp_madedate.Text = Madedate.ToShortDateString();
            dtp_registerenddate.Text = Registrationenddate.ToShortDateString();
            dtp_registerstartdate.Text = Registrationstartdate.ToShortDateString();
            dtp_shouldresponseDate.Text = Shouderesponsedate.ToShortDateString();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_categori.Text != "" || txt_heading.Text != "" || txt_tendername.Text != "" ||
              txt_tenderno.Text != "" || txt_payemntstatus.Text != "" || txt_starttime.Text != "" || txt_endtime.Text != "")
            {
                int row = dgv_papaeradvertistment.CurrentCell.RowIndex;

                int paperid = Convert.ToInt32(dgv_papaeradvertistment.Rows[row].Cells["Paperid"].Value.ToString());
                string cname = txt_categori.Text;

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
                objs.Categoryname = cname;
                objs.Paperid = paperid;
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


                logic.Edit(objs);

                Getdata();
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_papaeradvertistment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_papaeradvertistment.SelectedRows.Count > 0)
            {
                int row = dgv_papaeradvertistment.CurrentCell.RowIndex;

                int paperid = Convert.ToInt32(dgv_papaeradvertistment.Rows[row].Cells["Paperid"].Value.ToString());


                logic.delete(paperid);

                Getdata();
            }
            else
            {
                MessageBox.Show("Select a item", "Delete Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            PaperAddvertitmentWindow obj = new PaperAddvertitmentWindow();
            this.Hide();
            obj.Show();
        }
    }
}
