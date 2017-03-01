using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SAI.Branch.Bamba
{
    public partial class BPOS : MetroForm
    {

        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        public BPOS(String login)
        {
            InitializeComponent();
            UserName.Text = login;
        }

        private void BPOS_Load(object sender, EventArgs e)
        {

        }

        private void Bk_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            Hide();
            ln.ShowDialog();
            Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                KreationService.Product product = new KreationService.Product();
                product = new KreationService.Product();
                string id = txtBox_ID.Text;
                int qty = Convert.ToInt16(txtBox_Qty.Text);
                int price = client.GetPrice(id);
                string name = client.Name(id);

                int total = (qty * price);


                product.invoiceno = textBox1.Text;
                product.barcode = txtBox_ID.Text;
                product.name = name;
                product.qty = Convert.ToString(qty);
                product.price = Convert.ToString(price);
                product.total = Convert.ToString(total);

                client.InsertPos(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            load_gridview();
            dataGridView_pos.Update();
            dataGridView_pos.Refresh();        
            
        }

        private void load_gridview()

        {
            try
            {
                string invoiceno1 = textBox1.Text;

                DataSet ds = new DataSet();
                ds = client.SearchAllProducts(invoiceno1);
                dataGridView_pos.DataSource = ds.Tables[0];


                int sum = 0;
                for (int x = 0; x < dataGridView_pos.Rows.Count; x++)
                {
                    sum += Convert.ToInt32(dataGridView_pos.Rows[x].Cells[4].Value);
                }

                txtBox_Sub.Text = sum.ToString();

                txtBox_ID.Text = string.Empty;
                txtBox_Qty.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
           
        }

        private void dataGridView_pos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            client.delete_pos();
            //PrintDialog printDialog = new PrintDialog();

            //PrintDocument printDocument = new PrintDocument();

            //printDialog.Document = printDocument; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            //DialogResult result = printDialog.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    printDocument.Print();

            //}
            this.Hide();
            new BPOS("").Show();
        }

        private void Discount_Click(object sender, EventArgs e)

        {
            try
            {
                double discount = Convert.ToDouble(txtBox_Discount.Text);
                int subtotal = Convert.ToInt32(txtBox_Sub.Text);

                double percentage = (1 - discount);
                double grand = (percentage * subtotal);
                txtBox_GrandTotal.Text = grand.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //float x = e.MarginBounds.Left;
            //float y = e.MarginBounds.Top;
            //Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            //this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            //e.Graphics.DrawImage((Image)bmp, x, y);
        }
    }
}
