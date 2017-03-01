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

namespace SAI
{
    public partial class EditProduct : MetroForm
    {

        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Bk_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin("");
            Hide();
            ad.ShowDialog();
            Close();
        }

        private void Srch_Click(object sender, EventArgs e)
        {
            try
            {
                KreationService.Product prd = null;

                prd = new KreationService.Product();

                prd.barcode = ProNo.Text;

                DataSet set = new DataSet();
                DataTable table = new DataTable();

                set = client.ProDetail(prd);

                table = set.Tables[0];
           
           
                //textBox1.Text = table.Rows[0][0].ToString();
                ProdNo.Text = table.Rows[0][0].ToString();
                ProName.Text=table.Rows[0][1].ToString();
                ProPrice.Text=table.Rows[0][2].ToString();
                Profit.Text = table.Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Updt_Click(object sender, EventArgs e)
        {
            try
            {
                KreationService.Product prd = null;

                prd = new KreationService.Product();

                prd.barcode = ProNo.Text;
                prd.name = ProName.Text;
                prd.price = ProPrice.Text;
                prd.profit = Profit.Text;
                int q = client.ed_prod(prd);
                if (q > 0)
                {
                    MetroMessageBox.Show(this, "Product Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        }
    }
}
