namespace SupplierBranching
{
    partial class Sections
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
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sectionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_identificationCode = new System.Windows.Forms.TextBox();
            this.dgv_section = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_section)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(59, 247);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(232, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add Section";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section Name";
            // 
            // txt_sectionName
            // 
            this.txt_sectionName.Location = new System.Drawing.Point(191, 111);
            this.txt_sectionName.Name = "txt_sectionName";
            this.txt_sectionName.Size = new System.Drawing.Size(100, 20);
            this.txt_sectionName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identification Code";
            // 
            // txt_identificationCode
            // 
            this.txt_identificationCode.Location = new System.Drawing.Point(191, 165);
            this.txt_identificationCode.Name = "txt_identificationCode";
            this.txt_identificationCode.Size = new System.Drawing.Size(100, 20);
            this.txt_identificationCode.TabIndex = 4;
            // 
            // dgv_section
            // 
            this.dgv_section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_section.Location = new System.Drawing.Point(363, 78);
            this.dgv_section.Name = "dgv_section";
            this.dgv_section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_section.Size = new System.Drawing.Size(495, 152);
            this.dgv_section.TabIndex = 5;
            this.dgv_section.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_section_CellClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(363, 247);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 30);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete Section";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(753, 247);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 30);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit Section";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 329);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_section);
            this.Controls.Add(this.txt_identificationCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sectionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "Sections";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.Sections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_section)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sectionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_identificationCode;
        private System.Windows.Forms.DataGridView dgv_section;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}