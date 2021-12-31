namespace Thai_restaurant
{
   partial class UpdateMeal
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
         this.Save = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.MealCategory = new System.Windows.Forms.TextBox();
         this.user = new System.Windows.Forms.PictureBox();
         this.password = new System.Windows.Forms.PictureBox();
         this.MealName = new System.Windows.Forms.TextBox();
         this.MealCost = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
         this.SuspendLayout();
         // 
         // Save
         // 
         this.Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.Save.FlatAppearance.BorderSize = 2;
         this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(226)))));
         this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(172)))));
         this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Save.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(29)))));
         this.Save.Location = new System.Drawing.Point(523, 387);
         this.Save.Name = "Save";
         this.Save.Size = new System.Drawing.Size(96, 43);
         this.Save.TabIndex = 43;
         this.Save.Text = "Save";
         this.Save.UseVisualStyleBackColor = true;
         this.Save.Click += new System.EventHandler(this.Save_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Thai_restaurant.Properties.Resources.category;
         this.pictureBox1.Location = new System.Drawing.Point(328, 274);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(63, 60);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 42;
         this.pictureBox1.TabStop = false;
         // 
         // MealCategory
         // 
         this.MealCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.MealCategory.Font = new System.Drawing.Font("Tahoma", 18F);
         this.MealCategory.Location = new System.Drawing.Point(403, 278);
         this.MealCategory.Multiline = true;
         this.MealCategory.Name = "MealCategory";
         this.MealCategory.Size = new System.Drawing.Size(378, 50);
         this.MealCategory.TabIndex = 41;
         // 
         // user
         // 
         this.user.Image = global::Thai_restaurant.Properties.Resources.meal;
         this.user.Location = new System.Drawing.Point(328, 114);
         this.user.Name = "user";
         this.user.Size = new System.Drawing.Size(63, 60);
         this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.user.TabIndex = 39;
         this.user.TabStop = false;
         // 
         // password
         // 
         this.password.Image = global::Thai_restaurant.Properties.Resources.cost;
         this.password.Location = new System.Drawing.Point(328, 192);
         this.password.Name = "password";
         this.password.Size = new System.Drawing.Size(63, 60);
         this.password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.password.TabIndex = 38;
         this.password.TabStop = false;
         // 
         // MealName
         // 
         this.MealName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.MealName.Font = new System.Drawing.Font("Tahoma", 18F);
         this.MealName.Location = new System.Drawing.Point(403, 118);
         this.MealName.Multiline = true;
         this.MealName.Name = "MealName";
         this.MealName.Size = new System.Drawing.Size(378, 50);
         this.MealName.TabIndex = 37;
         // 
         // MealCost
         // 
         this.MealCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.MealCost.Font = new System.Drawing.Font("Tahoma", 18F);
         this.MealCost.Location = new System.Drawing.Point(403, 198);
         this.MealCost.Multiline = true;
         this.MealCost.Name = "MealCost";
         this.MealCost.Size = new System.Drawing.Size(378, 50);
         this.MealCost.TabIndex = 36;
         // 
         // UpdateMeal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.backgroung;
         this.ClientSize = new System.Drawing.Size(1370, 749);
         this.Controls.Add(this.Save);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.MealCategory);
         this.Controls.Add(this.user);
         this.Controls.Add(this.password);
         this.Controls.Add(this.MealName);
         this.Controls.Add(this.MealCost);
         this.Font = new System.Drawing.Font("Tahoma", 18F);
         this.Margin = new System.Windows.Forms.Padding(7);
         this.Name = "UpdateMeal";
         this.Text = "UpdateMeal";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Save;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox MealCategory;
      private System.Windows.Forms.PictureBox user;
      private System.Windows.Forms.PictureBox password;
      private System.Windows.Forms.TextBox MealName;
      private System.Windows.Forms.TextBox MealCost;


   }
}