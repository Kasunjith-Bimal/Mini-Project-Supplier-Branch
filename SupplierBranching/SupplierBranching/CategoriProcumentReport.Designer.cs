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
            this.ProcumentPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new SupplierBranching.DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_categoriname = new System.Windows.Forms.TextBox();
            this.btn_showcategori = new System.Windows.Forms.Button();
            this.ProcumentPlanTableAdapter = new SupplierBranching.DataSet3TableAdapters.ProcumentPlanTableAdapter();
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
            this.reportViewer1.Location = new System.Drawing.Point(39, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(764, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_categoriname
            // 
            this.txt_categoriname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_categoriname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_categoriname.Location = new System.Drawing.Point(171, 14);
            this.txt_categoriname.Name = "txt_categoriname";
            this.txt_categoriname.Size = new System.Drawing.Size(190, 20);
            this.txt_categoriname.TabIndex = 1;
            this.txt_categoriname.TextChanged += new System.EventHandler(this.txt_categoriname_TextChanged);
            // 
            // btn_showcategori
            // 
            this.btn_showcategori.Location = new System.Drawing.Point(386, 12);
            this.btn_showcategori.Name = "btn_showcategori";
            this.btn_showcategori.Size = new System.Drawing.Size(75, 23);
            this.btn_showcategori.TabIndex = 2;
            this.btn_showcategori.Text = "Show";
            this.btn_showcategori.UseVisualStyleBackColor = true;
            this.btn_showcategori.Click += new System.EventHandler(this.btn_showcategori_Click);
            // 
            // ProcumentPlanTableAdapter
            // 
            this.ProcumentPlanTableAdapter.ClearBeforeFill = true;
            // 
            // CategoriProcumentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 298);
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
    }
}