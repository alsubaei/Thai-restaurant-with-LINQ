namespace Thai_restaurant
{
   partial class Form1
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
         this.AdminPassword = new System.Windows.Forms.TextBox();
         this.login = new System.Windows.Forms.Button();
         this.AdminName = new System.Windows.Forms.TextBox();
         this.password = new System.Windows.Forms.PictureBox();
         this.user = new System.Windows.Forms.PictureBox();
         this.exit = new System.Windows.Forms.Button();
         this.reset = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
         this.SuspendLayout();
         // 
         // AdminPassword
         // 
         this.AdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.AdminPassword.Font = new System.Drawing.Font("Tahoma", 18F);
         this.AdminPassword.Location = new System.Drawing.Point(462, 240);
         this.AdminPassword.Multiline = true;
         this.AdminPassword.Name = "AdminPassword";
         this.AdminPassword.Size = new System.Drawing.Size(378, 50);
         this.AdminPassword.TabIndex = 2;
         this.AdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.AdminPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // login
         // 
         this.login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.login.FlatAppearance.BorderSize = 2;
         this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
         this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
         this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.login.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.login.Location = new System.Drawing.Point(460, 355);
         this.login.Name = "login";
         this.login.Size = new System.Drawing.Size(96, 43);
         this.login.TabIndex = 0;
         this.login.Text = "Login";
         this.login.UseVisualStyleBackColor = true;
         this.login.Click += new System.EventHandler(this.button1_Click);
         // 
         // AdminName
         // 
         this.AdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.AdminName.Font = new System.Drawing.Font("Tahoma", 18F);
         this.AdminName.Location = new System.Drawing.Point(462, 160);
         this.AdminName.Multiline = true;
         this.AdminName.Name = "AdminName";
         this.AdminName.Size = new System.Drawing.Size(378, 50);
         this.AdminName.TabIndex = 6;
         this.AdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // password
         // 
         this.password.Image = global::Thai_restaurant.Properties.Resources.password;
         this.password.Location = new System.Drawing.Point(387, 234);
         this.password.Name = "password";
         this.password.Size = new System.Drawing.Size(63, 60);
         this.password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.password.TabIndex = 7;
         this.password.TabStop = false;
         // 
         // user
         // 
         this.user.Image = global::Thai_restaurant.Properties.Resources.user;
         this.user.Location = new System.Drawing.Point(387, 156);
         this.user.Name = "user";
         this.user.Size = new System.Drawing.Size(63, 60);
         this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.user.TabIndex = 8;
         this.user.TabStop = false;
         // 
         // exit
         // 
         this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.exit.FlatAppearance.BorderSize = 2;
         this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
         this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
         this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.exit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.exit.Location = new System.Drawing.Point(701, 355);
         this.exit.Name = "exit";
         this.exit.Size = new System.Drawing.Size(96, 43);
         this.exit.TabIndex = 9;
         this.exit.Text = "Exit";
         this.exit.UseVisualStyleBackColor = true;
         this.exit.Click += new System.EventHandler(this.exit_Click);
         // 
         // reset
         // 
         this.reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.reset.FlatAppearance.BorderSize = 2;
         this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
         this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
         this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.reset.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.reset.Location = new System.Drawing.Point(576, 355);
         this.reset.Name = "reset";
         this.reset.Size = new System.Drawing.Size(96, 43);
         this.reset.TabIndex = 10;
         this.reset.Text = "Reset";
         this.reset.UseVisualStyleBackColor = true;
         this.reset.Click += new System.EventHandler(this.reset_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.backgroung;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.reset);
         this.Controls.Add(this.exit);
         this.Controls.Add(this.user);
         this.Controls.Add(this.password);
         this.Controls.Add(this.AdminName);
         this.Controls.Add(this.login);
         this.Controls.Add(this.AdminPassword);
         this.Name = "Form1";
         this.Text = "Login";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox AdminPassword;
      private System.Windows.Forms.Button login;
      private System.Windows.Forms.TextBox AdminName;
      private System.Windows.Forms.PictureBox password;
      private System.Windows.Forms.PictureBox user;
      private System.Windows.Forms.Button exit;
      private System.Windows.Forms.Button reset;
   }
}

