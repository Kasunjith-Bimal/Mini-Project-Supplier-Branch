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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procumentPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paperadd)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.Location = new System.Drawing.Point(54, 39);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(226, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(313, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_procumentPlan
            // 
            this.dgv_procumentPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_procumentPlan.Location = new System.Drawing.Point(54, 79);
            this.dgv_procumentPlan.Name = "dgv_procumentPlan";
            this.dgv_procumentPlan.Size = new System.Drawing.Size(857, 195);
            this.dgv_procumentPlan.TabIndex = 2;
            this.dgv_procumentPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_procumentPlan_CellClick);
            this.dgv_procumentPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_procumentPlan_CellContentClick);
            // 
            // txt_itemdescription
            // 
            this.txt_itemdescription.Location = new System.Drawing.Point(140, 294);
            this.txt_itemdescription.Name = "txt_itemdescription";
            this.txt_itemdescription.Size = new System.Drawing.Size(190, 20);
            this.txt_itemdescription.TabIndex = 3;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(394, 295);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(190, 20);
            this.txt_quantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Description";
            // 
            // dgv_paperadd
            // 
            this.dgv_paperadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paperadd.Location = new System.Drawing.Point(54, 332);
            this.dgv_paperadd.Name = "dgv_paperadd";
            this.dgv_paperadd.Size = new System.Drawing.Size(857, 195);
            this.dgv_paperadd.TabIndex = 7;
            // 
            // btn_additemtopaperaddvertistment
            // 
            this.btn_additemtopaperaddvertistment.Location = new System.Drawing.Point(622, 289);
            this.btn_additemtopaperaddvertistment.Name = "btn_additemtopaperaddvertistment";
            this.btn_additemtopaperaddvertistment.Size = new System.Drawing.Size(134, 23);
            this.btn_additemtopaperaddvertistment.TabIndex = 8;
            this.btn_additemtopaperaddvertistment.Text = "Add Item to Paper Advertistment";
            this.btn_additemtopaperaddvertistment.UseVisualStyleBackColor = true;
            this.btn_additemtopaperaddvertistment.Click += new System.EventHandler(this.btn_additemtopaperaddvertistment_Click);
            // 
            // btn_craeateaddvertistment
            // 
            this.btn_craeateaddvertistment.Location = new System.Drawing.Point(54, 543);
            this.btn_craeateaddvertistment.Name = "btn_craeateaddvertistment";
            this.btn_craeateaddvertistment.Size = new System.Drawing.Size(196, 23);
            this.btn_craeateaddvertistment.TabIndex = 9;
            this.btn_craeateaddvertistment.Text = "Create Paper Advertistment";
            this.btn_craeateaddvertistment.UseVisualStyleBackColor = true;
            this.btn_craeateaddvertistment.Click += new System.EventHandler(this.btn_craeateaddvertistment_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(762, 287);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 27);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete Item ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // AddItemPaperAdvertistment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_craeateaddvertistment);
            this.Controls.Add(this.btn_additemtopaperaddvertistment);
            this.Controls.Add(this.dgv_paperadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_itemdescription);
            this.Controls.Add(this.dgv_procumentPlan);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "AddItemPaperAdvertistment";
            this.Text = "AddItemPaperAdvertistment";
            this.Load += new System.EventHandler(this.AddItemPaperAdvertistment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procumentPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paperadd)).EndInit();
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
    }
}