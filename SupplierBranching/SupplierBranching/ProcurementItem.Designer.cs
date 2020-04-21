namespace SupplierBranching
{
    partial class ProcurementItem
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
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_estimateunitprice = new System.Windows.Forms.Label();
            this.lbl_source = new System.Windows.Forms.Label();
            this.lbl_procurementmethod = new System.Windows.Forms.Label();
            this.lbl_levelauthority = new System.Windows.Forms.Label();
            this.lbl_prioritystatus = new System.Windows.Forms.Label();
            this.lbl_currentstatus = new System.Windows.Forms.Label();
            this.lbl_completiondate = new System.Windows.Forms.Label();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_estimateunitprice = new System.Windows.Forms.TextBox();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.txt_procurementmethod = new System.Windows.Forms.TextBox();
            this.txt_levelauthority = new System.Windows.Forms.TextBox();
            this.txt_prioritystatus = new System.Windows.Forms.TextBox();
            this.txt_currentstatus = new System.Windows.Forms.TextBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.dtp_completiondate = new System.Windows.Forms.DateTimePicker();
            this.txt_idencode = new System.Windows.Forms.TextBox();
            this.txt_itemdes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_itemgrid = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_backtopro = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(42, 73);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(68, 18);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category";
            this.lbl_category.Click += new System.EventHandler(this.lbl_category_Click);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(46, 191);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(38, 18);
            this.lbl_qty.TabIndex = 1;
            this.lbl_qty.Text = "QTY";
            this.lbl_qty.Click += new System.EventHandler(this.lbl_qty_Click);
            // 
            // lbl_estimateunitprice
            // 
            this.lbl_estimateunitprice.AutoSize = true;
            this.lbl_estimateunitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estimateunitprice.Location = new System.Drawing.Point(42, 227);
            this.lbl_estimateunitprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estimateunitprice.Name = "lbl_estimateunitprice";
            this.lbl_estimateunitprice.Size = new System.Drawing.Size(134, 18);
            this.lbl_estimateunitprice.TabIndex = 2;
            this.lbl_estimateunitprice.Text = "Estimate Unit Price";
            this.lbl_estimateunitprice.Click += new System.EventHandler(this.lbl_estimateunitprice_Click);
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_source.Location = new System.Drawing.Point(42, 269);
            this.lbl_source.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(129, 18);
            this.lbl_source.TabIndex = 4;
            this.lbl_source.Text = "Source of Funding";
            this.lbl_source.Click += new System.EventHandler(this.lbl_source_Click);
            // 
            // lbl_procurementmethod
            // 
            this.lbl_procurementmethod.AutoSize = true;
            this.lbl_procurementmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procurementmethod.Location = new System.Drawing.Point(42, 309);
            this.lbl_procurementmethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_procurementmethod.Name = "lbl_procurementmethod";
            this.lbl_procurementmethod.Size = new System.Drawing.Size(148, 18);
            this.lbl_procurementmethod.TabIndex = 5;
            this.lbl_procurementmethod.Text = "Procurement Method";
            this.lbl_procurementmethod.Click += new System.EventHandler(this.lbl_procurementmethod_Click);
            // 
            // lbl_levelauthority
            // 
            this.lbl_levelauthority.AutoSize = true;
            this.lbl_levelauthority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_levelauthority.Location = new System.Drawing.Point(42, 345);
            this.lbl_levelauthority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_levelauthority.Name = "lbl_levelauthority";
            this.lbl_levelauthority.Size = new System.Drawing.Size(120, 18);
            this.lbl_levelauthority.TabIndex = 6;
            this.lbl_levelauthority.Text = "Level of Authority";
            this.lbl_levelauthority.Click += new System.EventHandler(this.lbl_levelauthority_Click);
            // 
            // lbl_prioritystatus
            // 
            this.lbl_prioritystatus.AutoSize = true;
            this.lbl_prioritystatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prioritystatus.Location = new System.Drawing.Point(42, 385);
            this.lbl_prioritystatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prioritystatus.Name = "lbl_prioritystatus";
            this.lbl_prioritystatus.Size = new System.Drawing.Size(100, 18);
            this.lbl_prioritystatus.TabIndex = 7;
            this.lbl_prioritystatus.Text = "Priority Status";
            this.lbl_prioritystatus.Click += new System.EventHandler(this.lbl_prioritystatus_Click);
            // 
            // lbl_currentstatus
            // 
            this.lbl_currentstatus.AutoSize = true;
            this.lbl_currentstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentstatus.Location = new System.Drawing.Point(42, 425);
            this.lbl_currentstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_currentstatus.Name = "lbl_currentstatus";
            this.lbl_currentstatus.Size = new System.Drawing.Size(103, 18);
            this.lbl_currentstatus.TabIndex = 8;
            this.lbl_currentstatus.Text = "Current Status";
            this.lbl_currentstatus.Click += new System.EventHandler(this.lbl_currentstatus_Click);
            // 
            // lbl_completiondate
            // 
            this.lbl_completiondate.AutoSize = true;
            this.lbl_completiondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_completiondate.Location = new System.Drawing.Point(42, 471);
            this.lbl_completiondate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_completiondate.Name = "lbl_completiondate";
            this.lbl_completiondate.Size = new System.Drawing.Size(119, 18);
            this.lbl_completiondate.TabIndex = 9;
            this.lbl_completiondate.Text = "Completion Date";
            this.lbl_completiondate.Click += new System.EventHandler(this.lbl_completiondate_Click);
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.AutoSize = true;
            this.lbl_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.Location = new System.Drawing.Point(46, 511);
            this.lbl_remarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(69, 18);
            this.lbl_remarks.TabIndex = 10;
            this.lbl_remarks.Text = "Remarks";
            this.lbl_remarks.Click += new System.EventHandler(this.lbl_remarks_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(190, 565);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 25);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(507, 565);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 25);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_category
            // 
            this.txt_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(190, 69);
            this.txt_category.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(264, 24);
            this.txt_category.TabIndex = 13;
            this.txt_category.TextChanged += new System.EventHandler(this.txt_category_TextChanged);
            this.txt_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_category_KeyDown);
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(190, 187);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(264, 24);
            this.txt_qty.TabIndex = 14;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_estimateunitprice
            // 
            this.txt_estimateunitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estimateunitprice.Location = new System.Drawing.Point(190, 223);
            this.txt_estimateunitprice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_estimateunitprice.Name = "txt_estimateunitprice";
            this.txt_estimateunitprice.Size = new System.Drawing.Size(264, 24);
            this.txt_estimateunitprice.TabIndex = 15;
            this.txt_estimateunitprice.TextChanged += new System.EventHandler(this.txt_estimateunitprice_TextChanged);
            // 
            // txt_source
            // 
            this.txt_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_source.Location = new System.Drawing.Point(190, 263);
            this.txt_source.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(264, 24);
            this.txt_source.TabIndex = 17;
            this.txt_source.TextChanged += new System.EventHandler(this.txt_source_TextChanged);
            // 
            // txt_procurementmethod
            // 
            this.txt_procurementmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurementmethod.Location = new System.Drawing.Point(190, 303);
            this.txt_procurementmethod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_procurementmethod.Name = "txt_procurementmethod";
            this.txt_procurementmethod.Size = new System.Drawing.Size(264, 24);
            this.txt_procurementmethod.TabIndex = 18;
            this.txt_procurementmethod.TextChanged += new System.EventHandler(this.txt_procurementmethod_TextChanged);
            // 
            // txt_levelauthority
            // 
            this.txt_levelauthority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_levelauthority.Location = new System.Drawing.Point(190, 341);
            this.txt_levelauthority.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_levelauthority.Name = "txt_levelauthority";
            this.txt_levelauthority.Size = new System.Drawing.Size(264, 24);
            this.txt_levelauthority.TabIndex = 19;
            this.txt_levelauthority.TextChanged += new System.EventHandler(this.txt_levelauthority_TextChanged);
            // 
            // txt_prioritystatus
            // 
            this.txt_prioritystatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prioritystatus.Location = new System.Drawing.Point(189, 381);
            this.txt_prioritystatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_prioritystatus.Name = "txt_prioritystatus";
            this.txt_prioritystatus.Size = new System.Drawing.Size(264, 24);
            this.txt_prioritystatus.TabIndex = 20;
            this.txt_prioritystatus.TextChanged += new System.EventHandler(this.txt_prioritystatus_TextChanged);
            // 
            // txt_currentstatus
            // 
            this.txt_currentstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentstatus.Location = new System.Drawing.Point(190, 421);
            this.txt_currentstatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_currentstatus.Name = "txt_currentstatus";
            this.txt_currentstatus.Size = new System.Drawing.Size(264, 24);
            this.txt_currentstatus.TabIndex = 21;
            this.txt_currentstatus.TextChanged += new System.EventHandler(this.txt_currentstatus_TextChanged);
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remarks.Location = new System.Drawing.Point(189, 507);
            this.txt_remarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(264, 24);
            this.txt_remarks.TabIndex = 23;
            this.txt_remarks.TextChanged += new System.EventHandler(this.txt_remarks_TextChanged);
            // 
            // dtp_completiondate
            // 
            this.dtp_completiondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_completiondate.Location = new System.Drawing.Point(190, 465);
            this.dtp_completiondate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_completiondate.Name = "dtp_completiondate";
            this.dtp_completiondate.Size = new System.Drawing.Size(264, 24);
            this.dtp_completiondate.TabIndex = 24;
            this.dtp_completiondate.ValueChanged += new System.EventHandler(this.dtp_completiondate_ValueChanged);
            // 
            // txt_idencode
            // 
            this.txt_idencode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idencode.Location = new System.Drawing.Point(190, 147);
            this.txt_idencode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_idencode.Name = "txt_idencode";
            this.txt_idencode.Size = new System.Drawing.Size(264, 24);
            this.txt_idencode.TabIndex = 28;
            this.txt_idencode.TextChanged += new System.EventHandler(this.txt_idencode_TextChanged);
            // 
            // txt_itemdes
            // 
            this.txt_itemdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemdes.Location = new System.Drawing.Point(190, 105);
            this.txt_itemdes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_itemdes.Name = "txt_itemdes";
            this.txt_itemdes.Size = new System.Drawing.Size(264, 24);
            this.txt_itemdes.TabIndex = 27;
            this.txt_itemdes.TextChanged += new System.EventHandler(this.txt_itemdes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Identification Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "ItemDescription";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(294, 565);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(78, 25);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(400, 565);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 25);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_itemgrid
            // 
            this.dgv_itemgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemgrid.Location = new System.Drawing.Point(507, 69);
            this.dgv_itemgrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_itemgrid.Name = "dgv_itemgrid";
            this.dgv_itemgrid.ReadOnly = true;
            this.dgv_itemgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemgrid.Size = new System.Drawing.Size(770, 458);
            this.dgv_itemgrid.TabIndex = 31;
            this.dgv_itemgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemgrid_CellClick);
            this.dgv_itemgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemgrid_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1113, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(162, 29);
            this.btn_back.TabIndex = 32;
            this.btn_back.Text = "Back To Home";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_backtopro
            // 
            this.btn_backtopro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_backtopro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backtopro.Location = new System.Drawing.Point(45, 11);
            this.btn_backtopro.Name = "btn_backtopro";
            this.btn_backtopro.Size = new System.Drawing.Size(162, 29);
            this.btn_backtopro.TabIndex = 33;
            this.btn_backtopro.Text = "Back To Pro";
            this.btn_backtopro.UseVisualStyleBackColor = false;
            this.btn_backtopro.Click += new System.EventHandler(this.btn_backtopro_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(507, 15);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(264, 24);
            this.txt_search.TabIndex = 34;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cmb_search
            // 
            this.cmb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "Category",
            "Item Description"});
            this.cmb_search.Location = new System.Drawing.Point(788, 15);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(121, 26);
            this.cmb_search.TabIndex = 35;
            this.cmb_search.Text = "Select";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(933, 15);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 25);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcategory.Location = new System.Drawing.Point(788, 551);
            this.btn_addcategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(180, 39);
            this.btn_addcategory.TabIndex = 37;
            this.btn_addcategory.Text = "Add New Category";
            this.btn_addcategory.UseVisualStyleBackColor = false;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(995, 551);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(198, 39);
            this.btn_report.TabIndex = 38;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // ProcurementItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1318, 625);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_backtopro);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_itemgrid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_idencode);
            this.Controls.Add(this.txt_itemdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_completiondate);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.txt_currentstatus);
            this.Controls.Add(this.txt_prioritystatus);
            this.Controls.Add(this.txt_levelauthority);
            this.Controls.Add(this.txt_procurementmethod);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.txt_estimateunitprice);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_remarks);
            this.Controls.Add(this.lbl_completiondate);
            this.Controls.Add(this.lbl_currentstatus);
            this.Controls.Add(this.lbl_prioritystatus);
            this.Controls.Add(this.lbl_levelauthority);
            this.Controls.Add(this.lbl_procurementmethod);
            this.Controls.Add(this.lbl_source);
            this.Controls.Add(this.lbl_estimateunitprice);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_category);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProcurementItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcurementItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProcurementItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_estimateunitprice;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.Label lbl_procurementmethod;
        private System.Windows.Forms.Label lbl_levelauthority;
        private System.Windows.Forms.Label lbl_prioritystatus;
        private System.Windows.Forms.Label lbl_currentstatus;
        private System.Windows.Forms.Label lbl_completiondate;
        private System.Windows.Forms.Label lbl_remarks;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_estimateunitprice;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.TextBox txt_procurementmethod;
        private System.Windows.Forms.TextBox txt_levelauthority;
        private System.Windows.Forms.TextBox txt_prioritystatus;
        private System.Windows.Forms.TextBox txt_currentstatus;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.DateTimePicker dtp_completiondate;
        private System.Windows.Forms.TextBox txt_idencode;
        private System.Windows.Forms.TextBox txt_itemdes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_itemgrid;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_backtopro;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_report;
    }
}