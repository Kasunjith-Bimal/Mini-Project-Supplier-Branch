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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestEdit));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_request
            // 
            this.dgv_request.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_request.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_request.Location = new System.Drawing.Point(54, 61);
            this.dgv_request.Name = "dgv_request";
            this.dgv_request.Size = new System.Drawing.Size(392, 217);
            this.dgv_request.TabIndex = 0;
            this.dgv_request.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_request_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(54, 22);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(271, 20);
            this.txt_search.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(371, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(54, 303);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(193, 37);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit Item";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(253, 303);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(193, 37);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dtp_reqdate
            // 
            this.dtp_reqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_reqdate.Location = new System.Drawing.Point(638, 167);
            this.dtp_reqdate.Name = "dtp_reqdate";
            this.dtp_reqdate.Size = new System.Drawing.Size(302, 26);
            this.dtp_reqdate.TabIndex = 22;
            // 
            // txt_reqpersion
            // 
            this.txt_reqpersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reqpersion.Location = new System.Drawing.Point(638, 212);
            this.txt_reqpersion.Name = "txt_reqpersion";
            this.txt_reqpersion.Size = new System.Drawing.Size(302, 26);
            this.txt_reqpersion.TabIndex = 21;
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(638, 120);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(302, 26);
            this.txt_department.TabIndex = 20;
            // 
            // txt_idencode
            // 
            this.txt_idencode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_idencode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idencode.Location = new System.Drawing.Point(638, 76);
            this.txt_idencode.Name = "txt_idencode";
            this.txt_idencode.Size = new System.Drawing.Size(302, 26);
            this.txt_idencode.TabIndex = 19;
            // 
            // lbl_reqpersion
            // 
            this.lbl_reqpersion.AutoSize = true;
            this.lbl_reqpersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqpersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_reqpersion.Image = ((System.Drawing.Image)(resources.GetObject("lbl_reqpersion.Image")));
            this.lbl_reqpersion.Location = new System.Drawing.Point(456, 218);
            this.lbl_reqpersion.Name = "lbl_reqpersion";
            this.lbl_reqpersion.Size = new System.Drawing.Size(127, 20);
            this.lbl_reqpersion.TabIndex = 18;
            this.lbl_reqpersion.Text = "Request Persion";
            // 
            // lbl_reqdate
            // 
            this.lbl_reqdate.AutoSize = true;
            this.lbl_reqdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_reqdate.Image = ((System.Drawing.Image)(resources.GetObject("lbl_reqdate.Image")));
            this.lbl_reqdate.Location = new System.Drawing.Point(456, 172);
            this.lbl_reqdate.Name = "lbl_reqdate";
            this.lbl_reqdate.Size = new System.Drawing.Size(127, 20);
            this.lbl_reqdate.TabIndex = 17;
            this.lbl_reqdate.Text = "Requisition Date";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_department.Image = ((System.Drawing.Image)(resources.GetObject("lbl_department.Image")));
            this.lbl_department.Location = new System.Drawing.Point(456, 126);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(94, 20);
            this.lbl_department.TabIndex = 16;
            this.lbl_department.Text = "Department";
            // 
            // lbl_idencode
            // 
            this.lbl_idencode.AutoSize = true;
            this.lbl_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idencode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_idencode.Image = ((System.Drawing.Image)(resources.GetObject("lbl_idencode.Image")));
            this.lbl_idencode.Location = new System.Drawing.Point(456, 82);
            this.lbl_idencode.Name = "lbl_idencode";
            this.lbl_idencode.Size = new System.Drawing.Size(142, 20);
            this.lbl_idencode.TabIndex = 15;
            this.lbl_idencode.Text = "Identification Code";
            // 
            // btn_editReqest
            // 
            this.btn_editReqest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editReqest.Image = ((System.Drawing.Image)(resources.GetObject("btn_editReqest.Image")));
            this.btn_editReqest.Location = new System.Drawing.Point(726, 285);
            this.btn_editReqest.Name = "btn_editReqest";
            this.btn_editReqest.Size = new System.Drawing.Size(193, 37);
            this.btn_editReqest.TabIndex = 23;
            this.btn_editReqest.Text = "Edit";
            this.btn_editReqest.UseVisualStyleBackColor = true;
            this.btn_editReqest.Click += new System.EventHandler(this.btn_editReqest_Click);
            // 
            // btn_back
            // 
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(824, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(116, 45);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // RequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1039, 528);
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
    }
}