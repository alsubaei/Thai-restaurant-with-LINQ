namespace Thai_restaurant
{
   partial class UpdateCustomer
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
         this.save = new System.Windows.Forms.Button();
         this.user = new System.Windows.Forms.PictureBox();
         this.password = new System.Windows.Forms.PictureBox();
         this.CustomerName = new System.Windows.Forms.TextBox();
         this.CustomerPhone = new System.Windows.Forms.TextBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.CustomerLocation = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // save
         // 
         this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.save.FlatAppearance.BorderSize = 2;
         this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
         this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
         this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.save.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.save.Location = new System.Drawing.Point(586, 383);
         this.save.Name = "save";
         this.save.Size = new System.Drawing.Size(96, 43);
         this.save.TabIndex = 17;
         this.save.Text = "Save";
         this.save.UseVisualStyleBackColor = true;
         this.save.Click += new System.EventHandler(this.save_Click);
         // 
         // user
         // 
         this.user.Image = global::Thai_restaurant.Properties.Resources.user;
         this.user.Location = new System.Drawing.Point(392, 113);
         this.user.Name = "user";
         this.user.Size = new System.Drawing.Size(63, 60);
         this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.user.TabIndex = 15;
         this.user.TabStop = false;
         // 
         // password
         // 
         this.password.Image = global::Thai_restaurant.Properties.Resources.customer_phone;
         this.password.Location = new System.Drawing.Point(392, 191);
         this.password.Name = "password";
         this.password.Size = new System.Drawing.Size(63, 60);
         this.password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.password.TabIndex = 14;
         this.password.TabStop = false;
         // 
         // CustomerName
         // 
         this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.CustomerName.Font = new System.Drawing.Font("Tahoma", 18F);
         this.CustomerName.Location = new System.Drawing.Point(467, 117);
         this.CustomerName.Multiline = true;
         this.CustomerName.Name = "CustomerName";
         this.CustomerName.Size = new System.Drawing.Size(378, 50);
         this.CustomerName.TabIndex = 13;
         // 
         // CustomerPhone
         // 
         this.CustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.CustomerPhone.Font = new System.Drawing.Font("Tahoma", 18F);
         this.CustomerPhone.Location = new System.Drawing.Point(467, 197);
         this.CustomerPhone.Multiline = true;
         this.CustomerPhone.Name = "CustomerPhone";
         this.CustomerPhone.Size = new System.Drawing.Size(378, 50);
         this.CustomerPhone.TabIndex = 12;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Thai_restaurant.Properties.Resources.customer_location;
         this.pictureBox1.Location = new System.Drawing.Point(392, 273);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(63, 60);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 19;
         this.pictureBox1.TabStop = false;
         // 
         // CustomerLocation
         // 
         this.CustomerLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.CustomerLocation.Font = new System.Drawing.Font("Tahoma", 18F);
         this.CustomerLocation.Location = new System.Drawing.Point(467, 277);
         this.CustomerLocation.Multiline = true;
         this.CustomerLocation.Name = "CustomerLocation";
         this.CustomerLocation.Size = new System.Drawing.Size(378, 50);
         this.CustomerLocation.TabIndex = 18;
         // 
         // UpdateCustomer
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.backgroung;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.CustomerLocation);
         this.Controls.Add(this.save);
         this.Controls.Add(this.user);
         this.Controls.Add(this.password);
         this.Controls.Add(this.CustomerName);
         this.Controls.Add(this.CustomerPhone);
         this.Name = "UpdateCustomer";
         this.Text = "Update Customer";
//         this.Load += new System.EventHandler(this.UpdateCustomer_Load);
         ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button save;
      private System.Windows.Forms.PictureBox user;
      private System.Windows.Forms.PictureBox password;
      private System.Windows.Forms.TextBox CustomerName;
      private System.Windows.Forms.TextBox CustomerPhone;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox CustomerLocation;
   }
}