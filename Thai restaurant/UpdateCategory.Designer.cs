namespace Thai_restaurant
{
   partial class UpdateCategory
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
         this.CategoryName = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
         this.Save.Location = new System.Drawing.Point(589, 285);
         this.Save.Name = "Save";
         this.Save.Size = new System.Drawing.Size(96, 43);
         this.Save.TabIndex = 46;
         this.Save.Text = "Save";
         this.Save.UseVisualStyleBackColor = true;
         this.Save.Click += new System.EventHandler(this.Save_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Thai_restaurant.Properties.Resources.category;
         this.pictureBox1.Location = new System.Drawing.Point(391, 179);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(63, 60);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 45;
         this.pictureBox1.TabStop = false;
         // 
         // CategoryName
         // 
         this.CategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.CategoryName.Font = new System.Drawing.Font("Tahoma", 18F);
         this.CategoryName.Location = new System.Drawing.Point(466, 183);
         this.CategoryName.Multiline = true;
         this.CategoryName.Name = "CategoryName";
         this.CategoryName.Size = new System.Drawing.Size(378, 50);
         this.CategoryName.TabIndex = 44;
         // 
         // UpdateCategory
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.backgroung;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.Save);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.CategoryName);
         this.Name = "UpdateCategory";
         this.Text = "UpdateCategory";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Save;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.TextBox CategoryName;
   }
}