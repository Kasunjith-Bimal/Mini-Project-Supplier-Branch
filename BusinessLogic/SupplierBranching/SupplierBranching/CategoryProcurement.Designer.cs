namespace SupplierBranching
{
    partial class CategoryProcurement
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
            this.lbl_category = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(48, 42);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category ";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(116, 73);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(116, 35);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(196, 20);
            this.txt_category.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(284, 73);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CategoryProcurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 120);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_category);
            this.Name = "CategoryProcurement";
            this.Text = "CategoryProcurement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Button btn_back;
    }
}