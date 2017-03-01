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
using SAI.Branch.Borrella;
using SAI.Branch.Bamba;
using SAI.Branch.Wattala;

namespace SAI.Branch.Borrella
{
    public partial class SelBranch : MetroForm
    {
        public SelBranch()
        {
            InitializeComponent();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            BGuest ps = new BGuest();
            Hide();
            ps.ShowDialog();
            Close();
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            Guest ps = new Guest();
            Hide();
            ps.ShowDialog();
            Close();
        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            WGuest ps = new WGuest();
            Hide();
            ps.ShowDialog();
            Close();
        }
    }
}
