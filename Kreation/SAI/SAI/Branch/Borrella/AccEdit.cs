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
using System.Net;
using System.Net.Mail;

namespace SAI.Branch.Borrella
{
    public partial class AccEdit : MetroForm
    {
        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public AccEdit()
        {
            InitializeComponent();
        }

        private void AccEdit_Load(object sender, EventArgs e)
        {

        }

        private void Bk_Click(object sender, EventArgs e)
        {
           ViewAcc v = new ViewAcc();
            Hide();
           v.ShowDialog();
            Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                KreationService.Accounts acc = null;

                acc = new KreationService.Accounts();

                if
                    (Type.SelectedItem.Equals("Debit"))
                {
                    acc.Debit = Amount.Text;
                }

                else if (Type.SelectedItem.Equals("Credit"))
                {
                    acc.Credit = Amount.Text;
                }

                acc.TrNo = TrNo.Text;
                acc.Description = Desc.Text;
                //acc.Debit = null;
                //acc.Credit = null;

                int q = client.ed_acc(acc);
                if (q > 0)
                {
                    MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


            try
            {
                SmtpClient Client = new SmtpClient("smtp.gmail.com");
                Client.Port = 587;
                Client.EnableSsl = true;
                Client.Timeout = 100000;
                Client.DeliveryMethod = SmtpDeliveryMethod.Network;
                Client.UseDefaultCredentials = false;
                Client.Credentials = new NetworkCredential(
                  "rsaisuthan@gmail.com", "sai19198");
                MailMessage msg = new MailMessage();
                msg.To.Add("saisuthanr@gmail.com" );
                msg.CC.Add("miriamkumar123@gmail.com");
                msg.CC.Add("Mithunlaknath100@gmail.com");
                msg.From = new MailAddress("rsaisuthan@gmail.com");
                msg.Subject = "Record";
                msg.Body = "Record Have Been Amended in the Borrella Branch";
                
                Client.Send(msg);
                MetroMessageBox.Show(this, "Email Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                KreationService.Accounts acc = null;

                acc = new KreationService.Accounts();
                acc.TrNo = TrNoSr.Text;

                DataSet set = new DataSet();
                DataTable table = new DataTable();

                set = client.accDetail(acc);

                table = set.Tables[0];


                //textBox1.Text = table.Rows[0][0].ToString();
                TrNo.Text = table.Rows[0][1].ToString();
                Desc.Text = table.Rows[0][2].ToString();
                Type.Text = table.Namespace.ToString();
                Amount.Text = table.Rows[0][3] + table.Rows[0][4].ToString();
                //Amount.Text = table.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Desc_Click(object sender, EventArgs e)
        {

        }
    }
}
