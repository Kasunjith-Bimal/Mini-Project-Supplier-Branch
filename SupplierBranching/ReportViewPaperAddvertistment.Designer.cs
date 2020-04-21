namespace SupplierBranching
{
    partial class ReportViewPaperAddvertistment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewPaperAddvertistment));
            this.PaperAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaperAddvertistementReportGenerate = new SupplierBranching.PaperAddvertistementReportGenerate();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaperAddTableAdapter = new SupplierBranching.PaperAddvertistementReportGenerateTableAdapters.PaperAddTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaperAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperAddvertistementReportGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // PaperAddBindingSource
            // 
            this.PaperAddBindingSource.DataMember = "PaperAdd";
            this.PaperAddBindingSource.DataSource = this.PaperAddvertistementReportGenerate;
            // 
            // PaperAddvertistementReportGenerate
            // 
            this.PaperAddvertistementReportGenerate.DataSetName = "PaperAddvertistementReportGenerate";
            this.PaperAddvertistementReportGenerate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReportPaperAddvertistment";
            reportDataSource1.Value = this.PaperAddBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupplierBranching.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(869, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // PaperAddTableAdapter
            // 
            this.PaperAddTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(773, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportViewPaperAddvertistment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewPaperAddvertistment";
            this.Text = "ReportViewPaperAddvertistment";
            this.Load += new System.EventHandler(this.ReportViewPaperAddvertistment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaperAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperAddvertistementReportGenerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PaperAddBindingSource;
        private PaperAddvertistementReportGenerate PaperAddvertistementReportGenerate;
        private PaperAddvertistementReportGenerateTableAdapters.PaperAddTableAdapter PaperAddTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}