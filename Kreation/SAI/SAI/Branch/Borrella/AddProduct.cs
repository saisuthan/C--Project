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
    public partial class AddProduct : MetroForm
    {
        /* Create a object of Service */
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void Bk_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin("");
            Hide();
            ad.ShowDialog();
            Close();
        }

        private void Edt_Click(object sender, EventArgs e)
        {
            EditProduct ep = new EditProduct();
            Hide();
            ep.ShowDialog();
            Close();
        }

        private void Add_Click(object sender, EventArgs e)

        {
            try
            {
                KreationService.Product prd = null;

                prd = new KreationService.Product();

                prd.barcode = ProNo.Text;
                prd.name = ProName.Text;
                prd.price = Price.Text;
                prd.profit = Profit.Text;
                int q = client.add_prod(prd);
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

             ProNo.Text = string.Empty;
             ProName.Text =string.Empty;
             Price.Text =string.Empty;
             Profit.Text = string.Empty;
        }

        private void Profit_Click(object sender, EventArgs e)
        {

        }
    }
}
