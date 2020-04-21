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
            string CompanyregistrationNo =txt_companyregno.Text;
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







        }
    }
}
