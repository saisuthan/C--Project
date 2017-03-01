using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SAI.Branch.Borrella;
using SAI.Properties;
using MetroFramework.Components;
using MetroFramework.Properties;


namespace SAI
{
    public partial class Admin : MetroForm
    {
        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public Admin(String login)
        {
            InitializeComponent();
            lb_User.Text = login;
            
        }

        private void Admin_Load(object sender, EventArgs e)

        {
            
          
        }

        private void stt_Click(object sender, EventArgs e)
        {
          
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            Hide();
            ln.ShowDialog();
            Close();
        }

        private void LightRB_CheckedChanged(object sender, EventArgs e)
        {
            if (LightRB.Checked)
            {
                Msm.Theme = MetroThemeStyle.Light;
            }
        }

        private void DarkRB_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkRB.Checked)
            {
                Msm.Theme = MetroThemeStyle.Dark;
            }
        }

        private void Access_Click(object sender, EventArgs e)
        {

            Access A= new Access();
            Hide();
            A.ShowDialog();
            Close();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            Hide();
            AP.ShowDialog();
            Close();
        }

        private void POS_Click(object sender, EventArgs e)
        {
            POS ps = new POS("");
            Hide();
            ps.ShowDialog();
            Close();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            
        }

        private void Accounts_Click(object sender, EventArgs e)
        {
            SelBranch ps = new SelBranch();
            Hide();
            ps.ShowDialog();
            Close();
        }

        private void Apply_Click_1(object sender, EventArgs e)
        {
            int st = 0;
            string style = Color.Text;
            switch (style)
            {
                case "Black":
                    st = 1;
                    break;

                case "White":
                    st = 2;
                    break;

                case "Silver":
                    st = 3;
                    break;

                case "Blue":
                    st = 4;
                    break;

                case "Green":
                    st = 5;
                    break;

                case "Lime":
                    st = 6;
                    break;

                case "Teal":
                    st = 7;
                    break;

                case "Orange":
                    st = 8;
                    break;

                case "Brown":
                    st = 9;
                    break;

                case "Pink":
                    st = 10;
                    break;

                case "Magenta":
                    st = 11;
                    break;

                case "Purple":
                    st = 12;
                    break;

                case "Red":
                    st = 13;
                    break;

                case "Yellow":
                    st = 14;
                    break;
            }
            Msm.Style = (MetroColorStyle)st;
        }
    }
}
