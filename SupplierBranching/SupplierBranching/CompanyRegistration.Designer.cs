namespace SupplierBranching
{
    partial class CompanyRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_companyregno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Registrationdate = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_company = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_companysearch = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_companyregno
            // 
            this.txt_companyregno.Location = new System.Drawing.Point(180, 31);
            this.txt_companyregno.Name = "txt_companyregno";
            this.txt_companyregno.Size = new System.Drawing.Size(213, 20);
            this.txt_companyregno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company  registration No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone No";
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.Location = new System.Drawing.Point(180, 57);
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(200, 20);
            this.txt_phoneno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(180, 83);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 20);
            this.txt_email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(180, 109);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(213, 20);
            this.txt_address.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Company Name";
            // 
            // txt_companyname
            // 
            this.txt_companyname.Location = new System.Drawing.Point(180, 135);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.Size = new System.Drawing.Size(213, 20);
            this.txt_companyname.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registraion Date ";
            // 
            // dtp_Registrationdate
            // 
            this.dtp_Registrationdate.Location = new System.Drawing.Point(180, 162);
            this.dtp_Registrationdate.Name = "dtp_Registrationdate";
            this.dtp_Registrationdate.Size = new System.Drawing.Size(213, 20);
            this.dtp_Registrationdate.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(34, 232);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 47);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Company registration";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_company
            // 
            this.dgv_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_company.Location = new System.Drawing.Point(409, 57);
            this.dgv_company.Name = "dgv_company";
            this.dgv_company.Size = new System.Drawing.Size(546, 222);
            this.dgv_company.TabIndex = 18;
            this.dgv_company.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_company_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(783, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(172, 25);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "Company Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_companysearch
            // 
            this.txt_companysearch.Location = new System.Drawing.Point(409, 30);
            this.txt_companysearch.Name = "txt_companysearch";
            this.txt_companysearch.Size = new System.Drawing.Size(368, 20);
            this.txt_companysearch.TabIndex = 20;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(247, 232);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 47);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(34, 285);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(133, 47);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(247, 285);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 47);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // CompanyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 402);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_companysearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_company);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_Registrationdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_companyname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phoneno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_companyregno);
            this.Name = "CompanyRegistration";
            this.Text = "CompanyRegistration";
            this.Load += new System.EventHandler(this.CompanyRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_companyregno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Registrationdate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_company;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_companysearch;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
    }
}