﻿namespace SAI.Branch.Wattala
{
    partial class WPOS
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
            this.txtBox_GrandTotal = new System.Windows.Forms.TextBox();
            this.txtBox_Discount = new System.Windows.Forms.TextBox();
            this.pOSTableAdapter = new SAI.FillProductsTableAdapters.POSTableAdapter();
            this.txtBox_Sub = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Qty = new System.Windows.Forms.TextBox();
            this.btn_Add = new MetroFramework.Controls.MetroButton();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.Bk = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.UserName = new MetroFramework.Controls.MetroLabel();
            this.Cashier = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView_pos = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillProducts = new SAI.FillProducts();
            this.Discount = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Proceed = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_GrandTotal
            // 
            this.txtBox_GrandTotal.Enabled = false;
            this.txtBox_GrandTotal.Location = new System.Drawing.Point(440, 463);
            this.txtBox_GrandTotal.Name = "txtBox_GrandTotal";
            this.txtBox_GrandTotal.Size = new System.Drawing.Size(130, 20);
            this.txtBox_GrandTotal.TabIndex = 53;
            // 
            // txtBox_Discount
            // 
            this.txtBox_Discount.Location = new System.Drawing.Point(440, 430);
            this.txtBox_Discount.Name = "txtBox_Discount";
            this.txtBox_Discount.Size = new System.Drawing.Size(130, 20);
            this.txtBox_Discount.TabIndex = 52;
            // 
            // pOSTableAdapter
            // 
            this.pOSTableAdapter.ClearBeforeFill = true;
            // 
            // txtBox_Sub
            // 
            this.txtBox_Sub.Enabled = false;
            this.txtBox_Sub.Location = new System.Drawing.Point(440, 404);
            this.txtBox_Sub.Name = "txtBox_Sub";
            this.txtBox_Sub.Size = new System.Drawing.Size(130, 20);
            this.txtBox_Sub.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(98, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID:";
            // 
            // txtBox_Qty
            // 
            this.txtBox_Qty.Location = new System.Drawing.Point(419, 112);
            this.txtBox_Qty.Name = "txtBox_Qty";
            this.txtBox_Qty.Size = new System.Drawing.Size(54, 20);
            this.txtBox_Qty.TabIndex = 47;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(495, 111);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 45;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseSelectable = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Location = new System.Drawing.Point(196, 111);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(130, 20);
            this.txtBox_ID.TabIndex = 46;
            // 
            // Bk
            // 
            this.Bk.Location = new System.Drawing.Point(29, 464);
            this.Bk.Name = "Bk";
            this.Bk.Size = new System.Drawing.Size(75, 23);
            this.Bk.TabIndex = 44;
            this.Bk.Text = "⬅ Back";
            this.Bk.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.UserName);
            this.metroPanel1.Controls.Add(this.Cashier);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(327, 51);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(243, 42);
            this.metroPanel1.TabIndex = 36;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(95, 13);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(40, 19);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "USER";
            // 
            // Cashier
            // 
            this.Cashier.AutoSize = true;
            this.Cashier.Location = new System.Drawing.Point(14, 13);
            this.Cashier.Name = "Cashier";
            this.Cashier.Size = new System.Drawing.Size(52, 19);
            this.Cashier.TabIndex = 2;
            this.Cashier.Text = "Cashier";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(369, 431);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Discount :";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dataGridView_pos);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 149);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(550, 246);
            this.metroPanel2.TabIndex = 37;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dataGridView_pos
            // 
            this.dataGridView_pos.AutoGenerateColumns = false;
            this.dataGridView_pos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView_pos.DataSource = this.pOSBindingSource;
            this.dataGridView_pos.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_pos.Name = "dataGridView_pos";
            this.dataGridView_pos.Size = new System.Drawing.Size(543, 158);
            this.dataGridView_pos.TabIndex = 2;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // pOSBindingSource
            // 
            this.pOSBindingSource.DataMember = "POS";
            this.pOSBindingSource.DataSource = this.fillProducts;
            // 
            // fillProducts
            // 
            this.fillProducts.DataSetName = "FillProducts";
            this.fillProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(271, 430);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(75, 23);
            this.Discount.TabIndex = 42;
            this.Discount.Text = "Discount";
            this.Discount.UseSelectable = true;
            this.Discount.Click += new System.EventHandler(this.Discount_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(369, 404);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 39;
            this.metroLabel2.Text = "Sub Total :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Invoice No:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(352, 464);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Grand Total :";
            // 
            // Proceed
            // 
            this.Proceed.Location = new System.Drawing.Point(271, 460);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(75, 23);
            this.Proceed.TabIndex = 43;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseSelectable = true;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // WPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 519);
            this.Controls.Add(this.txtBox_GrandTotal);
            this.Controls.Add(this.txtBox_Discount);
            this.Controls.Add(this.txtBox_Sub);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Qty);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.Bk);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.Proceed);
            this.Name = "WPOS";
            this.Text = "Wattala";
            this.Load += new System.EventHandler(this.WPOS_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_GrandTotal;
        private System.Windows.Forms.TextBox txtBox_Discount;
        private FillProductsTableAdapters.POSTableAdapter pOSTableAdapter;
        private System.Windows.Forms.TextBox txtBox_Sub;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Qty;
        private MetroFramework.Controls.MetroButton btn_Add;
        private System.Windows.Forms.TextBox txtBox_ID;
        private MetroFramework.Controls.MetroLink Bk;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel UserName;
        private MetroFramework.Controls.MetroLabel Cashier;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dataGridView_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pOSBindingSource;
        private FillProducts fillProducts;
        private MetroFramework.Controls.MetroButton Discount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton Proceed;


    }
}