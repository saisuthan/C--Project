﻿using System;
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

namespace SAI.Branch.Wattala
{
   
    public partial class WGuest : MetroForm
    {
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public WGuest()
        {
            InitializeComponent();
        }

        private void WGuest_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.SearchGuest_BranchWattala();
            dataGridView_wGuest.DataSource = ds.Tables[0];
            //dataGridView_wGuest.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

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
                msg.To.Add("saisuthanr@gmail.com");
                msg.CC.Add("miriamkumar123@gmail.com");
                msg.CC.Add("Mithunlaknath100@gmail.com");
                msg.From = new MailAddress("rsaisuthan@gmail.com");
                msg.Subject = "Record";
                msg.Body = "Guest viewed the Records from Wattala Branch";

                Client.Send(msg);
                //MetroMessageBox.Show(this, "Email Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            Hide();
            ln.ShowDialog();
            Close();
        }

        private void dataGridView_wGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
