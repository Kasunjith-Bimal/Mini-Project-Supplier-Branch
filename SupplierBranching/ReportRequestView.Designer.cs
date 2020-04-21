namespace SupplierBranching
{
    partial class ReportRequestView
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
            this.RequestPaperAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet4 = new SupplierBranching.DataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RequestPaperAddTableAdapter = new SupplierBranching.DataSet4TableAdapters.RequestPaperAddTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RequestPaperAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestPaperAddBindingSource
            // 
            this.RequestPaperAddBindingSource.DataMember = "RequestPaperAdd";
            this.RequestPaperAddBindingSource.DataSource = this.DataSet4;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RequestPaperAddBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupplierBranching.Report16.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1324, 642);
            this.reportViewer1.TabIndex = 0;
            // 
            // RequestPaperAddTableAdapter
            // 
            this.RequestPaperAddTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.Location = new System.Drawing.Point(1267, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ReportRequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportRequestView";
            this.Text = "ReportRequestView";
            this.Load += new System.EventHandler(this.ReportRequestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestPaperAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RequestPaperAddBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.RequestPaperAddTableAdapter RequestPaperAddTableAdapter;
        private System.Windows.Forms.Button btn_back;
    }
}