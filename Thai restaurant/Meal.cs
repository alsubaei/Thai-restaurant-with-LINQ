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
   public partial class Meal : Form
   {
        // Connection string
        static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);

      public int new_id;

      public Meal()
      {
         InitializeComponent();
      }

      private void Meal_Load(object sender, EventArgs e)
      {
         try
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Meal_View", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MealGridView.DataSource = dt;
         }
         catch (Exception ex)
         {

                MessageBox.Show("Connection is not opened.!!");
                MessageBox.Show(ex.Message + ex.StackTrace);
         }
         finally
         {
            // Connection close
            conn.Close();
         }

      }

      private void AddMeal_Click(object sender, EventArgs e)
      {
         AddMeal add_meal_form = new AddMeal();
         add_meal_form.ShowDialog();
      }

      private void UpdateMeal_Click(object sender, EventArgs e)
      {
         ID id_Meal_update_form = new ID();
         id_Meal_update_form.ShowDialog();
         new_id = id_Meal_update_form.id;
         UpdateMeal update_meal_form = new UpdateMeal();
         update_meal_form.last_id = new_id;
         update_meal_form.Show();
      }

      private void DeleteMeal_Click(object sender, EventArgs e)
      {
         ID id_Meal_delete_form = new ID();
         id_Meal_delete_form.ShowDialog();
         new_id = id_Meal_delete_form.id;

         SqlCommand cmd = new SqlCommand("delete from Meal_View where ( Meal_id='" + new_id + "')", conn);
         try
         {
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Meal deleted succesfully.");
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

      private void RefreshMeal_Click(object sender, EventArgs e)
      {
         // Create connection
         SqlConnection conn = new SqlConnection(connString);
         try
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Meal_View", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MealGridView.DataSource = dt;
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
