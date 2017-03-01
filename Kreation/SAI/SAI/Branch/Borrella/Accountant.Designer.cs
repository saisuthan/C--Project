namespace SAI.Branch.Borrella
{
    partial class Accountant
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Apply = new MetroFramework.Controls.MetroButton();
            this.ColorCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DarkRB = new MetroFramework.Controls.MetroRadioButton();
            this.LightRB = new MetroFramework.Controls.MetroRadioButton();
            this.Theme = new MetroFramework.Controls.MetroLabel();
            this.LogOut = new MetroFramework.Controls.MetroLink();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.UserName = new MetroFramework.Controls.MetroLabel();
            this.Welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.View = new MetroFramework.Controls.MetroButton();
            this.Update = new MetroFramework.Controls.MetroButton();
            this.Msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Msm)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Apply);
            this.metroPanel1.Controls.Add(this.ColorCombo);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.DarkRB);
            this.metroPanel1.Controls.Add(this.LightRB);
            this.metroPanel1.Controls.Add(this.Theme);
            this.metroPanel1.Controls.Add(this.LogOut);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(412, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(176, 290);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(68, 254);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 9;
            this.Apply.Text = "Apply";
            this.Apply.UseSelectable = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ColorCombo
            // 
            this.ColorCombo.FormattingEnabled = true;
            this.ColorCombo.ItemHeight = 23;
            this.ColorCombo.Items.AddRange(new object[] {
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.ColorCombo.Location = new System.Drawing.Point(22, 208);
            this.ColorCombo.Name = "ColorCombo";
            this.ColorCombo.Size = new System.Drawing.Size(121, 29);
            this.ColorCombo.TabIndex = 8;
            this.ColorCombo.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 175);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Color";
            // 
            // DarkRB
            // 
            this.DarkRB.AutoSize = true;
            this.DarkRB.Location = new System.Drawing.Point(92, 137);
            this.DarkRB.Name = "DarkRB";
            this.DarkRB.Size = new System.Drawing.Size(47, 15);
            this.DarkRB.TabIndex = 6;
            this.DarkRB.Text = "Dark";
            this.DarkRB.UseSelectable = true;
            this.DarkRB.CheckedChanged += new System.EventHandler(this.DarkRB_CheckedChanged);
            // 
            // LightRB
            // 
            this.LightRB.AutoSize = true;
            this.LightRB.Location = new System.Drawing.Point(22, 137);
            this.LightRB.Name = "LightRB";
            this.LightRB.Size = new System.Drawing.Size(50, 15);
            this.LightRB.TabIndex = 5;
            this.LightRB.Text = "Light";
            this.LightRB.UseSelectable = true;
            this.LightRB.CheckedChanged += new System.EventHandler(this.LightRB_CheckedChanged);
            // 
            // Theme
            // 
            this.Theme.AutoSize = true;
            this.Theme.Location = new System.Drawing.Point(22, 100);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(49, 19);
            this.Theme.TabIndex = 4;
            this.Theme.Text = "Theme";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(22, 59);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(102, 23);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "🚶      Log Out";
            this.LogOut.UseSelectable = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.UserName);
            this.metroPanel2.Controls.Add(this.Welcome);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(391, 90);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(106, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(68, 19);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Username";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(19, 21);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(64, 19);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "Welcome";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.View);
            this.metroPanel3.Controls.Add(this.Update);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(23, 149);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(391, 204);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // View
            // 
            this.View.BackgroundImage = global::SAI.Properties.Resources.View;
            this.View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.View.Location = new System.Drawing.Point(201, 49);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(140, 80);
            this.View.TabIndex = 3;
            this.View.UseSelectable = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Update
            // 
            this.Update.BackgroundImage = global::SAI.Properties.Resources.Update;
            this.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update.Location = new System.Drawing.Point(19, 49);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(140, 80);
            this.Update.TabIndex = 2;
            this.Update.UseSelectable = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Msm
            // 
            this.Msm.Owner = this;
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 376);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel3);
            this.Name = "Accountant";
            this.Text = "Accountant";
            this.Load += new System.EventHandler(this.Accountant_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Msm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Apply;
        private MetroFramework.Controls.MetroComboBox ColorCombo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton DarkRB;
        private MetroFramework.Controls.MetroRadioButton LightRB;
        private MetroFramework.Controls.MetroLabel Theme;
        private MetroFramework.Controls.MetroLink LogOut;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel UserName;
        private MetroFramework.Controls.MetroLabel Welcome;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton View;
        private MetroFramework.Controls.MetroButton Update;
        private MetroFramework.Components.MetroStyleManager Msm;
    }
}