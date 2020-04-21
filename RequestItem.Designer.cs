﻿namespace SupplierBranching
{
    partial class RequestItem
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
            this.lbl_itemdes = new System.Windows.Forms.Label();
            this.lbl_itemspeci = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_estimateprice = new System.Windows.Forms.Label();
            this.lbl_itemphoto = new System.Windows.Forms.Label();
            this.txt_itemdes = new System.Windows.Forms.TextBox();
            this.txt_itemspeci = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_estimateprice = new System.Windows.Forms.TextBox();
            this.txt_itemphoto = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.dgv_reqitem = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reqitem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_itemdes
            // 
            this.lbl_itemdes.AutoSize = true;
            this.lbl_itemdes.Location = new System.Drawing.Point(58, 90);
            this.lbl_itemdes.Name = "lbl_itemdes";
            this.lbl_itemdes.Size = new System.Drawing.Size(86, 13);
            this.lbl_itemdes.TabIndex = 0;
            this.lbl_itemdes.Text = "Item Description ";
            this.lbl_itemdes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_itemspeci
            // 
            this.lbl_itemspeci.AutoSize = true;
            this.lbl_itemspeci.Location = new System.Drawing.Point(58, 134);
            this.lbl_itemspeci.Name = "lbl_itemspeci";
            this.lbl_itemspeci.Size = new System.Drawing.Size(91, 13);
            this.lbl_itemspeci.TabIndex = 1;
            this.lbl_itemspeci.Text = "Item Specification";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(58, 186);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_estimateprice
            // 
            this.lbl_estimateprice.AutoSize = true;
            this.lbl_estimateprice.Location = new System.Drawing.Point(58, 234);
            this.lbl_estimateprice.Name = "lbl_estimateprice";
            this.lbl_estimateprice.Size = new System.Drawing.Size(74, 13);
            this.lbl_estimateprice.TabIndex = 3;
            this.lbl_estimateprice.Text = "Estimate Price";
            // 
            // lbl_itemphoto
            // 
            this.lbl_itemphoto.AutoSize = true;
            this.lbl_itemphoto.Location = new System.Drawing.Point(58, 284);
            this.lbl_itemphoto.Name = "lbl_itemphoto";
            this.lbl_itemphoto.Size = new System.Drawing.Size(74, 13);
            this.lbl_itemphoto.TabIndex = 4;
            this.lbl_itemphoto.Text = "Item Photo Url";
            this.lbl_itemphoto.Click += new System.EventHandler(this.lbl_itemphoto_Click);
            // 
            // txt_itemdes
            // 
            this.txt_itemdes.Location = new System.Drawing.Point(168, 87);
            this.txt_itemdes.Name = "txt_itemdes";
            this.txt_itemdes.Size = new System.Drawing.Size(331, 20);
            this.txt_itemdes.TabIndex = 5;
            // 
            // txt_itemspeci
            // 
            this.txt_itemspeci.Location = new System.Drawing.Point(168, 131);
            this.txt_itemspeci.Name = "txt_itemspeci";
            this.txt_itemspeci.Size = new System.Drawing.Size(331, 20);
            this.txt_itemspeci.TabIndex = 6;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(168, 179);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(331, 20);
            this.txt_qty.TabIndex = 7;
            // 
            // txt_estimateprice
            // 
            this.txt_estimateprice.Location = new System.Drawing.Point(168, 227);
            this.txt_estimateprice.Name = "txt_estimateprice";
            this.txt_estimateprice.Size = new System.Drawing.Size(331, 20);
            this.txt_estimateprice.TabIndex = 8;
            // 
            // txt_itemphoto
            // 
            this.txt_itemphoto.Location = new System.Drawing.Point(168, 277);
            this.txt_itemphoto.Name = "txt_itemphoto";
            this.txt_itemphoto.Size = new System.Drawing.Size(331, 20);
            this.txt_itemphoto.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(168, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(424, 326);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_category
            // 
            this.txt_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_category.Location = new System.Drawing.Point(168, 47);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(331, 20);
            this.txt_category.TabIndex = 13;
            this.txt_category.TextChanged += new System.EventHandler(this.txt_category_TextChanged);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(58, 54);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(72, 13);
            this.lbl_category.TabIndex = 12;
            this.lbl_category.Text = "Item Category";
            // 
            // dgv_reqitem
            // 
            this.dgv_reqitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reqitem.Location = new System.Drawing.Point(520, 47);
            this.dgv_reqitem.Name = "dgv_reqitem";
            this.dgv_reqitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reqitem.Size = new System.Drawing.Size(512, 302);
            this.dgv_reqitem.TabIndex = 14;
            this.dgv_reqitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reqitem_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(253, 326);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(343, 326);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // RequestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 373);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgv_reqitem);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_itemphoto);
            this.Controls.Add(this.txt_estimateprice);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_itemspeci);
            this.Controls.Add(this.txt_itemdes);
            this.Controls.Add(this.lbl_itemphoto);
            this.Controls.Add(this.lbl_estimateprice);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_itemspeci);
            this.Controls.Add(this.lbl_itemdes);
            this.Name = "RequestItem";
            this.Text = "RequestItem";
            this.Load += new System.EventHandler(this.RequestItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reqitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_itemdes;
        private System.Windows.Forms.Label lbl_itemspeci;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_estimateprice;
        private System.Windows.Forms.Label lbl_itemphoto;
        private System.Windows.Forms.TextBox txt_itemdes;
        private System.Windows.Forms.TextBox txt_itemspeci;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_estimateprice;
        private System.Windows.Forms.TextBox txt_itemphoto;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.DataGridView dgv_reqitem;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}