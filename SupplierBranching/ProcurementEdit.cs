using BusinessLogic;
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
    public partial class ProcurementEdit : Form
    {
        ProcurementLogic prolog = new ProcurementLogic();
        ProcuremntItemLogic proitem = new ProcuremntItemLogic();
        public ProcurementEdit()
        {
            InitializeComponent();
        }

        private void ProcurementEdit_Load(object sender, EventArgs e)
        {
            ProGridShowui();
            dgv_pro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String pid = null;
            foreach (DataGridViewRow item in dgv_pro.SelectedRows)
            {
                pid = item.Cells["PID"].Value.ToString();
            }
            int pid1 = Convert.ToInt16(pid);
            prolog.ProGridDelete(pid1);
            proitem.DeleteProItem(pid1);
            ProGridShowui();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ProcumentView proview = new ProcumentView();
            this.Hide();
            proview.Show();
        }

        private void btn_edititems_Click(object sender, EventArgs e)
        {
            String pid = null;
            foreach (DataGridViewRow item in dgv_pro.SelectedRows)
            {
                pid = item.Cells["PID"].Value.ToString();
            }
            int pid1 = Convert.ToInt16(pid);
            this.Hide();
            ProcurementItem obj = new ProcurementItem();
            obj.Show();
            obj.ShowGridEdit(pid1);
        }
        public void ProGridShowui()
        {
            dgv_pro.DataSource = prolog.ProGridShow();
        }
    }
}
