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
    public partial class CompanyRegistration : Form
    {
        CompanyRegistrationLogic logic = new CompanyRegistrationLogic();
        AddItemPaperAdvertismentLogic addlogic = new AddItemPaperAdvertismentLogic();
        public CompanyRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Companyname = txt_companyname.Text;
            string Address = txt_address.Text;
            string TelephoneNo = txt_phoneno.Text;
            string Email = txt_email.Text;
            string CompanyregistrationNo = txt_companyregno.Text;
            int paperid = addlogic.getPaperidlogic();
            DateTime regdate = Convert.ToDateTime(dtp_Registrationdate.Text);

            CompanyRegistrationDTO obj = new CompanyRegistrationDTO();


            obj.CompanyName = Companyname;
            obj.Address = Address;
            obj.CompanyRegistrationNo = CompanyregistrationNo;
            obj.Email = Email;
            obj.TelephoneNo = TelephoneNo;
            obj.Paperid = paperid;
            obj.RegistrationDate = regdate;

            logic.addCompanyRegistration(obj);

            getData();





        }

        public void getData()
        {

            List<CompanyRegistrationDTO> list = logic.getlist();
            dgv_company.DataSource = list;

        }

        private void CompanyRegistration_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void SelectData()
        {

            int row = dgv_company.CurrentCell.RowIndex;

            String Companyname = dgv_company.Rows[row].Cells["CompanyName"].Value.ToString();

            String CompanyRegistrationNo = dgv_company.Rows[row].Cells["CompanyRegistrationNo"].Value.ToString();

            String Email = dgv_company.Rows[row].Cells["Email"].Value.ToString();

            String TelephoneNo = dgv_company.Rows[row].Cells["TelephoneNo"].Value.ToString();

            String address = dgv_company.Rows[row].Cells["Address"].Value.ToString();

            DateTime RegistrationDate = Convert.ToDateTime(dgv_company.Rows[row].Cells["RegistrationDate"].Value.ToString());


            txt_address.Text = address;
            txt_companyname.Text = Companyname;
            txt_companyregno.Text = CompanyRegistrationNo;
            txt_email.Text = Email;
            txt_phoneno.Text = TelephoneNo;
            dtp_Registrationdate.Text = RegistrationDate.ToString();


        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string Searchname = txt_companysearch.Text;

            List<CompanyRegistrationDTO> list = logic.Searchlist(Searchname);
            dgv_company.DataSource = list;
        }

        private void dgv_company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            CompanyRegistrationDTO obj = new CompanyRegistrationDTO();

            int row = dgv_company.CurrentCell.RowIndex;

            int id = Convert.ToInt32(dgv_company.Rows[row].Cells["id"].Value.ToString());
            obj.id = id;
            obj.Address = txt_address.Text;
            obj.CompanyName = txt_companyname.Text;
            obj.CompanyRegistrationNo = txt_companyregno.Text;
            obj.Email = txt_email.Text;
            obj.TelephoneNo = txt_phoneno.Text;
            obj.RegistrationDate = Convert.ToDateTime(dtp_Registrationdate.Text);

            logic.EditCompanyRegistration(obj);
            getData();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_companyname.Text = "";
            txt_companyregno.Text = "";
            txt_email.Text = "";
            txt_phoneno.Text = "";
            dtp_Registrationdate.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int row = dgv_company.CurrentCell.RowIndex;

            int id = Convert.ToInt32(dgv_company.Rows[row].Cells["id"].Value.ToString());

            logic.deleteCompany(id);

            getData();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminView obj = new AdminView();
            obj.Show();
            this.Hide();
        }
    }
}
