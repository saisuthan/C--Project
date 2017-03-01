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

namespace SAI.Branch.Bamba
{
    public partial class BAccountant : MetroForm
    {
        public BAccountant(String login)
        {
            InitializeComponent();
            UserName.Text = login;
        }

        private void BAccountant_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            BUpAcc bua = new BUpAcc();
            Hide();
            bua.ShowDialog();
            Close(); 
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            Hide();
            ln.ShowDialog();
            Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            BViewAcc bva = new BViewAcc();
            Hide();
            bva.ShowDialog();
            Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
             int st = 0;
            string style = ColorCombo.Text;
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
    }
}
