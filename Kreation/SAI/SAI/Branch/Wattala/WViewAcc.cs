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

namespace SAI.Branch.Wattala
{
    public partial class WViewAcc : MetroForm
    {
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public WViewAcc()
        {
            InitializeComponent();
        }

        private void WViewAcc_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.SearchGuest_BranchWattala();
            dataGridView_wGuest.DataSource = ds.Tables[0];
            //dataGridView_wGuest.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            WAccEdit wae = new WAccEdit();
            Hide();
            wae.ShowDialog();
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            WAccountant wa = new WAccountant("");
            Hide();
            wa.ShowDialog();
            Close();
        }
    }
}
