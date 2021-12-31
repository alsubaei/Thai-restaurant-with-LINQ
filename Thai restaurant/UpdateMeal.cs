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
   public partial class UpdateMeal : Form
   {
      public UpdateMeal()
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
         try
         {
            // Create command
            SqlCommand cmd = new SqlCommand("update Meal_View set Meal_name='" + MealName.Text.ToString() + "', Meal_cost='" + Int32.Parse(MealCost.Text.ToString()) + "',Category_name='" + MealCategory.Text.ToString() + "' where ( Meal_id='" + last_id + "')", conn);
         cmd.ExecuteNonQuery();
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Meal updated succesfully.");
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
