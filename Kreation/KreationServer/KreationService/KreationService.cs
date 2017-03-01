using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KreationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class KreationService : IKreationService

    {

        /* Database String */
        public static string dbstrng = "Data Source=SPIDERMAN;Initial Catalog=Kreation;Integrated Security=True";
        /* create secondary database object */
        SqlConnection conn = new SqlConnection(dbstrng);

        /* LOGIN */
        public String login(Log login)
        {
            //SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand("SELECT Type FROM Log  WHERE Username = '" +login.username + "' AND Password = '" + login.password + "'", conn);
            conn.Open();
            String str = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            return str;
        }

        public void Deleteusername(String username)
        {
            SqlCommand myCommand1 = new SqlCommand("Delete From Log where Username ='" + username + "'", conn);
            conn.Open();
            myCommand1.ExecuteNonQuery();
            conn.Close();

        }

        public void Searchusername(String username)
        {
            SqlCommand myCommand1 = new SqlCommand("SELECT * FROM Log WHERE Username like ='" + username + "%' ", conn);
            conn.Open();
            myCommand1.ExecuteNonQuery();
            conn.Close();

        }


        /* Access */


       public int add_Ac(Log login)
    
    {
            int i = 0;
            conn.Open();
            string qrynt = "INSERT INTO Log (Username,Password,Type,Branch)VALUES('" + login.username + "','" +login.password + "','" +login.Type + "','" +login.Branch + "')";
            SqlCommand cmd = new SqlCommand(qrynt, conn);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
    }

      
       public void delete_pos()
       {
           SqlCommand myCommand3 = new SqlCommand("DELETE  FROM POS  WHERE InvoiceNo  = '123'", conn);

           conn.Open();
           myCommand3.ExecuteNonQuery();
           conn.Close();
       }






        /* Accounts */


       public int up_Acc(Accounts Accounts)
       {
           int i = 0;
           conn.Open();
           string qrynt = "INSERT INTO Accounts (BranchId,TrNo,Description,Debit,Credit)VALUES('" + Accounts.branchId + "','" + Accounts.trNo + "','" + Accounts.description + "','" + Accounts.debit + "','" + Accounts.credit+ "')";
           SqlCommand cmd = new SqlCommand(qrynt, conn);
           i = cmd.ExecuteNonQuery();
           conn.Close();
           return i;
       }

       public DataSet accDetail(Accounts Account)
       {
           string strSql = "Select BranchId,TrNo,Description,Debit,Credit from Accounts where TrNo='" + Account.trNo+ "'";
           DataTable table = new DataTable();
           table = this.GetData(strSql);
           DataSet set = new DataSet();
           set.Tables.Add(table);
           return set;
       }

       public int ed_acc(Accounts Accounts)
       {
           int i = 0;
           conn.Open();
           string qrynt = "UPDATE Accounts set Description='" + Accounts.description + "',Debit='" + Accounts.debit + "',Credit='" + Accounts.credit + "' where TrNo='" + Accounts.trNo + "'";
           SqlCommand cmd = new SqlCommand(qrynt, conn);
           i = cmd.ExecuteNonQuery();
           conn.Close();
           return i;
       }


        /* Products */


       public int add_prod(Product product)
       {
        int i = 0;
           conn.Open();
           string qrynt = "INSERT INTO Product (Barcode,Name,Price,Profit)VALUES('" + product.Barcode + "','" + product.Name + "','" + product.Price + "','" + product.Profit + "')";
           SqlCommand cmd = new SqlCommand(qrynt, conn);
           i = cmd.ExecuteNonQuery();
           conn.Close();
           return i;
       }

       public DataTable GetData(string sql)
       {
           SqlCommand cmd = new SqlCommand(sql, conn);
           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           DataTable table = new DataTable();
           conn.Open();
           adapter.Fill(table);
           conn.Close();
           return table;
       }

       public DataSet ProDetail(Product Product)
       {
           string strSql = "Select Barcode,Name,Price,Profit from Product where Barcode='" + Product.Barcode + "'";
           DataTable table = new DataTable();
           table = this.GetData(strSql);
           DataSet set = new DataSet();
           set.Tables.Add(table);
           return set;
       }


       public int ed_prod(Product Product)
       {
           int i = 0;
           conn.Open();
           string qrynt = "UPDATE Product set Name='" +Product.Name + "',Price='" + Product.Price + "',Profit='" + Product.Profit + "' where Barcode='" + Product.Barcode + "'";
           SqlCommand cmd = new SqlCommand(qrynt, conn);
           i = cmd.ExecuteNonQuery();
           conn.Close();
           return i;
       }

        /* view */

       public DataSet SearchUser() 
       {

           conn.Open();
           SqlCommand cmd1 = new SqlCommand("SELECT * FROM Log ", conn);
           SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
           DataSet ds1 = new DataSet();
           sda1.Fill(ds1);
           cmd1.ExecuteNonQuery();
           conn.Close();
           return ds1;
       }
      

        public DataSet SearchGuest_BranchBorella()
        {

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Accounts WHERE BranchId = 'Borella'", conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            cmd1.ExecuteNonQuery();
            conn.Close();
            return ds1;

        }

        public DataSet SearchGuest_BranchWattala()
        {

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Accounts WHERE BranchId = 'Wattala'", conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            cmd1.ExecuteNonQuery();
            conn.Close();
            return ds1;

        }
        public DataSet SearchGuest_BranchBamba()
        {

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Accounts WHERE BranchId = 'Bamba'", conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            cmd1.ExecuteNonQuery();
            conn.Close();
            return ds1;

        }
        public DataSet SearchAllProducts(String ID)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * From POS where InvoiceNo='"+ID+"'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();
            return ds;

        }

        public String Get_Sum_of_Charges(String invoice)
        {
            conn.Open();
            SqlCommand total = new SqlCommand("SELECT SUM(cast(Total as integer)) FROM POS  where InvoiceNo = '" + invoice + "'", conn);
            String additionalChargesTotal = total.ExecuteScalar().ToString();
            conn.Close();
            return additionalChargesTotal;

        }

        public int GetPrice(String ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT Price From Product where Barcode='" + ID + "'", conn);
            conn.Open();
            int str = Convert.ToInt16(cmd.ExecuteScalar());
            conn.Close();
            return str;

        }

        public String Name(String ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT Name From Product where Barcode='" + ID + "'", conn);
            conn.Open();
            string str = cmd.ExecuteScalar().ToString();
            conn.Close();
            return str;

        }

        public void InsertPos(Product product) 
        {
            SqlCommand myCommand1 = new SqlCommand("INSERT INTO POS (InvoiceNo,Barcode,Name,Qty,Price,Total) VALUES ('" + product.InvoiceNo + "','" + product.Barcode + "','" + product.Name + "','" + product.Qty + "','" + product.Price + "','" + product.Total + "')", conn);
            conn.Open();
            myCommand1.ExecuteNonQuery();
            conn.Close();
            
        }
        public DataSet FillProducts(String invoiceNo)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM POS where InvoiceNo='"+invoiceNo+"", conn);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            cmd1.ExecuteNonQuery();
            conn.Close();
            
            return ds1;

        }


        public List<Product> productlist(String invoiceno) 
        {
            SqlDataReader reader = null;


            SqlCommand myCommand = new SqlCommand("SELECT * FROM POS " +
                          "WHERE InvoiceNo ='" + invoiceno + "'", conn);
            conn.Open();
            reader = myCommand.ExecuteReader();

            List<Product> listofresults = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product();
                product.Name =reader["Name"].ToString();
                product.Price = reader["Price"].ToString();
                product.Qty = reader["Qty"].ToString();
                product.Total = reader["Total"].ToString();

                listofresults.Add(product);
            }

            reader.Close();
            conn.Close();
            return listofresults;
        }

        public void delete_item(Product product)
        {
            SqlCommand myCommand3 = new SqlCommand("DELETE  FROM POS  WHERE Barcode  = '" + product.Barcode+ "'", conn);

            conn.Open();           
            myCommand3.ExecuteNonQuery();
            conn.Close();
        }




    }
}
