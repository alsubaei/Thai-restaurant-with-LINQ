using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thai_restaurant
{
   public partial class Customer_Form : Form
   {
      // Connection string
       static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);

      public int new_id;

      public Customer_Form()
      {
         InitializeComponent();
      }

      private void Customer_Load(object sender, EventArgs e)
      { 
         try
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerGridView.DataSource = dt;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message + ex.StackTrace);
         }
         finally
         {
            // Connection close
            conn.Close();
         }
      }

      private void AddCustomer_Click(object sender, EventArgs e)
      {
         AddCustomer add_customer_form = new AddCustomer();
         add_customer_form.ShowDialog();
      }

      private void UpdateCustomer_Click(object sender, EventArgs e)
      {
         ID id_Customer_update_form = new ID();
         id_Customer_update_form.ShowDialog();
         new_id = id_Customer_update_form.id;
         UpdateCustomer update_customer_form = new UpdateCustomer();
         update_customer_form.last_id = new_id;
         update_customer_form.Show();
      }

      private void DeleteCustomer_Click(object sender, EventArgs e)
      {
            ID id_Customer_delete_form = new ID();
            id_Customer_delete_form.ShowDialog();
            new_id = id_Customer_delete_form.id;
            SqlCommand cmd = new SqlCommand("delete from Customer where ( Customer_id='" + new_id + "')", conn);
            try
            {
               conn.Open();
               cmd.ExecuteNonQuery();
               MessageBox.Show("The Customer deleted succesfully.");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
               // Connection close
               conn.Close();
            }
       }

      private void RefreshCustomer_Click(object sender, EventArgs e)
      {
         try
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustomerGridView.DataSource = dt;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message + ex.StackTrace);
         }
         finally
         {
            // Connection close
            conn.Close();
         }
      }
   }
}
