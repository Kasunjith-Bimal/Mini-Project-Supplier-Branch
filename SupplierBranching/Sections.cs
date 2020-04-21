﻿using BusinessLogic;
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
    public partial class Sections : Form
    {
        
        SectionLogic logic = new SectionLogic();
        public Sections()
        {
            InitializeComponent();
        }
        public void SectionList()
        {
            List<SectionDTO> Returnlist = logic.SectonDatalistLogic();
            dgv_section.DataSource = Returnlist;
            dgv_section.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }


        public void SelectData()
        {
            int row = dgv_section.CurrentCell.RowIndex;

            int id = Convert.ToInt32(dgv_section.Rows[row].Cells["SectionId"].Value.ToString());
            String Sectionname = dgv_section.Rows[row].Cells["SectionName"].Value.ToString();
            String identificationname = dgv_section.Rows[row].Cells["IdentificationCode"].Value.ToString();


            txt_identificationCode.Text = identificationname;
            txt_sectionName.Text = Sectionname;


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_identificationCode.Text != "" && txt_sectionName.Text != "")
            {


                try
                {
                    String SectionName = txt_sectionName.Text;
                    String IdentificationCode = txt_identificationCode.Text;

                    SectionDTO obj = new SectionDTO();

                    obj.IdentificationCode = IdentificationCode;
                    obj.SectionName = SectionName;

                    logic.addSection(obj);

                    SectionList();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Sections_Load(object sender, EventArgs e)
        {
            SectionList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_section.SelectedRows.Count > 0)
            {
                int row = dgv_section.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dgv_section.Rows[row].Cells["SectionId"].Value.ToString());

                logic.Deletelogic(id);

                SectionList();
            }
            else
            {
                MessageBox.Show("Select a item", "Delete Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgv_section_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_identificationCode.Text != "" && txt_sectionName.Text != "")
            {

                int row = dgv_section.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dgv_section.Rows[row].Cells["SectionId"].Value.ToString());

                String SectionName = txt_sectionName.Text;
                String IdenticicationCode = txt_identificationCode.Text;


                SectionDTO obj = new SectionDTO();

                obj.SectionId = id;
                obj.IdentificationCode = IdenticicationCode;
                obj.SectionName = SectionName;

                logic.EditLogic(obj);

                SectionList();
                txt_identificationCode.Text = "";
                txt_sectionName.Text = "";
            }
            else
            {
                MessageBox.Show("Field Missing", "Field Missing",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgv_section_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminView obj = new AdminView();
            this.Hide();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
    }
}