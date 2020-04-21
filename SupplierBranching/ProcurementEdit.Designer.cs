namespace SupplierBranching
{
    partial class ProcurementEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurementEdit));
            this.dgv_pro = new System.Windows.Forms.DataGridView();
            this.btn_edititems = new System.Windows.Forms.Button();
            this.btn_deletepro = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pro
            // 
            this.dgv_pro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pro.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_pro.Location = new System.Drawing.Point(45, 66);
            this.dgv_pro.Name = "dgv_pro";
            this.dgv_pro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pro.Size = new System.Drawing.Size(446, 206);
            this.dgv_pro.TabIndex = 0;
            // 
            // btn_edititems
            // 
            this.btn_edititems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edititems.Location = new System.Drawing.Point(98, 307);
            this.btn_edititems.Name = "btn_edititems";
            this.btn_edititems.Size = new System.Drawing.Size(169, 52);
            this.btn_edititems.TabIndex = 1;
            this.btn_edititems.Text = "Edit Pro Items";
            this.btn_edititems.UseVisualStyleBackColor = true;
            this.btn_edititems.Click += new System.EventHandler(this.btn_edititems_Click);
            // 
            // btn_deletepro
            // 
            this.btn_deletepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletepro.Location = new System.Drawing.Point(325, 307);
            this.btn_deletepro.Name = "btn_deletepro";
            this.btn_deletepro.Size = new System.Drawing.Size(166, 52);
            this.btn_deletepro.TabIndex = 2;
            this.btn_deletepro.Text = "Delete Pro";
            this.btn_deletepro.UseVisualStyleBackColor = true;
            this.btn_deletepro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(362, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(129, 30);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ProcurementEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 397);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deletepro);
            this.Controls.Add(this.btn_edititems);
            this.Controls.Add(this.dgv_pro);
            this.Name = "ProcurementEdit";
            this.Text = "ProcurementEdit";
            this.Load += new System.EventHandler(this.ProcurementEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pro;
        private System.Windows.Forms.Button btn_edititems;
        private System.Windows.Forms.Button btn_deletepro;
        private System.Windows.Forms.Button btn_back;
    }
}