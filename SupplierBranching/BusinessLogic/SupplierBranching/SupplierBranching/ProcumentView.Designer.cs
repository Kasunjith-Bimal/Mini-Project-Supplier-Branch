namespace SupplierBranching
{
    partial class ProcumentView
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
            this.btn_addprocumentplan = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_editprocumentplan = new System.Windows.Forms.Button();
            this.btn_deleteprocumentplan = new System.Windows.Forms.Button();
            this.btn_editcategory = new System.Windows.Forms.Button();
            this.btn_deletecategory = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addprocumentplan
            // 
            this.btn_addprocumentplan.Location = new System.Drawing.Point(12, 40);
            this.btn_addprocumentplan.Name = "btn_addprocumentplan";
            this.btn_addprocumentplan.Size = new System.Drawing.Size(108, 96);
            this.btn_addprocumentplan.TabIndex = 0;
            this.btn_addprocumentplan.Text = "Add Procument Plan";
            this.btn_addprocumentplan.UseVisualStyleBackColor = true;
            this.btn_addprocumentplan.Click += new System.EventHandler(this.btn_addprocumentplan_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(354, 40);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(114, 96);
            this.btn_addCategory.TabIndex = 1;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_editprocumentplan
            // 
            this.btn_editprocumentplan.Location = new System.Drawing.Point(126, 12);
            this.btn_editprocumentplan.Name = "btn_editprocumentplan";
            this.btn_editprocumentplan.Size = new System.Drawing.Size(108, 96);
            this.btn_editprocumentplan.TabIndex = 2;
            this.btn_editprocumentplan.Text = "Edit Procument Plan";
            this.btn_editprocumentplan.UseVisualStyleBackColor = true;
            // 
            // btn_deleteprocumentplan
            // 
            this.btn_deleteprocumentplan.Location = new System.Drawing.Point(240, 12);
            this.btn_deleteprocumentplan.Name = "btn_deleteprocumentplan";
            this.btn_deleteprocumentplan.Size = new System.Drawing.Size(108, 96);
            this.btn_deleteprocumentplan.TabIndex = 3;
            this.btn_deleteprocumentplan.Text = "Delete Procument Plan";
            this.btn_deleteprocumentplan.UseVisualStyleBackColor = true;
            // 
            // btn_editcategory
            // 
            this.btn_editcategory.Location = new System.Drawing.Point(474, 12);
            this.btn_editcategory.Name = "btn_editcategory";
            this.btn_editcategory.Size = new System.Drawing.Size(114, 96);
            this.btn_editcategory.TabIndex = 4;
            this.btn_editcategory.Text = "Edit Category";
            this.btn_editcategory.UseVisualStyleBackColor = true;
            // 
            // btn_deletecategory
            // 
            this.btn_deletecategory.Location = new System.Drawing.Point(594, 12);
            this.btn_deletecategory.Name = "btn_deletecategory";
            this.btn_deletecategory.Size = new System.Drawing.Size(114, 96);
            this.btn_deletecategory.TabIndex = 5;
            this.btn_deletecategory.Text = "Delete Category";
            this.btn_deletecategory.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(900, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 49);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ProcumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 315);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deletecategory);
            this.Controls.Add(this.btn_editcategory);
            this.Controls.Add(this.btn_deleteprocumentplan);
            this.Controls.Add(this.btn_editprocumentplan);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.btn_addprocumentplan);
            this.Name = "ProcumentView";
            this.Text = "ProcumentView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addprocumentplan;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_editprocumentplan;
        private System.Windows.Forms.Button btn_deleteprocumentplan;
        private System.Windows.Forms.Button btn_editcategory;
        private System.Windows.Forms.Button btn_deletecategory;
        private System.Windows.Forms.Button btn_back;
    }
}