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
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         try
         {
            if (AdminName.Text.ToString() == "Admin" && Int32.Parse(AdminPassword.Text.ToString()) == 1234)
            {
               this.Hide();
               Main main_form = new Main();
               main_form.Show();
            }
            else
            {
               MessageBox.Show("Please re insert Username and Password");
               AdminName.Clear();
               AdminPassword.Clear();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message + ex.StackTrace);
         }
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void exit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void reset_Click(object sender, EventArgs e)
      {
         AdminName.Clear();
         AdminPassword.Clear();
      }
   }
}
