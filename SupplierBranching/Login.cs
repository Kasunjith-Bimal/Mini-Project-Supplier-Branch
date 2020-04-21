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
    public partial class Login : Form
    {
        LoginLogic logic = new LoginLogic();
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {

                string password = txt_password.Text;
                string username = txt_username.Text;

                RegisterPersonDTO obj = new RegisterPersonDTO();

                obj.UserName = username;
                obj.Password = password;

                if (logic.Selectpassword(obj))
                {
                    this.Hide();
                    AdminView window = new AdminView();
                    window.Show();


                }
                else
                {

                    lbl_errormsg.Text = "UserName or Password is Incorrect";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
