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
   public partial class Start : Form
   {
      public Start()
      {
         InitializeComponent();
      }

      private void First_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form1 login_form = new Form1();
         login_form.Show();
      }
   }
}
