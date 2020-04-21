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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_idencode
            // 
            this.lbl_idencode.AutoSize = true;
            this.lbl_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idencode.Location = new System.Drawing.Point(87, 142);
            this.lbl_idencode.Name = "lbl_idencode";
            this.lbl_idencode.Size = new System.Drawing.Size(142, 20);
            this.lbl_idencode.TabIndex = 0;
            this.lbl_idencode.Text = "Identification Code";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(87, 186);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(94, 20);
            this.lbl_department.TabIndex = 1;
            this.lbl_department.Text = "Department";
            // 
            // lbl_reqdate
            // 
            this.lbl_reqdate.AutoSize = true;
            this.lbl_reqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqdate.Location = new System.Drawing.Point(87, 232);
            this.lbl_reqdate.Name = "lbl_reqdate";
            this.lbl_reqdate.Size = new System.Drawing.Size(127, 20);
            this.lbl_reqdate.TabIndex = 2;
            this.lbl_reqdate.Text = "Requisition Date";
            // 
            // lbl_reqpersion
            // 
            this.lbl_reqpersion.AutoSize = true;
            this.lbl_reqpersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqpersion.Location = new System.Drawing.Point(87, 278);
            this.lbl_reqpersion.Name = "lbl_reqpersion";
            this.lbl_reqpersion.Size = new System.Drawing.Size(127, 20);
            this.lbl_reqpersion.TabIndex = 3;
            this.lbl_reqpersion.Text = "Request Persion";
            // 
            // txt_idencode
            // 
            this.txt_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idencode.Location = new System.Drawing.Point(269, 136);
            this.txt_idencode.Name = "txt_idencode";
            this.txt_idencode.Size = new System.Drawing.Size(389, 26);
            this.txt_idencode.TabIndex = 6;
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(269, 180);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(389, 26);
            this.txt_department.TabIndex = 7;
            // 
            // txt_reqpersion
            // 
            this.txt_reqpersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reqpersion.Location = new System.Drawing.Point(269, 272);
            this.txt_reqpersion.Name = "txt_reqpersion";
            this.txt_reqpersion.Size = new System.Drawing.Size(389, 26);
            this.txt_reqpersion.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(409, 319);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 27);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(537, 319);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(121, 27);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // dtp_reqdate
            // 
            this.dtp_reqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_reqdate.Location = new System.Drawing.Point(269, 227);
            this.dtp_reqdate.Name = "dtp_reqdate";
            this.dtp_reqdate.Size = new System.Drawing.Size(389, 26);
            this.dtp_reqdate.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(63, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 317);
            this.panel1.TabIndex = 15;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(474, 26);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 27);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(799, 436);
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
            this.Controls.Add(this.panel1);
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
    }
}