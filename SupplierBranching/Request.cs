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
    public partial class Request : Form
    {
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        RequestLogic rlogic = new RequestLogic();
        public Request()
        {
            InitializeComponent();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            GetSourceofIdentcode();
        }
        public void GetSourceofIdentcode()
        {
            List<string> listnew = prolg.GetSourceIden();
            var listn = new AutoCompleteStringCollection();
            listn.AddRange(listnew.ToArray());
            txt_idencode.AutoCompleteCustomSource = listn;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_department.Text != "" && txt_idencode.Text != "" && txt_reqpersion.Text != "")
            {


                requestAdd();
                this.Hide();
                RequestItem obj = new RequestItem();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void requestAdd()
        {
            try
            {
                RequestDTO obj = new RequestDTO();

                obj.department = txt_department.Text;
                obj.reqpersion = txt_reqpersion.Text;
                obj.idencode = txt_idencode.Text;
                obj.reqdate = Convert.ToDateTime(dtp_reqdate.Text);
                rlogic.requestAdd(obj);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ReqestView reqestview = new ReqestView();
            this.Hide();
            reqestview.Show();
        }
    }
}
