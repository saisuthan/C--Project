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
using System.ServiceModel;

namespace SAI
{
    public partial class Access : MetroForm

    {
        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public Access()
        {
            InitializeComponent();
        }

        private void Access_Load(object sender, EventArgs e)
        {
            load_gridview();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Bk_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin("");
            Hide();
            ad.ShowDialog();
            Close();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            try
            {
                KreationService.Log log = null;

                log = new KreationService.Log();

                log.Username = UserName.Text;
                log.Password = PassWord.Text;
                log.type = Type.Text;
                log.branch = bid.Text;
                int q = client.add_Ac(log);
                if (q > 0)
                {
                    MetroMessageBox.Show(this, "User Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MetroMessageBox.Show(this, "Adding Incomplete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            load_gridview();
            dataGridView1.Update();
            dataGridView1.Refresh();

            UserName.Text = string.Empty;
            PassWord.Text = string.Empty;
            Type.Text = string.Empty;
            bid.Text = string.Empty;   
            
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
           
              try
            {

                 string Username= txtBox_Username.Text;
                


                if (MessageBox.Show
                   ("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                {
                    client.Deleteusername(Username);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              load_gridview();
              dataGridView1.Update();
              dataGridView1.Refresh();
        }

        public void load_gridview() 
        {

            DataSet ds = new DataSet();
            ds = client.SearchUser();
            dataGridView1.DataSource = ds.Tables[0];
           
        
        }

     
        }
    }

