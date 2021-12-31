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
   public partial class UpdateCustomer : Form
   {
      public UpdateCustomer()
      {
         InitializeComponent();
      }
      // Connection string
      static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);

      public int last_id;

      private void save_Click(object sender, EventArgs e)
      {
         // Create command
         SqlCommand cmd = new SqlCommand("update Customer set Customer_name='" + CustomerName.Text + "' ,Customer_phone= '" + CustomerPhone.Text + "' ,Customer_address= '" + CustomerLocation.Text + "'  where (Customer_id='" + last_id + "')", conn);
         try
         {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Customer updated succesfully.");
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
   }
}
