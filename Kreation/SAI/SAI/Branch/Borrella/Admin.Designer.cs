namespace SAI
{
    partial class Admin
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.Posb = new MetroFramework.Controls.MetroButton();
            this.Access = new MetroFramework.Controls.MetroButton();
            this.Items = new MetroFramework.Controls.MetroButton();
            this.Accounts = new MetroFramework.Controls.MetroButton();
            this.lb_User = new MetroFramework.Controls.MetroLabel();
            this.Welcome = new MetroFramework.Controls.MetroLabel();
            this.Panel1 = new MetroFramework.Controls.MetroPanel();
            this.Mpnl = new MetroFramework.Controls.MetroPanel();
            this.Apply = new MetroFramework.Controls.MetroButton();
            this.Color = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DarkRB = new MetroFramework.Controls.MetroRadioButton();
            this.LightRB = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Logout = new MetroFramework.Controls.MetroLink();
            this.Msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Mpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Msm)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.Posb);
            this.metroPanel2.Controls.Add(this.Access);
            this.metroPanel2.Controls.Add(this.Items);
            this.metroPanel2.Controls.Add(this.Accounts);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(13, 135);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(541, 223);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Posb
            // 
            this.Posb.BackgroundImage = global::SAI.Properties.Resources.POS;
            this.Posb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Posb.Location = new System.Drawing.Point(282, 123);
            this.Posb.Name = "Posb";
            this.Posb.Size = new System.Drawing.Size(140, 80);
            this.Posb.TabIndex = 10;
            this.Posb.UseSelectable = true;
            this.Posb.Click += new System.EventHandler(this.POS_Click);
            // 
            // Access
            // 
            this.Access.BackgroundImage = global::SAI.Properties.Resources.Access;
            this.Access.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Access.Location = new System.Drawing.Point(67, 123);
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(140, 80);
            this.Access.TabIndex = 9;
            this.Access.UseSelectable = true;
            this.Access.Click += new System.EventHandler(this.Access_Click);
            // 
            // Items
            // 
            this.Items.BackgroundImage = global::SAI.Properties.Resources.Items;
            this.Items.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Items.Location = new System.Drawing.Point(282, 20);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(140, 83);
            this.Items.TabIndex = 8;
            this.Items.UseSelectable = true;
            this.Items.Click += new System.EventHandler(this.Items_Click);
            // 
            // Accounts
            // 
            this.Accounts.BackgroundImage = global::SAI.Properties.Resources.Accounts;
            this.Accounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Accounts.Location = new System.Drawing.Point(67, 20);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(140, 83);
            this.Accounts.TabIndex = 7;
            this.Accounts.UseSelectable = true;
            this.Accounts.Click += new System.EventHandler(this.Accounts_Click);
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_User.Location = new System.Drawing.Point(90, 19);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(68, 19);
            this.lb_User.TabIndex = 3;
            this.lb_User.Text = "Username";
            this.lb_User.Click += new System.EventHandler(this.Username_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(20, 16);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(64, 19);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "Welcome";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lb_User);
            this.Panel1.Controls.Add(this.Welcome);
            this.Panel1.HorizontalScrollbarBarColor = true;
            this.Panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel1.HorizontalScrollbarSize = 10;
            this.Panel1.Location = new System.Drawing.Point(13, 60);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(534, 89);
            this.Panel1.TabIndex = 4;
            this.Panel1.VerticalScrollbarBarColor = true;
            this.Panel1.VerticalScrollbarHighlightOnWheel = false;
            this.Panel1.VerticalScrollbarSize = 10;
            // 
            // Mpnl
            // 
            this.Mpnl.Controls.Add(this.Apply);
            this.Mpnl.Controls.Add(this.Color);
            this.Mpnl.Controls.Add(this.metroLabel2);
            this.Mpnl.Controls.Add(this.DarkRB);
            this.Mpnl.Controls.Add(this.LightRB);
            this.Mpnl.Controls.Add(this.metroLabel1);
            this.Mpnl.Controls.Add(this.Logout);
            this.Mpnl.HorizontalScrollbarBarColor = true;
            this.Mpnl.HorizontalScrollbarHighlightOnWheel = false;
            this.Mpnl.HorizontalScrollbarSize = 10;
            this.Mpnl.Location = new System.Drawing.Point(479, 60);
            this.Mpnl.Name = "Mpnl";
            this.Mpnl.Size = new System.Drawing.Size(193, 298);
            this.Mpnl.TabIndex = 10;
            this.Mpnl.VerticalScrollbarBarColor = true;
            this.Mpnl.VerticalScrollbarHighlightOnWheel = false;
            this.Mpnl.VerticalScrollbarSize = 10;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(107, 224);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 9;
            this.Apply.Text = "Apply";
            this.Apply.UseSelectable = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click_1);
            // 
            // Color
            // 
            this.Color.FormattingEnabled = true;
            this.Color.ItemHeight = 23;
            this.Color.Items.AddRange(new object[] {
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
            this.Color.Location = new System.Drawing.Point(37, 189);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(145, 29);
            this.Color.TabIndex = 8;
            this.Color.UseSelectable = true;
            this.Color.SelectedIndexChanged += new System.EventHandler(this.Color_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Color";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // DarkRB
            // 
            this.DarkRB.AutoSize = true;
            this.DarkRB.Location = new System.Drawing.Point(123, 108);
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
            this.LightRB.Location = new System.Drawing.Point(37, 108);
            this.LightRB.Name = "LightRB";
            this.LightRB.Size = new System.Drawing.Size(50, 15);
            this.LightRB.TabIndex = 5;
            this.LightRB.Text = "Light";
            this.LightRB.UseSelectable = true;
            this.LightRB.CheckedChanged += new System.EventHandler(this.LightRB_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Theme";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(26, 15);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(110, 23);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "🚶      Log Out";
            this.Logout.UseSelectable = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Msm
            // 
            this.Msm.Owner = this;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.Mpnl);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.Panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.BackColorChanged += new System.EventHandler(this.LightRB_CheckedChanged);
            this.StyleChanged += new System.EventHandler(this.Admin_Load);
            this.SystemColorsChanged += new System.EventHandler(this.Admin_Load);
            this.metroPanel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Mpnl.ResumeLayout(false);
            this.Mpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Msm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Posb;
        private MetroFramework.Controls.MetroButton Access;
        private MetroFramework.Controls.MetroButton Accounts;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton Items;
        private MetroFramework.Controls.MetroLabel lb_User;
        private MetroFramework.Controls.MetroLabel Welcome;
        private MetroFramework.Controls.MetroPanel Panel1;
        private MetroFramework.Controls.MetroPanel Mpnl;
        private MetroFramework.Controls.MetroButton Apply;
        private MetroFramework.Controls.MetroComboBox Color;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton DarkRB;
        private MetroFramework.Controls.MetroRadioButton LightRB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink Logout;
        private MetroFramework.Components.MetroStyleManager Msm;
    }
}