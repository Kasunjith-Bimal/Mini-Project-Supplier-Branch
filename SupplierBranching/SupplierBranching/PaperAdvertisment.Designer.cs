namespace SupplierBranching
{
    partial class PaperAdvertisment
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
            this.txt_heading = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_categori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tendername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenderno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_payemntstatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_starttime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_endtime = new System.Windows.Forms.TextBox();
            this.dtp_madedate = new System.Windows.Forms.DateTimePicker();
            this.dtp_registerenddate = new System.Windows.Forms.DateTimePicker();
            this.dtp_shouldresponseDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_registerstartdate = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_papaeradvertistment = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_papaeradvertistment)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_heading
            // 
            this.txt_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_heading.Location = new System.Drawing.Point(207, 102);
            this.txt_heading.Name = "txt_heading";
            this.txt_heading.Size = new System.Drawing.Size(265, 24);
            this.txt_heading.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category name";
            // 
            // txt_categori
            // 
            this.txt_categori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_categori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_categori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categori.Location = new System.Drawing.Point(207, 144);
            this.txt_categori.Name = "txt_categori";
            this.txt_categori.Size = new System.Drawing.Size(265, 24);
            this.txt_categori.TabIndex = 2;
            this.txt_categori.TextChanged += new System.EventHandler(this.txt_categori_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tender Name";
            // 
            // txt_tendername
            // 
            this.txt_tendername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendername.Location = new System.Drawing.Point(207, 187);
            this.txt_tendername.Name = "txt_tendername";
            this.txt_tendername.Size = new System.Drawing.Size(265, 24);
            this.txt_tendername.TabIndex = 4;
            this.txt_tendername.TextChanged += new System.EventHandler(this.txt_tendername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tender No";
            // 
            // txt_tenderno
            // 
            this.txt_tenderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenderno.Location = new System.Drawing.Point(207, 228);
            this.txt_tenderno.Name = "txt_tenderno";
            this.txt_tenderno.Size = new System.Drawing.Size(265, 24);
            this.txt_tenderno.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment Status";
            // 
            // txt_payemntstatus
            // 
            this.txt_payemntstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payemntstatus.Location = new System.Drawing.Point(207, 270);
            this.txt_payemntstatus.Name = "txt_payemntstatus";
            this.txt_payemntstatus.Size = new System.Drawing.Size(265, 24);
            this.txt_payemntstatus.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Shaduld Response Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Made Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(541, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Register End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Register Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Register Start  Time";
            // 
            // txt_starttime
            // 
            this.txt_starttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_starttime.Location = new System.Drawing.Point(734, 238);
            this.txt_starttime.Name = "txt_starttime";
            this.txt_starttime.Size = new System.Drawing.Size(200, 24);
            this.txt_starttime.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(541, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Register End  Time";
            // 
            // txt_endtime
            // 
            this.txt_endtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endtime.Location = new System.Drawing.Point(734, 276);
            this.txt_endtime.Name = "txt_endtime";
            this.txt_endtime.Size = new System.Drawing.Size(200, 24);
            this.txt_endtime.TabIndex = 20;
            this.txt_endtime.TextChanged += new System.EventHandler(this.txt_endtime_TextChanged);
            // 
            // dtp_madedate
            // 
            this.dtp_madedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_madedate.Location = new System.Drawing.Point(734, 158);
            this.dtp_madedate.Name = "dtp_madedate";
            this.dtp_madedate.Size = new System.Drawing.Size(268, 24);
            this.dtp_madedate.TabIndex = 23;
            // 
            // dtp_registerenddate
            // 
            this.dtp_registerenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_registerenddate.Location = new System.Drawing.Point(734, 190);
            this.dtp_registerenddate.Name = "dtp_registerenddate";
            this.dtp_registerenddate.Size = new System.Drawing.Size(268, 24);
            this.dtp_registerenddate.TabIndex = 24;
            // 
            // dtp_shouldresponseDate
            // 
            this.dtp_shouldresponseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_shouldresponseDate.Location = new System.Drawing.Point(734, 129);
            this.dtp_shouldresponseDate.Name = "dtp_shouldresponseDate";
            this.dtp_shouldresponseDate.Size = new System.Drawing.Size(268, 24);
            this.dtp_shouldresponseDate.TabIndex = 25;
            // 
            // dtp_registerstartdate
            // 
            this.dtp_registerstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_registerstartdate.Location = new System.Drawing.Point(734, 96);
            this.dtp_registerstartdate.Name = "dtp_registerstartdate";
            this.dtp_registerstartdate.Size = new System.Drawing.Size(268, 24);
            this.dtp_registerstartdate.TabIndex = 26;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(207, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 40);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_papaeradvertistment
            // 
            this.dgv_papaeradvertistment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_papaeradvertistment.Location = new System.Drawing.Point(63, 401);
            this.dgv_papaeradvertistment.Name = "dgv_papaeradvertistment";
            this.dgv_papaeradvertistment.Size = new System.Drawing.Size(939, 275);
            this.dgv_papaeradvertistment.TabIndex = 28;
            this.dgv_papaeradvertistment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_papaeradvertistment_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(346, 326);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(126, 40);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(513, 326);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 40);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(876, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 40);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PaperAdvertisment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 718);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgv_papaeradvertistment);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_registerstartdate);
            this.Controls.Add(this.dtp_shouldresponseDate);
            this.Controls.Add(this.dtp_registerenddate);
            this.Controls.Add(this.dtp_madedate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_endtime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_starttime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_payemntstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenderno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tendername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_categori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_heading);
            this.Name = "PaperAdvertisment";
            this.Text = "PaperAdvertisment";
            this.Load += new System.EventHandler(this.PaperAdvertisment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_papaeradvertistment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_categori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tendername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenderno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_payemntstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_starttime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_endtime;
        private System.Windows.Forms.DateTimePicker dtp_madedate;
        private System.Windows.Forms.DateTimePicker dtp_registerenddate;
        private System.Windows.Forms.DateTimePicker dtp_shouldresponseDate;
        private System.Windows.Forms.DateTimePicker dtp_registerstartdate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_papaeradvertistment;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
    }
}