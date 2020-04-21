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
        public RequestItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RequestItem_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         string cname =  txt_category.Text;
         int cid = req.getCategoryid(cname);
         int reqid = req.GetReqId();
        

        }

        private void txt_category_TextChanged(object sender, EventArgs e)
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
        public void AddReqItem()
        {
            try
            {
                string cname = txt_category.Text;
                int cid = req.getCategoryid(cname);
                int reqid = req.GetReqId();
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
        
    }
}
