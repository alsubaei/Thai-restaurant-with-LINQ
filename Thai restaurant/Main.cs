using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thai_restaurant
{
   public partial class Main : Form
   {
      public Main()
      {
         InitializeComponent();
      }

      private void Main_Load(object sender, EventArgs e)
      {

      }

      private void pictureBox2_Click(object sender, EventArgs e)
      {

      }

      private void Order_Click(object sender, EventArgs e)
      {
         this.Hide();
         Order order_form = new Order();
         order_form.Show();
      }

      private void Meal_Click(object sender, EventArgs e)
      {
         this.Hide();
         Meal meal_form = new Meal();
         meal_form.Show();
      }

      private void Customer_Click(object sender, EventArgs e)
      {
         this.Hide();
         Customer_Form customer_form = new Customer_Form();
         customer_form.Show();
      }

      private void pictureBox5_Click(object sender, EventArgs e)
      {

      }

      private void Category_Click(object sender, EventArgs e)
      {
         this.Hide();
         //Category category_form = new Category();
         //category_form.Show();
      }

      private void pictureBox3_Click(object sender, EventArgs e)
      {

      }

      private void pictureBox4_Click(object sender, EventArgs e)
      {

      }
   }
}
