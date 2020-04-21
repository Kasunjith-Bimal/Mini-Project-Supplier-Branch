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
    public partial class Procuremnt : Form
    {
        ProcurementLogic plogic = new ProcurementLogic();
        public Procuremnt()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            AddProcuremnt();
            this.Hide();
            ProcurementItem obj = new ProcurementItem();
            obj.Show();
        }

        private void Procuremnt_Load(object sender, EventArgs e)
        {

        }
        private void AddProcuremnt()
        {
            try
            {
                string procuredate = dtp_prodate.Text;
                ProcurementDTO obj = new ProcurementDTO();
                obj.Prodate = Convert.ToDateTime(procuredate);
                plogic.ProcurementAdd(obj);
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ProcumentView window = new ProcumentView();
            this.Hide();
            window.Show();
        }
    }
}
