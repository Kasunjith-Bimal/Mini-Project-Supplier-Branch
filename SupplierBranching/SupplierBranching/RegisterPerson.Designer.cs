namespace SupplierBranching
{
    partial class RegisterPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_identificationCode = new System.Windows.Forms.TextBox();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ReqestPersonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_paperadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identification Code";
            // 
            // txt_identificationCode
            // 
            this.txt_identificationCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_identificationCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_identificationCode.Location = new System.Drawing.Point(226, 37);
            this.txt_identificationCode.Name = "txt_identificationCode";
            this.txt_identificationCode.Size = new System.Drawing.Size(131, 20);
            this.txt_identificationCode.TabIndex = 1;
            this.txt_identificationCode.TextChanged += new System.EventHandler(this.txt_identificationCode_TextChanged);
            this.txt_identificationCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_identificationCode_KeyDown);
            // 
            // txt_post
            // 
            this.txt_post.Location = new System.Drawing.Point(226, 73);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(202, 20);
            this.txt_post.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Post";
            // 
            // txt_ReqestPersonName
            // 
            this.txt_ReqestPersonName.Location = new System.Drawing.Point(226, 121);
            this.txt_ReqestPersonName.Name = "txt_ReqestPersonName";
            this.txt_ReqestPersonName.Size = new System.Drawing.Size(333, 20);
            this.txt_ReqestPersonName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reqest Person Name";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(226, 163);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(202, 20);
            this.txt_username.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(226, 200);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(202, 20);
            this.txt_password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(76, 252);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "add person";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_paperadd
            // 
            this.btn_paperadd.Location = new System.Drawing.Point(157, 252);
            this.btn_paperadd.Name = "btn_paperadd";
            this.btn_paperadd.Size = new System.Drawing.Size(75, 23);
            this.btn_paperadd.TabIndex = 11;
            this.btn_paperadd.Text = "addd";
            this.btn_paperadd.UseVisualStyleBackColor = true;
            this.btn_paperadd.Click += new System.EventHandler(this.btn_paperadd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "addd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_paperadd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ReqestPersonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_identificationCode);
            this.Controls.Add(this.label1);
            this.Name = "RegisterPerson";
            this.Text = "RegisterPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_identificationCode;
        private System.Windows.Forms.TextBox txt_post;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ReqestPersonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_paperadd;
        private System.Windows.Forms.Button button1;
    }
}