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
    public partial class RegisterPerson : Form
    {
        ReqestPersonLogic logic = new ReqestPersonLogic();
        public RegisterPerson()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string IdentificationCode = txt_identificationCode.Text;
            string Post = txt_post.Text;
            string RequestPersonName = txt_ReqestPersonName.Text;
            string UsreName = txt_username.Text;
            string Password = txt_password.Text;

            RegisterPersonDTO obj =new RegisterPersonDTO();


            obj.IdentificationCode =IdentificationCode;
            obj.Post =Post;
            obj.RequestPersonName =RequestPersonName;
            obj.Password =Password;
            obj.UserName =UsreName;

            logic.addSection(obj);

        }

        private void txt_identificationCode_TextChanged(object sender, EventArgs e)
        {

            try
            {
             List<string> IdentificationCode = logic.getidentificationCode();
             var autocomlete = new AutoCompleteStringCollection();
             autocomlete.AddRange(IdentificationCode.ToArray());
             txt_identificationCode.AutoCompleteCustomSource = autocomlete;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_identificationCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string identipicationcode = this.txt_identificationCode.Text;
            }
        }

        private void btn_paperadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaperAdvertisment pa = new PaperAdvertisment();
            pa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItemPaperAdvertistment ne = new AddItemPaperAdvertistment();
            ne.Show();
        }
    }
}
