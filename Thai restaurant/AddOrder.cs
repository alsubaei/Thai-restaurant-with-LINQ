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
   public partial class AddOrder : Form
   {
      // Connection string
      static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);
      public AddOrder()
      {
         InitializeComponent();
      }

      private void reset_Click(object sender, EventArgs e)
      {
         CustomerID.Clear();
         DeliveringDate.Refresh();
         Meal.Clear();
         BookingDate.Refresh();
         DeliveryTime.Refresh();
         DeliveryPrice.Clear();
      }

      private void save_Click(object sender, EventArgs e)
         {
         // Create command
            SqlCommand cmd = new SqlCommand("insert into Order_View (Customer_name, Meal_name, Delivery_time, Delivery_price, Delivery_date, Booking_date) values ('" + CustomerID.Text + "', '" + Meal.Text + "', '" + DeliveryTime.Value.ToString() + "', '" + DeliveryPrice.Text + "' , '" + DeliveringDate.Value.ToString() + "' , '" + BookingDate.Value.ToString() + "')", conn);
         try
         {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Order added succesfully.");
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
