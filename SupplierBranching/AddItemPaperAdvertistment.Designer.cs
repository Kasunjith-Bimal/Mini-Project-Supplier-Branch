namespace SupplierBranching
{
    partial class AddItemPaperAdvertistment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemPaperAdvertistment));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_procumentPlan = new System.Windows.Forms.DataGridView();
            this.txt_itemdescription = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_paperadd = new System.Windows.Forms.DataGridView();
            this.btn_additemtopaperaddvertistment = new System.Windows.Forms.Button();
            this.btn_craeateaddvertistment = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_procument = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bavk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procumentPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paperadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.Location = new System.Drawing.Point(290, 115);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(226, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Location = new System.Drawing.Point(539, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 36);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_procumentPlan
            // 
            this.dgv_procumentPlan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_procumentPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_procumentPlan.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_procumentPlan.Location = new System.Drawing.Point(54, 165);
            this.dgv_procumentPlan.Name = "dgv_procumentPlan";
            this.dgv_procumentPlan.Size = new System.Drawing.Size(1270, 195);
            this.dgv_procumentPlan.TabIndex = 2;
            this.dgv_procumentPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_procumentPlan_CellClick);
            this.dgv_procumentPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_procumentPlan_CellContentClick);
            // 
            // txt_itemdescription
            // 
            this.txt_itemdescription.Location = new System.Drawing.Point(176, 392);
            this.txt_itemdescription.Name = "txt_itemdescription";
            this.txt_itemdescription.Size = new System.Drawing.Size(250, 20);
            this.txt_itemdescription.TabIndex = 3;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(520, 393);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(190, 20);
            this.txt_quantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(437, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(51, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Description";
            // 
            // dgv_paperadd
            // 
            this.dgv_paperadd.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_paperadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paperadd.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_paperadd.Location = new System.Drawing.Point(54, 448);
            this.dgv_paperadd.Name = "dgv_paperadd";
            this.dgv_paperadd.Size = new System.Drawing.Size(1270, 195);
            this.dgv_paperadd.TabIndex = 7;
            this.dgv_paperadd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_paperadd_CellContentClick);
            // 
            // btn_additemtopaperaddvertistment
            // 
            this.btn_additemtopaperaddvertistment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_additemtopaperaddvertistment.BackgroundImage")));
            this.btn_additemtopaperaddvertistment.Font = new System.Drawing.Font("Minion Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additemtopaperaddvertistment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_additemtopaperaddvertistment.Location = new System.Drawing.Point(716, 393);
            this.btn_additemtopaperaddvertistment.Name = "btn_additemtopaperaddvertistment";
            this.btn_additemtopaperaddvertistment.Size = new System.Drawing.Size(177, 27);
            this.btn_additemtopaperaddvertistment.TabIndex = 8;
            this.btn_additemtopaperaddvertistment.Text = "Add Item to Paper Advertistment";
            this.btn_additemtopaperaddvertistment.UseVisualStyleBackColor = true;
            this.btn_additemtopaperaddvertistment.Click += new System.EventHandler(this.btn_additemtopaperaddvertistment_Click);
            // 
            // btn_craeateaddvertistment
            // 
            this.btn_craeateaddvertistment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_craeateaddvertistment.BackgroundImage")));
            this.btn_craeateaddvertistment.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_craeateaddvertistment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_craeateaddvertistment.Location = new System.Drawing.Point(441, 664);
            this.btn_craeateaddvertistment.Name = "btn_craeateaddvertistment";
            this.btn_craeateaddvertistment.Size = new System.Drawing.Size(372, 47);
            this.btn_craeateaddvertistment.TabIndex = 9;
            this.btn_craeateaddvertistment.Text = "Create Paper Advertistment";
            this.btn_craeateaddvertistment.UseVisualStyleBackColor = true;
            this.btn_craeateaddvertistment.Click += new System.EventHandler(this.btn_craeateaddvertistment_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.Font = new System.Drawing.Font("Minion Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(140, 664);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(187, 47);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete Item ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_procument
            // 
            this.cmb_procument.FormattingEnabled = true;
            this.cmb_procument.Location = new System.Drawing.Point(290, 83);
            this.cmb_procument.Name = "cmb_procument";
            this.cmb_procument.Size = new System.Drawing.Size(226, 21);
            this.cmb_procument.TabIndex = 11;
            this.cmb_procument.SelectedIndexChanged += new System.EventHandler(this.cmb_procument_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(51, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Procument Plan Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(51, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Search Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1420, 801);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(51, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Add Item Paper Advertisement";
            // 
            // btn_bavk
            // 
            this.btn_bavk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bavk.BackgroundImage")));
            this.btn_bavk.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bavk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_bavk.Location = new System.Drawing.Point(1221, 30);
            this.btn_bavk.Name = "btn_bavk";
            this.btn_bavk.Size = new System.Drawing.Size(103, 36);
            this.btn_bavk.TabIndex = 16;
            this.btn_bavk.Text = "Back";
            this.btn_bavk.UseVisualStyleBackColor = true;
            this.btn_bavk.Click += new System.EventHandler(this.btn_bavk_Click);
            // 
            // AddItemPaperAdvertistment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btn_bavk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_craeateaddvertistment);
            this.Controls.Add(this.btn_additemtopaperaddvertistment);
            this.Controls.Add(this.dgv_paperadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_itemdescription);
            this.Controls.Add(this.cmb_procument);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_procumentPlan);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddItemPaperAdvertistment";
            this.Text = "AddItemPaperAdvertistment";
            this.Load += new System.EventHandler(this.AddItemPaperAdvertistment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procumentPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paperadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_procumentPlan;
        private System.Windows.Forms.TextBox txt_itemdescription;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_paperadd;
        private System.Windows.Forms.Button btn_additemtopaperaddvertistment;
        private System.Windows.Forms.Button btn_craeateaddvertistment;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_procument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_bavk;
    }
}