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

namespace SAI.Branch.Bamba
{
    public partial class BViewAcc : MetroForm
    {
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public BViewAcc()
        {
            InitializeComponent();
        }

        private void BViewAcc_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.SearchGuest_BranchBamba();
            dataGridView_bGuest.DataSource = ds.Tables[0];
            //dataGridView_bGuest.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BAccountant bac = new BAccountant("");
            Hide();
            bac.ShowDialog();
            Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            BAccEdit bae = new BAccEdit();
            Hide();
            bae.ShowDialog();
            Close();
        }
    }
}
