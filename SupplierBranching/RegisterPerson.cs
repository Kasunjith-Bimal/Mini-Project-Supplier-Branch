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

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItemPaperAdvertistment ne = new AddItemPaperAdvertistment();
            ne.Show();
        }


        public void showgrid()
        {

            grdshow.DataSource = logic.getallvalues();
            grdshow.Columns[5].Visible = false;
        }
        private void RegisterPerson_Load(object sender, EventArgs e)
        {
            showgrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            logic.deleteregisterperson(Convert.ToInt16(grdshow.SelectedCells[0].Value));

            showgrid();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminView obj = new AdminView();
            obj.Show();
            this.Hide();
        }
    }
}
