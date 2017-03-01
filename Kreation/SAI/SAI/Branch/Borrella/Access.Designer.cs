namespace SAI
{
    partial class Access
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
            this.bid = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Authorize = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.Type = new MetroFramework.Controls.MetroComboBox();
            this.PassWord = new MetroFramework.Controls.MetroTextBox();
            this.UserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Bk = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.bid);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.Authorize);
            this.metroPanel1.Controls.Add(this.Type);
            this.metroPanel1.Controls.Add(this.PassWord);
            this.metroPanel1.Controls.Add(this.UserName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(321, 282);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // bid
            // 
            this.bid.FormattingEnabled = true;
            this.bid.ItemHeight = 23;
            this.bid.Items.AddRange(new object[] {
            "Borella",
            "Bamba",
            "Wattala"});
            this.bid.Location = new System.Drawing.Point(133, 155);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(175, 29);
            this.bid.TabIndex = 15;
            this.bid.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 155);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Branch ID";
            // 
            // Authorize
            // 
            this.Authorize.Image = null;
            this.Authorize.Location = new System.Drawing.Point(222, 234);
            this.Authorize.Name = "Authorize";
            this.Authorize.Size = new System.Drawing.Size(86, 23);
            this.Authorize.Style = MetroFramework.MetroColorStyle.Orange;
            this.Authorize.TabIndex = 13;
            this.Authorize.Text = "Authorize";
            this.Authorize.UseSelectable = true;
            this.Authorize.UseVisualStyleBackColor = true;
            this.Authorize.Click += new System.EventHandler(this.Authorize_Click);
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.ItemHeight = 23;
            this.Type.Items.AddRange(new object[] {
            "Admin",
            "Accountant",
            "Guest",
            "Emp"});
            this.Type.Location = new System.Drawing.Point(133, 109);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(175, 29);
            this.Type.TabIndex = 12;
            this.Type.UseSelectable = true;
            // 
            // PassWord
            // 
            // 
            // 
            // 
            this.PassWord.CustomButton.Image = null;
            this.PassWord.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.PassWord.CustomButton.Name = "";
            this.PassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassWord.CustomButton.TabIndex = 1;
            this.PassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassWord.CustomButton.UseSelectable = true;
            this.PassWord.CustomButton.Visible = false;
            this.PassWord.Lines = new string[0];
            this.PassWord.Location = new System.Drawing.Point(133, 63);
            this.PassWord.MaxLength = 32767;
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '\0';
            this.PassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassWord.SelectedText = "";
            this.PassWord.SelectionLength = 0;
            this.PassWord.SelectionStart = 0;
            this.PassWord.Size = new System.Drawing.Size(175, 23);
            this.PassWord.TabIndex = 11;
            this.PassWord.UseSelectable = true;
            this.PassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserName
            // 
            // 
            // 
            // 
            this.UserName.CustomButton.Image = null;
            this.UserName.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.UserName.CustomButton.Name = "";
            this.UserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName.CustomButton.TabIndex = 1;
            this.UserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName.CustomButton.UseSelectable = true;
            this.UserName.CustomButton.Visible = false;
            this.UserName.Lines = new string[0];
            this.UserName.Location = new System.Drawing.Point(133, 12);
            this.UserName.MaxLength = 32767;
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.Size = new System.Drawing.Size(175, 23);
            this.UserName.TabIndex = 10;
            this.UserName.UseSelectable = true;
            this.UserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Type";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "User Name";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.txtBox_Username);
            this.metroPanel2.Controls.Add(this.dataGridView1);
            this.metroPanel2.Controls.Add(this.Delete);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(373, 57);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(471, 282);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // txtBox_Username
            // 
            // 
            // 
            // 
            this.txtBox_Username.CustomButton.Image = null;
            this.txtBox_Username.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtBox_Username.CustomButton.Name = "";
            this.txtBox_Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBox_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_Username.CustomButton.TabIndex = 1;
            this.txtBox_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_Username.CustomButton.UseSelectable = true;
            this.txtBox_Username.CustomButton.Visible = false;
            this.txtBox_Username.Lines = new string[0];
            this.txtBox_Username.Location = new System.Drawing.Point(75, 13);
            this.txtBox_Username.MaxLength = 32767;
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.PasswordChar = '\0';
            this.txtBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_Username.SelectedText = "";
            this.txtBox_Username.SelectionLength = 0;
            this.txtBox_Username.SelectionStart = 0;
            this.txtBox_Username.Size = new System.Drawing.Size(175, 23);
            this.txtBox_Username.TabIndex = 16;
            this.txtBox_Username.UseSelectable = true;
            this.txtBox_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 192);
            this.dataGridView1.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.Image = null;
            this.Delete.Location = new System.Drawing.Point(278, 13);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 23);
            this.Delete.Style = MetroFramework.MetroColorStyle.Orange;
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseSelectable = true;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "User ID";
            // 
            // Bk
            // 
            this.Bk.Location = new System.Drawing.Point(769, 355);
            this.Bk.Name = "Bk";
            this.Bk.Size = new System.Drawing.Size(75, 23);
            this.Bk.Style = MetroFramework.MetroColorStyle.Orange;
            this.Bk.TabIndex = 13;
            this.Bk.Text = "⬅ Back";
            this.Bk.UseSelectable = true;
            this.Bk.Click += new System.EventHandler(this.Bk_Click);
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 399);
            this.Controls.Add(this.Bk);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Access";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Access";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Access_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton Authorize;
        private MetroFramework.Controls.MetroComboBox Type;
        private MetroFramework.Controls.MetroTextBox PassWord;
        private MetroFramework.Controls.MetroTextBox UserName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton Delete;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink Bk;
        private MetroFramework.Controls.MetroComboBox bid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtBox_Username;
    }
}