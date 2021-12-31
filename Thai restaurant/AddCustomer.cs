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
   public partial class AddCustomer : Form
   {
      public AddCustomer()
      {
         InitializeComponent();
      }
      // Connection string
      static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);
      private void reset_Click(object sender, EventArgs e)
      {
         customerName.Clear();
         customerPhone.Clear();
         customerLocation.Clear();
      }
      private void Save_Click(object sender, EventArgs e)
      {
        // Create command
         SqlCommand cmd = new SqlCommand("insert into Customer values ('" + customerName.Text + "' , '" + customerPhone.Text + "' , '" +customerLocation.Text + "')", conn);
         try
         {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Customer added succesfully.");
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
         this.Hide();
      }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
