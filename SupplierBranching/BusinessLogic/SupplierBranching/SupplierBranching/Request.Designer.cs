namespace SupplierBranching
{
    partial class Request
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
            this.lbl_idencode = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_reqdate = new System.Windows.Forms.Label();
            this.lbl_reqpersion = new System.Windows.Forms.Label();
            this.txt_idencode = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_reqpersion = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dtp_reqdate = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_idencode
            // 
            this.lbl_idencode.AutoSize = true;
            this.lbl_idencode.Location = new System.Drawing.Point(33, 65);
            this.lbl_idencode.Name = "lbl_idencode";
            this.lbl_idencode.Size = new System.Drawing.Size(95, 13);
            this.lbl_idencode.TabIndex = 0;
            this.lbl_idencode.Text = "Identification Code";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(33, 109);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(62, 13);
            this.lbl_department.TabIndex = 1;
            this.lbl_department.Text = "Department";
            // 
            // lbl_reqdate
            // 
            this.lbl_reqdate.AutoSize = true;
            this.lbl_reqdate.Location = new System.Drawing.Point(33, 155);
            this.lbl_reqdate.Name = "lbl_reqdate";
            this.lbl_reqdate.Size = new System.Drawing.Size(85, 13);
            this.lbl_reqdate.TabIndex = 2;
            this.lbl_reqdate.Text = "Requisition Date";
            // 
            // lbl_reqpersion
            // 
            this.lbl_reqpersion.AutoSize = true;
            this.lbl_reqpersion.Location = new System.Drawing.Point(33, 201);
            this.lbl_reqpersion.Name = "lbl_reqpersion";
            this.lbl_reqpersion.Size = new System.Drawing.Size(85, 13);
            this.lbl_reqpersion.TabIndex = 3;
            this.lbl_reqpersion.Text = "Request Persion";
            // 
            // txt_idencode
            // 
            this.txt_idencode.Location = new System.Drawing.Point(143, 58);
            this.txt_idencode.Name = "txt_idencode";
            this.txt_idencode.Size = new System.Drawing.Size(262, 20);
            this.txt_idencode.TabIndex = 6;
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(143, 102);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(262, 20);
            this.txt_department.TabIndex = 7;
            // 
            // txt_reqpersion
            // 
            this.txt_reqpersion.Location = new System.Drawing.Point(143, 194);
            this.txt_reqpersion.Name = "txt_reqpersion";
            this.txt_reqpersion.Size = new System.Drawing.Size(262, 20);
            this.txt_reqpersion.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(230, 242);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(330, 242);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // dtp_reqdate
            // 
            this.dtp_reqdate.Location = new System.Drawing.Point(143, 149);
            this.dtp_reqdate.Name = "dtp_reqdate";
            this.dtp_reqdate.Size = new System.Drawing.Size(262, 20);
            this.dtp_reqdate.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(354, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 326);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dtp_reqdate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_reqpersion);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_idencode);
            this.Controls.Add(this.lbl_reqpersion);
            this.Controls.Add(this.lbl_reqdate);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_idencode);
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idencode;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_reqdate;
        private System.Windows.Forms.Label lbl_reqpersion;
        private System.Windows.Forms.TextBox txt_idencode;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_reqpersion;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DateTimePicker dtp_reqdate;
        private System.Windows.Forms.Button btn_back;
    }
}