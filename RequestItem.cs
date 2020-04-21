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
    public partial class RequestItem : Form
    {
        RequestItemLogic req = new RequestItemLogic();
        int reqid;
        int itemno;
        public RequestItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RequestItem_Load(object sender, EventArgs e)
        {
            AutoComplete();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         AddReqItem();
         ShowGrid();
         ClearFields();
        }

        private void txt_category_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        public void AddReqItem()
        {
            try
            {
                string cname = txt_category.Text;
                int cid = req.getCategoryid(cname);
                reqid = req.GetReqId();
                RequestItemDTO obj = new RequestItemDTO();
                obj.reqcid = cid;
                obj.reqid = reqid;
                obj.itemdes = txt_itemdes.Text;
                obj.itemphoto = txt_itemphoto.Text;
                obj.itemspeci = txt_itemspeci.Text;
                obj.quantity = Convert.ToDecimal(txt_qty.Text);
                obj.estimateprice = Convert.ToDecimal(txt_estimateprice.Text);
                req.AddRequestItem(obj);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void ShowGrid()
        {
            dgv_reqitem.DataSource = req.ShowGrid(reqid);
        }
        public void AutoComplete()
        {
            try
            {
                List<string> listnew = req.GetSource();
                var listn = new AutoCompleteStringCollection();
                listn.AddRange(listnew.ToArray());
                txt_category.AutoCompleteCustomSource = listn;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        public void ClearFields()
        {
            txt_category.Text = "";
            txt_estimateprice.Text = "";
            txt_itemdes.Text = "";
            txt_itemphoto.Text = "";
            txt_itemspeci.Text = "";
            txt_qty.Text = "";
            
        }

        private void dgv_reqitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rindex = e.RowIndex;
            if (rindex >= 0)
            {
                txt_category.Text = dgv_reqitem.Rows[rindex].Cells["requestcategory"].Value.ToString();
                txt_itemdes.Text = dgv_reqitem.Rows[rindex].Cells["itemdes"].Value.ToString();
                txt_itemphoto.Text = dgv_reqitem.Rows[rindex].Cells["itemphoto"].Value.ToString();
                txt_itemspeci.Text = dgv_reqitem.Rows[rindex].Cells["itemspeci"].Value.ToString();
                txt_qty.Text = dgv_reqitem.Rows[rindex].Cells["quantity"].Value.ToString();
                txt_estimateprice.Text = dgv_reqitem.Rows[rindex].Cells["estimateprice"].Value.ToString();
                itemno = Convert.ToInt32(dgv_reqitem.Rows[rindex].Cells["itemid"].Value.ToString());
            }
        }
        public void EditItem()
        {
            RequestItemDTO obj = new RequestItemDTO();
            obj.itemid = itemno;
            obj.itemdes = txt_itemdes.Text;
            obj.itemphoto = txt_itemphoto.Text;
            obj.quantity = Convert.ToDecimal(txt_qty.Text);
            obj.itemspeci = txt_itemspeci.Text;
            obj.estimateprice = Convert.ToDecimal(txt_estimateprice.Text);
            obj.reqcid = req.getCategoryid(txt_category.Text);
            obj.reqid = reqid;
            req.EditItem(obj);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditItem();
            ShowGrid();
            ClearFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
        public void DeleteItem()
        {
            req.DeleteItem(itemno);
            ShowGrid();
            ClearFields();
        }

        private void lbl_itemphoto_Click(object sender, EventArgs e)
        {

        }
    }
}
