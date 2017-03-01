using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SAI.Branch.Borrella;
using SAI.Branch.Bamba;
using SAI.Branch.Wattala;

namespace SAI
{
    public partial class Login : MetroForm
    {
        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void Sign_Click(object sender, EventArgs e)
        {
            KreationService.Log login = null;

            login = new KreationService.Log();
            try
            {

                login = new KreationService.Log();
                AcceptButton = Sign;
                login.Username = UserName.Text; /*assign textbox to string to pass server*/
                login.Password = Password.Text;
                login.type = comboBox_Type.Text;
                login.branch = comboBox_Branch.Text;

                String avl = client.login(login);/* Pass string to server and get return value then assign it to var */
                if (avl != login.type)
                {
                    MessageBox.Show("Retry, Incorrect Password or username");
                }

                else
                {
                    if (login.type == "Admin")
                    {
                        this.Hide();
                        Admin a = new Admin(login.Username);
                        a.ShowDialog();
                        this.Close();
                    }

                    else if (login.type == "Accountant" && login.branch == "Borella")
                    {
                        this.Hide();
                        Accountant ac = new Accountant(login.Username);
                        ac.ShowDialog();
                        this.Close();
                    }

                    else if (login.type == "Accountant" && login.branch == "Bamba")
                    {
                        this.Hide();
                        BAccountant bac = new BAccountant(login.Username);
                        bac.ShowDialog();
                        this.Close();
                    }

                    else if (login.type == "Accountant" && login.branch == "Wattala")
                    {
                        this.Hide();
                        WAccountant wac = new WAccountant(login.Username);
                        wac.ShowDialog();
                        this.Close();
                    }
                    else if (login.type == "Guest" && login.branch == "Borella")
                    {
                        this.Hide();
                        Guest g = new Guest();
                        g.ShowDialog();
                        this.Close();
                    }
                    else if (login.type == "Guest" && login.branch == "Bamba")
                    {
                        this.Hide();
                        BGuest bg = new BGuest();
                        bg.ShowDialog();
                        this.Close();
                    }
                    else if (login.type == "Guest" && login.branch == "Wattala")
                    {
                        this.Hide();
                        WGuest wg = new WGuest();
                        wg.ShowDialog();
                        this.Close();
                    }
                    else if (login.type == "Emp" && login.branch == "Borella")
                    {
                        this.Hide();
                        POS p = new POS(login.Username);
                        p.ShowDialog();
                        this.Close();
                    }
                    else if (login.type == "Emp" && login.branch == "Bamba")
                    {
                        this.Hide();
                        BPOS p = new BPOS(login.Username);
                        p.ShowDialog();
                        this.Close();
                    }
                    else if (login.type == "Emp" && login.branch == "Wattala")
                    {
                        this.Hide();
                        WPOS p = new WPOS(login.Username);
                        p.ShowDialog();
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
                    
                

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            String type = comboBox_Type.Text;
            if (type == "Admin")
            {
                comboBox_Branch.Enabled = false;
            }

            else
            {
                comboBox_Branch.Enabled = true;
            }
        }
    }
}
