namespace SupplierBranching
{
    partial class ProcumentPlanReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProcumentPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new SupplierBranching.DataSet2();
            this.ProcumentPlanTableAdapter = new SupplierBranching.DataSet2TableAdapters.ProcumentPlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProcumentPlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupplierBranching.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(821, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProcumentPlanBindingSource
            // 
            this.ProcumentPlanBindingSource.DataMember = "ProcumentPlan";
            this.ProcumentPlanBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProcumentPlanTableAdapter
            // 
            this.ProcumentPlanTableAdapter.ClearBeforeFill = true;
            // 
            // ProcumentPlanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 317);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProcumentPlanReport";
            this.Text = "ProcumentPlanReport";
            this.Load += new System.EventHandler(this.ProcumentPlanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProcumentPlanBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.ProcumentPlanTableAdapter ProcumentPlanTableAdapter;
    }
}