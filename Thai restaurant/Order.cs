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
   public partial class Order : Form
   {
      // Connection string
      static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);

      public int new_id;

      public Order()
      {
         InitializeComponent();
      }

      private void Order_Load(object sender, EventArgs e)
      {
         try
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Order_View", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderGridView.DataSource = dt;
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

      private void AddOrder_Click(object sender, EventArgs e)
      {
        AddOrder add_order_form = new AddOrder();
         add_order_form.ShowDialog();
      }

      private void UpdateOrder_Click(object sender, EventArgs e)
      {
         ID id_Order_update_form = new ID();
         id_Order_update_form.ShowDialog();
         new_id = id_Order_update_form.id;
         UpdateOrder update_order_form = new UpdateOrder();
         update_order_form.last_id = new_id;
         update_order_form.Show();
      }

      private void DeleteOrder_Click(object sender, EventArgs e)
      {
         ID id_Order_delete_form = new ID();
         id_Order_delete_form.ShowDialog();
         new_id = id_Order_delete_form.id;
         SqlCommand cmd = new SqlCommand("delete from Order_View where ( Order_id='" + new_id + "')", conn);
         try
         {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Order deleted succesfully.");
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

      private void RefreshOrder_Click(object sender, EventArgs e)
      {
        try
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Order_View", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderGridView.DataSource = dt;
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
