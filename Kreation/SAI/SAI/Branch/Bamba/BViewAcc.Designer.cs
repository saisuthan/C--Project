namespace SAI.Branch.Bamba
{
    partial class BViewAcc
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
            this.Back = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.Edit = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView_bGuest = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Image = null;
            this.Back.Location = new System.Drawing.Point(539, 376);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseSelectable = true;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Edit
            // 
            this.Edit.Image = null;
            this.Edit.Location = new System.Drawing.Point(444, 376);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseSelectable = true;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridView_bGuest);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(32, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(597, 289);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridView_bGuest
            // 
            this.dataGridView_bGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bGuest.Location = new System.Drawing.Point(12, 14);
            this.dataGridView_bGuest.Name = "dataGridView_bGuest";
            this.dataGridView_bGuest.Size = new System.Drawing.Size(570, 177);
            this.dataGridView_bGuest.TabIndex = 2;
            // 
            // BViewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 416);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.metroPanel1);
            this.Name = "BViewAcc";
            this.Text = "Bambalapitya";
            this.Load += new System.EventHandler(this.BViewAcc_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton Back;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton Edit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView_bGuest;
    }
}