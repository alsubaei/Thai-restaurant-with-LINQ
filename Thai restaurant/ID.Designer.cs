namespace Thai_restaurant
{
   partial class ID
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.user = new System.Windows.Forms.PictureBox();
         this.CustomerId = new System.Windows.Forms.TextBox();
         this.Next = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
         this.SuspendLayout();
         // 
         // user
         // 
         this.user.Image = global::Thai_restaurant.Properties.Resources.id;
         this.user.Location = new System.Drawing.Point(84, 93);
         this.user.Name = "user";
         this.user.Size = new System.Drawing.Size(63, 60);
         this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.user.TabIndex = 16;
         this.user.TabStop = false;
         // 
         // CustomerId
         // 
         this.CustomerId.BackColor = System.Drawing.Color.AntiqueWhite;
         this.CustomerId.Font = new System.Drawing.Font("Tahoma", 18F);
         this.CustomerId.Location = new System.Drawing.Point(153, 104);
         this.CustomerId.Multiline = true;
         this.CustomerId.Name = "CustomerId";
         this.CustomerId.Size = new System.Drawing.Size(261, 38);
         this.CustomerId.TabIndex = 17;
//         this.CustomerId.TextChanged += new System.EventHandler(this.CustomerId_TextChanged);
         // 
         // Next
         // 
         this.Next.BackColor = System.Drawing.Color.DarkOrange;
         this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Next.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Next.ForeColor = System.Drawing.Color.White;
         this.Next.Location = new System.Drawing.Point(188, 206);
         this.Next.Name = "Next";
         this.Next.Size = new System.Drawing.Size(129, 43);
         this.Next.TabIndex = 18;
         this.Next.Text = "Next";
         this.Next.UseVisualStyleBackColor = false;
         this.Next.Click += new System.EventHandler(this.Next_Click);
         // 
         // ID
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.background1;
         this.ClientSize = new System.Drawing.Size(484, 261);
         this.Controls.Add(this.Next);
         this.Controls.Add(this.CustomerId);
         this.Controls.Add(this.user);
         this.Name = "ID";
         this.Text = "ID";
//         this.Load += new System.EventHandler(this.ID_Load);
         ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox user;
      private System.Windows.Forms.TextBox CustomerId;
      private System.Windows.Forms.Button Next;
   }
}