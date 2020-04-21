namespace SupplierBranching
{
    partial class SectionProcumentPlanReoprt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionProcumentPlanReoprt));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProcumentPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SectionProcumentReport = new SupplierBranching.SectionProcumentReport();
            this.txt_sectionname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_selectprocument = new System.Windows.Forms.ComboBox();
            this.btn_procumentsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProcumentPlanTableAdapter = new SupplierBranching.SectionProcumentReportTableAdapters.ProcumentPlanTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionProcumentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcumentPlanBindingSource
            // 
            this.ProcumentPlanBindingSource.DataMember = "ProcumentPlan";
            this.ProcumentPlanBindingSource.DataSource = this.SectionProcumentReport;
            // 
            // SectionProcumentReport
            // 
            this.SectionProcumentReport.DataSetName = "SectionProcumentReport";
            this.SectionProcumentReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_sectionname
            // 
            this.txt_sectionname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_sectionname.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sectionname.Location = new System.Drawing.Point(276, 156);
            this.txt_sectionname.Name = "txt_sectionname";
            this.txt_sectionname.Size = new System.Drawing.Size(347, 30);
            this.txt_sectionname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Procument";
            // 
            // cmb_selectprocument
            // 
            this.cmb_selectprocument.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selectprocument.FormattingEnabled = true;
            this.cmb_selectprocument.Location = new System.Drawing.Point(276, 106);
            this.cmb_selectprocument.Name = "cmb_selectprocument";
            this.cmb_selectprocument.Size = new System.Drawing.Size(347, 34);
            this.cmb_selectprocument.TabIndex = 6;
            // 
            // btn_procumentsearch
            // 
            this.btn_procumentsearch.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procumentsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_procumentsearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_procumentsearch.Image")));
            this.btn_procumentsearch.Location = new System.Drawing.Point(701, 125);
            this.btn_procumentsearch.Name = "btn_procumentsearch";
            this.btn_procumentsearch.Size = new System.Drawing.Size(159, 51);
            this.btn_procumentsearch.TabIndex = 5;
            this.btn_procumentsearch.Text = "Search Report";
            this.btn_procumentsearch.UseVisualStyleBackColor = true;
            this.btn_procumentsearch.Click += new System.EventHandler(this.btn_procumentsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(48, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Section";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProcumentPlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupplierBranching.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(41, 209);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1275, 510);
            this.reportViewer1.TabIndex = 9;
            // 
            // ProcumentPlanTableAdapter
            // 
            this.ProcumentPlanTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(48, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Section Procument Plan Report";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(1157, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(159, 51);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SectionProcumentPlanReoprt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_selectprocument);
            this.Controls.Add(this.btn_procumentsearch);
            this.Controls.Add(this.txt_sectionname);
            this.Name = "SectionProcumentPlanReoprt";
            this.Text = "SectionProcumentPlanReoprt";
            this.Load += new System.EventHandler(this.SectionProcumentPlanReoprt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionProcumentReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sectionname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_selectprocument;
        private System.Windows.Forms.Button btn_procumentsearch;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProcumentPlanBindingSource;
        private SectionProcumentReport SectionProcumentReport;
        private SectionProcumentReportTableAdapters.ProcumentPlanTableAdapter ProcumentPlanTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
    }
}