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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcumentPlanReport));
            this.ProcumentPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new SupplierBranching.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProcumentPlanTableAdapter = new SupplierBranching.DataSet2TableAdapters.ProcumentPlanTableAdapter();
            this.btn_procument = new System.Windows.Forms.Button();
            this.cmb_selectprocument = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProcumentPlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupplierBranching.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 193);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(863, 528);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProcumentPlanTableAdapter
            // 
            this.ProcumentPlanTableAdapter.ClearBeforeFill = true;
            // 
            // btn_procument
            // 
            this.btn_procument.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_procument.BackgroundImage")));
            this.btn_procument.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_procument.Location = new System.Drawing.Point(480, 117);
            this.btn_procument.Name = "btn_procument";
            this.btn_procument.Size = new System.Drawing.Size(159, 41);
            this.btn_procument.TabIndex = 2;
            this.btn_procument.Text = "Search Report";
            this.btn_procument.UseVisualStyleBackColor = true;
            this.btn_procument.Click += new System.EventHandler(this.btn_procument_Click);
            // 
            // cmb_selectprocument
            // 
            this.cmb_selectprocument.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selectprocument.FormattingEnabled = true;
            this.cmb_selectprocument.Location = new System.Drawing.Point(214, 117);
            this.cmb_selectprocument.Name = "cmb_selectprocument";
            this.cmb_selectprocument.Size = new System.Drawing.Size(245, 36);
            this.cmb_selectprocument.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(21, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Procument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Procument Plan Report";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(716, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(159, 41);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ProcumentPlanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 733);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_selectprocument);
            this.Controls.Add(this.btn_procument);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProcumentPlanReport";
            this.Text = "ProcumentPlanReport";
            this.Load += new System.EventHandler(this.ProcumentPlanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcumentPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProcumentPlanBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.ProcumentPlanTableAdapter ProcumentPlanTableAdapter;
        private System.Windows.Forms.Button btn_procument;
        private System.Windows.Forms.ComboBox cmb_selectprocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}