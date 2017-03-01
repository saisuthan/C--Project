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

namespace SAI.Branch.Borrella
{
    public partial class POS : MetroForm
    {
        KreationService.KreationServiceClient client = new KreationService.KreationServiceClient();
        KreationService.Product product = new KreationService.Product();
        
        public POS(String login)
        {
            InitializeComponent();
            UserName.Text = login;
        }

        private void POS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fillProducts.POS' table. You can move, or remove it, as needed.
            //this.pOSTableAdapter.Fill(this.fillProducts.POS);
            // TODO: This line of code loads data into the 'kreationDataSet4.POS' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'kreationDataSet1.POS' table. You can move, or remove it, as needed.
            
                     

        }

        private void Bk_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            Hide();
            ln.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            product = new KreationService.Product();
            try
            {
                
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

        public void load_gridview()
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

        private void Proceed_Click(object sender, EventArgs e)
        {
            PrintReceipt();

           client.delete_pos();
          
           this.Hide();
           new POS("").Show();

            
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

        private void txtBox_Discount_Enter(object sender, EventArgs e)
        {
            
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Century Gothic", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Kreations  House of Cottons PVT LTD", new Font("Century Gothic", 18), new SolidBrush(Color.Black), startX, startY);           
            string top = "Item Name" + "Price".PadLeft(25) + "Quantity".PadLeft(25) + "Total".PadLeft(25);
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            string invoiceno1 = textBox1.Text;
            List<KreationService.Product> listofresults = client.productlist(invoiceno1).ToList();

            foreach (var item in listofresults)
            {
                String name = item.name;
                String Price = item.price;
                String qty = item.qty;
                string Total = item.total;
                string line = name.PadRight(30) + Price.PadRight(30) + qty.PadRight(30) + Total.PadRight(30);

                graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
                

                offset = offset + (int)fontHeight + 5; //make the spacing consistent


            }

            string discount = txtBox_Discount.Text;
            string total = txtBox_GrandTotal.Text;
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("Discount ".PadRight(22) + String.Format("{0:c}", discount), font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 20;

            graphic.DrawString("Total to pay " + String.Format("{0:c}", total), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            
        }

        private void dataGridView_pos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView_pos.Rows[e.RowIndex];

                txtBox_ID.Text = row.Cells[0].Value.ToString();
                               

            }
        }

        private void txtBox_Delete_Click(object sender, EventArgs e)
        {
            product = new KreationService.Product();
           product.barcode = txtBox_ID.Text;

           client.delete_item(product);

           load_gridview();
           dataGridView_pos.Update();
           dataGridView_pos.Refresh();  

        }

       
    }
}
