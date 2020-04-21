namespace SupplierBranching
{
    partial class RequestEdit
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
            this.dgv_request = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dtp_reqdate = new System.Windows.Forms.DateTimePicker();
            this.txt_reqpersion = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_idencode = new System.Windows.Forms.TextBox();
            this.lbl_reqpersion = new System.Windows.Forms.Label();
            this.lbl_reqdate = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_idencode = new System.Windows.Forms.Label();
            this.btn_editReqest = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_request
            // 
            this.dgv_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_request.Location = new System.Drawing.Point(548, 134);
            this.dgv_request.Name = "dgv_request";
            this.dgv_request.Size = new System.Drawing.Size(563, 345);
            this.dgv_request.TabIndex = 0;
            this.dgv_request.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_request_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(315, 39);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(271, 20);
            this.txt_search.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(614, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(752, 514);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(149, 37);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit Item";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(393, 336);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 37);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dtp_reqdate
            // 
            this.dtp_reqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_reqdate.Location = new System.Drawing.Point(206, 225);
            this.dtp_reqdate.Name = "dtp_reqdate";
            this.dtp_reqdate.Size = new System.Drawing.Size(302, 26);
            this.dtp_reqdate.TabIndex = 22;
            // 
            // txt_reqpersion
            // 
            this.txt_reqpersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reqpersion.Location = new System.Drawing.Point(206, 270);
            this.txt_reqpersion.Name = "txt_reqpersion";
            this.txt_reqpersion.Size = new System.Drawing.Size(302, 26);
            this.txt_reqpersion.TabIndex = 21;
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(206, 178);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(302, 26);
            this.txt_department.TabIndex = 20;
            // 
            // txt_idencode
            // 
            this.txt_idencode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_idencode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idencode.Location = new System.Drawing.Point(206, 134);
            this.txt_idencode.Name = "txt_idencode";
            this.txt_idencode.Size = new System.Drawing.Size(302, 26);
            this.txt_idencode.TabIndex = 19;
            // 
            // lbl_reqpersion
            // 
            this.lbl_reqpersion.AutoSize = true;
            this.lbl_reqpersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqpersion.Location = new System.Drawing.Point(24, 276);
            this.lbl_reqpersion.Name = "lbl_reqpersion";
            this.lbl_reqpersion.Size = new System.Drawing.Size(127, 20);
            this.lbl_reqpersion.TabIndex = 18;
            this.lbl_reqpersion.Text = "Request Persion";
            // 
            // lbl_reqdate
            // 
            this.lbl_reqdate.AutoSize = true;
            this.lbl_reqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqdate.Location = new System.Drawing.Point(24, 230);
            this.lbl_reqdate.Name = "lbl_reqdate";
            this.lbl_reqdate.Size = new System.Drawing.Size(127, 20);
            this.lbl_reqdate.TabIndex = 17;
            this.lbl_reqdate.Text = "Requisition Date";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(24, 228);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(94, 20);
            this.lbl_department.TabIndex = 16;
            this.lbl_department.Text = "Department";
            // 
            // lbl_idencode
            // 
            this.lbl_idencode.AutoSize = true;
            this.lbl_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idencode.Location = new System.Drawing.Point(24, 140);
            this.lbl_idencode.Name = "lbl_idencode";
            this.lbl_idencode.Size = new System.Drawing.Size(142, 20);
            this.lbl_idencode.TabIndex = 15;
            this.lbl_idencode.Text = "Identification Code";
            // 
            // btn_editReqest
            // 
            this.btn_editReqest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editReqest.Location = new System.Drawing.Point(259, 336);
            this.btn_editReqest.Name = "btn_editReqest";
            this.btn_editReqest.Size = new System.Drawing.Size(113, 37);
            this.btn_editReqest.TabIndex = 23;
            this.btn_editReqest.Text = "Edit";
            this.btn_editReqest.UseVisualStyleBackColor = true;
            this.btn_editReqest.Click += new System.EventHandler(this.btn_editReqest_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(942, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(169, 37);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Department";
            // 
            // RequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_editReqest);
            this.Controls.Add(this.dtp_reqdate);
            this.Controls.Add(this.txt_reqpersion);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_idencode);
            this.Controls.Add(this.lbl_reqpersion);
            this.Controls.Add(this.lbl_reqdate);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_idencode);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_request);
            this.Name = "RequestEdit";
            this.Text = "RequestEdit";
            this.Load += new System.EventHandler(this.RequestEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_request;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DateTimePicker dtp_reqdate;
        private System.Windows.Forms.TextBox txt_reqpersion;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_idencode;
        private System.Windows.Forms.Label lbl_reqpersion;
        private System.Windows.Forms.Label lbl_reqdate;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_idencode;
        private System.Windows.Forms.Button btn_editReqest;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
    }
}