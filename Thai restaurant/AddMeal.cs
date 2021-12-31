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
   public partial class AddMeal : Form
   {
      // Connection string
      static string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\New folder\Database\C#\Thai restaurant\Thai restaurant\Thai restaurant\ThaiRestaurant.mdf;Integrated Security=True";
      // Create connection
      SqlConnection conn = new SqlConnection(connString);

      public AddMeal()
      {
         InitializeComponent();
      }

      private void reset_Click(object sender, EventArgs e)
      {
         MealName.Clear();
         MealCost.Clear();
         MealCategory.ResetText();
      }

      private void save_Click(object sender, EventArgs e)
      {
         try
         {
            // Create command
            SqlCommand cmd = new SqlCommand("Insert into Meal (Meal_name , Meal_cost) values ('" + MealName.Text.ToString() + "' , '" + Int32.Parse(MealCost.Text.ToString()) + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Meal added succesfully.");
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
