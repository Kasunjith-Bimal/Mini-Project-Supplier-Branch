namespace SupplierBranching
{
    partial class CategoriProcumentReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriProcumentReport));
            this.ProcumentPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new SupplierBranching.DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_categoriname = new System.Windows.Forms.TextBox();
            this.btn_showcategori = new System.Windows.Forms.Button();
            this.ProcumentPlanTableAdapter = new SupplierBranching.DataSet3TableAdapters.ProcumentPlanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcumentPlanBindingSource
            // 
            this.ProcumentPlanBindingSource.DataMember = "ProcumentPlan";
            this.ProcumentPlanBindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProcumentPlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupplierBranching.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(64, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(982, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_categoriname
            // 
            this.txt_categoriname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_categoriname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_categoriname.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriname.Location = new System.Drawing.Point(71, 92);
            this.txt_categoriname.Name = "txt_categoriname";
            this.txt_categoriname.Size = new System.Drawing.Size(310, 36);
            this.txt_categoriname.TabIndex = 1;
            this.txt_categoriname.TextChanged += new System.EventHandler(this.txt_categoriname_TextChanged);
            // 
            // btn_showcategori
            // 
            this.btn_showcategori.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showcategori.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_showcategori.Image = ((System.Drawing.Image)(resources.GetObject("btn_showcategori.Image")));
            this.btn_showcategori.Location = new System.Drawing.Point(418, 90);
            this.btn_showcategori.Name = "btn_showcategori";
            this.btn_showcategori.Size = new System.Drawing.Size(153, 38);
            this.btn_showcategori.TabIndex = 2;
            this.btn_showcategori.Text = "Show";
            this.btn_showcategori.UseVisualStyleBackColor = true;
            this.btn_showcategori.Click += new System.EventHandler(this.btn_showcategori_Click);
            // 
            // ProcumentPlanTableAdapter
            // 
            this.ProcumentPlanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Procument Plan Report";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(954, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoriProcumentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showcategori);
            this.Controls.Add(this.txt_categoriname);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CategoriProcumentReport";
            this.Text = "CategoriProcumentReport";
            this.Load += new System.EventHandler(this.CategoriProcumentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txt_categoriname;
        private System.Windows.Forms.Button btn_showcategori;
        private System.Windows.Forms.BindingSource ProcumentPlanBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.ProcumentPlanTableAdapter ProcumentPlanTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}