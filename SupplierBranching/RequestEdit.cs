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
    public partial class RequestEdit : Form
    {
        ProcuremntItemLogic prolg = new ProcuremntItemLogic();
        RequestEditLogic logic = new RequestEditLogic();
        public RequestEdit()
        {
            InitializeComponent();
            reqestdata();
        }

        public void reqestdata()
        {

            List<RequestDTO> returnlist = logic.Getdata();
            dgv_request.DataSource = returnlist;
        }

        private void RequestEdit_Load(object sender, EventArgs e)
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
        public void SelectData()
        {
            int row = dgv_request.CurrentCell.RowIndex;

            int reqestid = Convert.ToInt32(dgv_request.Rows[row].Cells["reqid"].Value.ToString());
            String Idetificationcode = dgv_request.Rows[row].Cells["idenCode"].Value.ToString();
            String Department = dgv_request.Rows[row].Cells["department"].Value.ToString();
            DateTime ReqestDate = Convert.ToDateTime(dgv_request.Rows[row].Cells["reqdate"].Value.ToString());
            String RequestPerson = dgv_request.Rows[row].Cells["reqpersion"].Value.ToString();

            txt_department.Text = Department;
            txt_idencode.Text = Idetificationcode;
            txt_reqpersion.Text = RequestPerson;
            dtp_reqdate.Text = ReqestDate.ToString();


        }
        public void Search()
        {
            String Search =txt_search.Text;
            List<RequestDTO> returnlistdata = logic.Search(Search);
            dgv_request.DataSource = returnlistdata;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_request.SelectedRows.Count > 0)
            {
                int row = dgv_request.CurrentCell.RowIndex;

                int reqestid = Convert.ToInt32(dgv_request.Rows[row].Cells["reqid"].Value.ToString());

                RequestItem obj = new RequestItem();
                obj.Show();
                //obj.Setgridreqestid(reqestid);
            }
            else
            {
                MessageBox.Show("Select a item", "Delete Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

           



        }

        private void dgv_request_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectData();
        }

        private void btn_editReqest_Click(object sender, EventArgs e)
        {
            RequestDTO obj = new RequestDTO();

            int row = dgv_request.CurrentCell.RowIndex;

            int reqestid = Convert.ToInt32(dgv_request.Rows[row].Cells["reqid"].Value.ToString());
            obj.department = txt_department.Text;
            obj.idencode = txt_idencode.Text;
            obj.reqdate = Convert.ToDateTime(dtp_reqdate.Text);
            obj.reqpersion = txt_reqpersion.Text;
            obj.reqid = reqestid;

            logic.Edit(obj);

            reqestdata();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dgv_request.SelectedRows.Count > 0)
            {

                int row = dgv_request.CurrentCell.RowIndex;

                int reqestid = Convert.ToInt32(dgv_request.Rows[row].Cells["reqid"].Value.ToString());

                logic.DeleteRequest(reqestid);

                reqestdata();
            }
            else
            {
                MessageBox.Show("Select a item", "Delete Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReqestView obj = new ReqestView();
            obj.Show();
        }
    }
}
