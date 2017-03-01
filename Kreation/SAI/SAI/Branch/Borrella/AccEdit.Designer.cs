namespace SAI.Branch.Borrella
{
    partial class AccEdit
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Amount = new MetroFramework.Controls.MetroTextBox();
            this.Type = new MetroFramework.Controls.MetroComboBox();
            this.Desc = new MetroFramework.Controls.MetroTextBox();
            this.TrNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Search = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.TrNoSr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Submit = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.Bk = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Amount);
            this.metroPanel1.Controls.Add(this.Type);
            this.metroPanel1.Controls.Add(this.Desc);
            this.metroPanel1.Controls.Add(this.TrNo);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 85);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(428, 301);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // Amount
            // 
            // 
            // 
            // 
            this.Amount.CustomButton.Image = null;
            this.Amount.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.Amount.CustomButton.Name = "";
            this.Amount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Amount.CustomButton.TabIndex = 1;
            this.Amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Amount.CustomButton.UseSelectable = true;
            this.Amount.CustomButton.Visible = false;
            this.Amount.Lines = new string[0];
            this.Amount.Location = new System.Drawing.Point(157, 206);
            this.Amount.MaxLength = 32767;
            this.Amount.Name = "Amount";
            this.Amount.PasswordChar = '\0';
            this.Amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Amount.SelectedText = "";
            this.Amount.SelectionLength = 0;
            this.Amount.SelectionStart = 0;
            this.Amount.Size = new System.Drawing.Size(150, 23);
            this.Amount.TabIndex = 9;
            this.Amount.UseSelectable = true;
            this.Amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.ItemHeight = 23;
            this.Type.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.Type.Location = new System.Drawing.Point(157, 169);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(150, 29);
            this.Type.TabIndex = 8;
            this.Type.UseSelectable = true;
            // 
            // Desc
            // 
            // 
            // 
            // 
            this.Desc.CustomButton.Image = null;
            this.Desc.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.Desc.CustomButton.Name = "";
            this.Desc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Desc.CustomButton.TabIndex = 1;
            this.Desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Desc.CustomButton.UseSelectable = true;
            this.Desc.CustomButton.Visible = false;
            this.Desc.Lines = new string[0];
            this.Desc.Location = new System.Drawing.Point(157, 91);
            this.Desc.MaxLength = 32767;
            this.Desc.Name = "Desc";
            this.Desc.PasswordChar = '\0';
            this.Desc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Desc.SelectedText = "";
            this.Desc.SelectionLength = 0;
            this.Desc.SelectionStart = 0;
            this.Desc.Size = new System.Drawing.Size(150, 23);
            this.Desc.TabIndex = 7;
            this.Desc.UseSelectable = true;
            this.Desc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Desc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TrNo
            // 
            // 
            // 
            // 
            this.TrNo.CustomButton.Image = null;
            this.TrNo.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.TrNo.CustomButton.Name = "";
            this.TrNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TrNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TrNo.CustomButton.TabIndex = 1;
            this.TrNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TrNo.CustomButton.UseSelectable = true;
            this.TrNo.CustomButton.Visible = false;
            this.TrNo.Lines = new string[0];
            this.TrNo.Location = new System.Drawing.Point(157, 28);
            this.TrNo.MaxLength = 32767;
            this.TrNo.Name = "TrNo";
            this.TrNo.PasswordChar = '\0';
            this.TrNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TrNo.SelectedText = "";
            this.TrNo.SelectionLength = 0;
            this.TrNo.SelectionStart = 0;
            this.TrNo.Size = new System.Drawing.Size(150, 23);
            this.TrNo.TabIndex = 6;
            this.TrNo.UseSelectable = true;
            this.TrNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TrNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 211);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Amount :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 38);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Entry :\r\n";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Description :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Transaction No:";
            // 
            // Search
            // 
            this.Search.Image = null;
            this.Search.Location = new System.Drawing.Point(343, 60);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 23);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.UseSelectable = true;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TrNoSr
            // 
            // 
            // 
            // 
            this.TrNoSr.CustomButton.Image = null;
            this.TrNoSr.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.TrNoSr.CustomButton.Name = "";
            this.TrNoSr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TrNoSr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TrNoSr.CustomButton.TabIndex = 1;
            this.TrNoSr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TrNoSr.CustomButton.UseSelectable = true;
            this.TrNoSr.CustomButton.Visible = false;
            this.TrNoSr.Lines = new string[0];
            this.TrNoSr.Location = new System.Drawing.Point(180, 60);
            this.TrNoSr.MaxLength = 32767;
            this.TrNoSr.Name = "TrNoSr";
            this.TrNoSr.PasswordChar = '\0';
            this.TrNoSr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TrNoSr.SelectedText = "";
            this.TrNoSr.SelectionLength = 0;
            this.TrNoSr.SelectionStart = 0;
            this.TrNoSr.Size = new System.Drawing.Size(150, 23);
            this.TrNoSr.TabIndex = 10;
            this.TrNoSr.UseSelectable = true;
            this.TrNoSr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TrNoSr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(55, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Transaction No:";
            // 
            // Submit
            // 
            this.Submit.Image = null;
            this.Submit.Location = new System.Drawing.Point(328, 417);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(123, 41);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseSelectable = true;
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Bk
            // 
            this.Bk.Location = new System.Drawing.Point(23, 435);
            this.Bk.Name = "Bk";
            this.Bk.Size = new System.Drawing.Size(75, 23);
            this.Bk.TabIndex = 13;
            this.Bk.Text = "⬅ Back";
            this.Bk.UseSelectable = true;
            this.Bk.Click += new System.EventHandler(this.Bk_Click);
            // 
            // AccEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 464);
            this.Controls.Add(this.Bk);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.TrNoSr);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Submit);
            this.Name = "AccEdit";
            this.Text = "Borella";
            this.Load += new System.EventHandler(this.AccEdit_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox Amount;
        private MetroFramework.Controls.MetroComboBox Type;
        private MetroFramework.Controls.MetroTextBox Desc;
        private MetroFramework.Controls.MetroTextBox TrNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton Search;
        private MetroFramework.Controls.MetroTextBox TrNoSr;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton Submit;
        private MetroFramework.Controls.MetroLink Bk;
    }
}