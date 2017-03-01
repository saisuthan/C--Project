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

namespace SAI.Branch.Borrella
{
    public partial class ViewAcc : MetroForm
    {
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public ViewAcc()
        {
            InitializeComponent();
        }

        private void ViewAcc_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.SearchGuest_BranchBorella();
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            AccEdit ae = new AccEdit();
            Hide();
            ae.ShowDialog();
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
           Accountant a = new Accountant("");
            Hide();
            a.ShowDialog();
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
