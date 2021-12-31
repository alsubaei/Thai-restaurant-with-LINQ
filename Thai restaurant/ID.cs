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
   public partial class ID : Form
   {
      public ID()
      {
         InitializeComponent();
      }
      public int id;
      public void Next_Click(object sender, EventArgs e)
      {
         try
         {
            id = Int32.Parse(CustomerId.Text.ToString());
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message + "  " + "Just Enter Numbers.");
         }
         this.Hide();
      }
   }
}
