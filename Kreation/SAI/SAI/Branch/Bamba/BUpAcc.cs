using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SAI.Branch.Bamba
{
    public partial class BUpAcc : MetroForm
    {
        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public BUpAcc()
        {
            InitializeComponent();
        }

        private void BUpAcc_Load(object sender, EventArgs e)
        {

        }

        private void Bk_Click(object sender, EventArgs e)
        {
            BViewAcc bva = new BViewAcc();
            Hide();
            bva.ShowDialog();
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

                acc.BranchId = "Bamba";
                acc.TrNo = TrNo.Text;
                acc.Description = Desc.Text;

                int q = client.up_Acc(acc);
                if (q > 0)
                {
                    MetroMessageBox.Show(this, "Transaction Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MetroMessageBox.Show(this, "Transaction Incomplete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            email();

        }


        public void email()
        {
            try
            {
                int amount = Convert.ToInt32(Amount.Text);
                if (amount >= 500000)
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
                    msg.To.Add("saisuthanr@gmail.com");
                    msg.CC.Add("miriamkumar123@gmail.com");
                    msg.CC.Add("Mithunlaknath100@gmail.com");
                    msg.From = new MailAddress("rsaisuthan@gmail.com");
                    msg.Subject = "Record";
                    msg.Body = "Transaction more than 500000 have been taken place from Bambalapitiya Branch";

                    Client.Send(msg);
                    //MetroMessageBox.Show(this, "Email Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    TrNo.Text = string.Empty;
                    Desc.Text = string.Empty;
                    Amount.Text = string.Empty;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
