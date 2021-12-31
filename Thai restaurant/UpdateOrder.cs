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
   public partial class UpdateOrder : Form
   {
      public UpdateOrder()
      {
         InitializeComponent();
      }

      // Connection string
      static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);

      public int last_id;

      private void Save_Click(object sender, EventArgs e)
      {
         // Create command
         SqlCommand cmd = new SqlCommand("update Order_View set Customer_name='" + CustomerID.Text + "', Meal_name='" + Meal.Text + "', Delivery_time='" + DeliveryTime.Value.ToString() + "', Delivery_price='" + DeliveryPrice.Text + "', Delivery_date '" + DeliveringDate.Value.ToString() + "', Booking_date'" + BookingDate.Value.ToString() +"' where ( Order_id='" + last_id + "')", conn);
         cmd.ExecuteNonQuery();
         try
         {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Order updated succesfully.");
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
