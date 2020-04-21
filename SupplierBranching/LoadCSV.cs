using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierBranching
{
    public partial class LoadCSV : Form
    {
        LoadCSVLogic clog = new LoadCSVLogic();
        ProcurementCategoryLogic procat = new ProcurementCategoryLogic();
        List<string[]> rows;
        int Pid;
        public LoadCSV()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                rows = File.ReadAllLines(path).Select(x => x.Split(',')).ToList();
                List<CategoryProcuremntDTO> clist = new List<CategoryProcuremntDTO>();
                foreach (var item in rows)
                {
                    CategoryProcuremntDTO obj = new CategoryProcuremntDTO();
                    obj.CategoryName = item[0];
                    clist.Add(obj);
                }
                clog.AddtoProCategory(clist);
                MessageBox.Show("Categories Loded Successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                rows = File.ReadAllLines(path).Select(x => x.Split(',')).ToList();
                DataTable dt = new DataTable();


                dt.Columns.Add("SheduleDate");
                dt.Columns.Add("Remarks");
                dt.Columns.Add("Qty");
                dt.Columns.Add("EstimatedUnitPrice");
                dt.Columns.Add("EstimatetedTotalPrice");
                dt.Columns.Add("CrntofProstats");
                dt.Columns.Add("LevelOfAuthority");
                dt.Columns.Add("IdentificationCode");
                dt.Columns.Add("Cname");
                dt.Columns.Add("ProcumentMethod");
                dt.Columns.Add("SourceOfFunding");
                dt.Columns.Add("PriorityStatus");
                dt.Columns.Add("ItemDescription");
                for (int i = 1; i < rows.Count; i++)
                {
                    dt.Rows.Add(rows[i]);
                }

                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ProcurementItemDTO> list = new List<ProcurementItemDTO>();
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ProcurementItemDTO obj = new ProcurementItemDTO();
                obj.Pid = Pid;
                obj.ScheduleDate = Convert.ToDateTime(dataGridView1.Rows[i].Cells["SheduleDate"].Value.ToString());
                obj.Remarks = dataGridView1.Rows[i].Cells["Remarks"].Value.ToString();
                obj.Qty = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Qty"].Value.ToString());
                obj.EstimatedUnitPrice = Convert.ToDecimal(dataGridView1.Rows[i].Cells["EstimatedUnitPrice"].Value.ToString());
                obj.EstimatetedTotalPrice = Convert.ToDecimal(dataGridView1.Rows[i].Cells["EstimatetedTotalPrice"].Value.ToString());
                obj.CurrentStatusofProcument = dataGridView1.Rows[i].Cells["CrntofProstats"].Value.ToString();
                obj.LevelOfAuthority = dataGridView1.Rows[i].Cells["LevelOfAuthority"].Value.ToString();
                obj.IdentificationCode = dataGridView1.Rows[i].Cells["IdentificationCode"].Value.ToString();
                obj.Cid = procat.getCategoryid(dataGridView1.Rows[i].Cells["Cname"].Value.ToString());
                obj.ProcumentMethod = dataGridView1.Rows[i].Cells["ProcumentMethod"].Value.ToString();
                obj.SourceOfFunding = dataGridView1.Rows[i].Cells["SourceOfFunding"].Value.ToString();
                obj.CurrentStatusofProcument = dataGridView1.Rows[i].Cells["CrntofProstats"].Value.ToString();
                obj.PriorityStatus = dataGridView1.Rows[i].Cells["PriorityStatus"].Value.ToString();
                obj.ItemDescription = dataGridView1.Rows[i].Cells["ItemDescription"].Value.ToString();

                list.Add(obj);
            }
            clog.AddtoPro(list);
            MessageBox.Show("Items Added Successfully!");
        }

        private void LoadCSV_Load(object sender, EventArgs e)
        {

        }
        public void GetProId(int pid)
        {
            Pid = pid;
        }
    }
}
