namespace SupplierBranching
{
    partial class ReqestView
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_addrequest = new System.Windows.Forms.Button();
            this.btn_requestcat = new System.Windows.Forms.Button();
            this.btn_editreqCat = new System.Windows.Forms.Button();
            this.btn_deletereqcat = new System.Windows.Forms.Button();
            this.btn_editrequest = new System.Windows.Forms.Button();
            this.btn_deleterequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(687, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 44);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_addrequest
            // 
            this.btn_addrequest.Location = new System.Drawing.Point(74, 83);
            this.btn_addrequest.Name = "btn_addrequest";
            this.btn_addrequest.Size = new System.Drawing.Size(75, 64);
            this.btn_addrequest.TabIndex = 14;
            this.btn_addrequest.Text = "Add Reqest ";
            this.btn_addrequest.UseVisualStyleBackColor = true;
            this.btn_addrequest.Click += new System.EventHandler(this.btn_addrequest_Click);
            // 
            // btn_requestcat
            // 
            this.btn_requestcat.Location = new System.Drawing.Point(386, 87);
            this.btn_requestcat.Name = "btn_requestcat";
            this.btn_requestcat.Size = new System.Drawing.Size(75, 64);
            this.btn_requestcat.TabIndex = 16;
            this.btn_requestcat.Text = "Add Reqest Category";
            this.btn_requestcat.UseVisualStyleBackColor = true;
            this.btn_requestcat.Click += new System.EventHandler(this.btn_requestcat_Click);
            // 
            // btn_editreqCat
            // 
            this.btn_editreqCat.Location = new System.Drawing.Point(489, 87);
            this.btn_editreqCat.Name = "btn_editreqCat";
            this.btn_editreqCat.Size = new System.Drawing.Size(75, 64);
            this.btn_editreqCat.TabIndex = 17;
            this.btn_editreqCat.Text = "Edit Requet Category";
            this.btn_editreqCat.UseVisualStyleBackColor = true;
            // 
            // btn_deletereqcat
            // 
            this.btn_deletereqcat.Location = new System.Drawing.Point(597, 87);
            this.btn_deletereqcat.Name = "btn_deletereqcat";
            this.btn_deletereqcat.Size = new System.Drawing.Size(75, 64);
            this.btn_deletereqcat.TabIndex = 18;
            this.btn_deletereqcat.Text = "Delete Requet Category";
            this.btn_deletereqcat.UseVisualStyleBackColor = true;
            // 
            // btn_editrequest
            // 
            this.btn_editrequest.Location = new System.Drawing.Point(174, 83);
            this.btn_editrequest.Name = "btn_editrequest";
            this.btn_editrequest.Size = new System.Drawing.Size(75, 64);
            this.btn_editrequest.TabIndex = 19;
            this.btn_editrequest.Text = "Edit Request";
            this.btn_editrequest.UseVisualStyleBackColor = true;
            // 
            // btn_deleterequest
            // 
            this.btn_deleterequest.Location = new System.Drawing.Point(278, 83);
            this.btn_deleterequest.Name = "btn_deleterequest";
            this.btn_deleterequest.Size = new System.Drawing.Size(75, 64);
            this.btn_deleterequest.TabIndex = 20;
            this.btn_deleterequest.Text = "Delete Reqest";
            this.btn_deleterequest.UseVisualStyleBackColor = true;
            // 
            // ReqestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 275);
            this.Controls.Add(this.btn_deleterequest);
            this.Controls.Add(this.btn_editrequest);
            this.Controls.Add(this.btn_deletereqcat);
            this.Controls.Add(this.btn_editreqCat);
            this.Controls.Add(this.btn_requestcat);
            this.Controls.Add(this.btn_addrequest);
            this.Controls.Add(this.btn_back);
            this.Name = "ReqestView";
            this.Text = "ReqestView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_addrequest;
        private System.Windows.Forms.Button btn_requestcat;
        private System.Windows.Forms.Button btn_editreqCat;
        private System.Windows.Forms.Button btn_deletereqcat;
        private System.Windows.Forms.Button btn_editrequest;
        private System.Windows.Forms.Button btn_deleterequest;
    }
}