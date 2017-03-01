namespace SAI.Branch.Wattala
{
    partial class WGuest
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView_wGuest = new System.Windows.Forms.DataGridView();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Image = null;
            this.Back.Location = new System.Drawing.Point(414, 267);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseSelectable = true;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dataGridView_wGuest);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 62);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(478, 182);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dataGridView_wGuest
            // 
            this.dataGridView_wGuest.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_wGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wGuest.EnableHeadersVisualStyles = false;
            this.dataGridView_wGuest.GridColor = System.Drawing.Color.White;
            this.dataGridView_wGuest.Location = new System.Drawing.Point(23, 13);
            this.dataGridView_wGuest.Name = "dataGridView_wGuest";
            this.dataGridView_wGuest.Size = new System.Drawing.Size(443, 150);
            this.dataGridView_wGuest.TabIndex = 2;
            // 
            // WGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 330);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.Back);
            this.Name = "WGuest";
            this.Text = "Wattala";
            this.Load += new System.EventHandler(this.WGuest_Load);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton Back;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dataGridView_wGuest;
    }
}