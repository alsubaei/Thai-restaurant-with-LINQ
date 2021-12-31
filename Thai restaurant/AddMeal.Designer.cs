namespace Thai_restaurant
{
   partial class AddMeal
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
         this.components = new System.ComponentModel.Container();
         this.save = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.reset = new System.Windows.Forms.Button();
         this.user = new System.Windows.Forms.PictureBox();
         this.password = new System.Windows.Forms.PictureBox();
         this.MealName = new System.Windows.Forms.TextBox();
         this.MealCost = new System.Windows.Forms.TextBox();
         this.MealCategory = new System.Windows.Forms.ComboBox();
         this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.mealTableDataSet = new Thai_restaurant.MealTableDataSet();
         this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.categoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.categoryDataSet = new Thai_restaurant.CategoryDataSet();
         this.mealTableAdapter = new Thai_restaurant.MealTableDataSetTableAdapters.MealTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealTableDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryDataSetBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
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
         this.save.Location = new System.Drawing.Point(685, 367);
         this.save.Name = "save";
         this.save.Size = new System.Drawing.Size(96, 43);
         this.save.TabIndex = 35;
         this.save.Text = "Save";
         this.save.UseVisualStyleBackColor = true;
         this.save.Click += new System.EventHandler(this.save_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Thai_restaurant.Properties.Resources.category;
         this.pictureBox1.Location = new System.Drawing.Point(391, 257);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(63, 60);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 34;
         this.pictureBox1.TabStop = false;
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
         this.reset.Location = new System.Drawing.Point(501, 367);
         this.reset.Name = "reset";
         this.reset.Size = new System.Drawing.Size(96, 43);
         this.reset.TabIndex = 32;
         this.reset.Text = "Reset";
         this.reset.UseVisualStyleBackColor = true;
         this.reset.Click += new System.EventHandler(this.reset_Click);
         // 
         // user
         // 
         this.user.Image = global::Thai_restaurant.Properties.Resources.meal;
         this.user.Location = new System.Drawing.Point(391, 97);
         this.user.Name = "user";
         this.user.Size = new System.Drawing.Size(63, 60);
         this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.user.TabIndex = 31;
         this.user.TabStop = false;
         // 
         // password
         // 
         this.password.Image = global::Thai_restaurant.Properties.Resources.cost;
         this.password.Location = new System.Drawing.Point(391, 175);
         this.password.Name = "password";
         this.password.Size = new System.Drawing.Size(63, 60);
         this.password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.password.TabIndex = 30;
         this.password.TabStop = false;
         // 
         // MealName
         // 
         this.MealName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.MealName.Font = new System.Drawing.Font("Tahoma", 18F);
         this.MealName.Location = new System.Drawing.Point(466, 111);
         this.MealName.Multiline = true;
         this.MealName.Name = "MealName";
         this.MealName.Size = new System.Drawing.Size(378, 37);
         this.MealName.TabIndex = 29;
         // 
         // MealCost
         // 
         this.MealCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.MealCost.Font = new System.Drawing.Font("Tahoma", 18F);
         this.MealCost.Location = new System.Drawing.Point(466, 187);
         this.MealCost.Multiline = true;
         this.MealCost.Name = "MealCost";
         this.MealCost.Size = new System.Drawing.Size(378, 37);
         this.MealCost.TabIndex = 28;
         // 
         // MealCategory
         // 
         this.MealCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
         this.MealCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mealBindingSource, "Category_id", true));
         this.MealCategory.Font = new System.Drawing.Font("Tahoma", 18F);
         this.MealCategory.FormattingEnabled = true;
         this.MealCategory.Location = new System.Drawing.Point(466, 270);
         this.MealCategory.Margin = new System.Windows.Forms.Padding(0);
         this.MealCategory.Name = "MealCategory";
         this.MealCategory.Size = new System.Drawing.Size(378, 37);
         this.MealCategory.TabIndex = 36;
         // 
         // mealBindingSource
         // 
         this.mealBindingSource.DataMember = "Meal";
         this.mealBindingSource.DataSource = this.mealTableDataSet;
         // 
         // mealTableDataSet
         // 
         this.mealTableDataSet.DataSetName = "MealTableDataSet";
         this.mealTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // categoryBindingSource
         // 
         this.categoryBindingSource.DataMember = "Category";
         this.categoryBindingSource.DataSource = this.categoryDataSetBindingSource;
         // 
         // categoryDataSetBindingSource
         // 
         this.categoryDataSetBindingSource.DataSource = this.categoryDataSet;
         this.categoryDataSetBindingSource.Position = 0;
         // 
         // categoryDataSet
         // 
         this.categoryDataSet.DataSetName = "CategoryDataSet";
         this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // mealTableAdapter
         // 
         this.mealTableAdapter.ClearBeforeFill = true;
         // 
         // AddMeal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.backgroung;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.MealCategory);
         this.Controls.Add(this.save);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.reset);
         this.Controls.Add(this.user);
         this.Controls.Add(this.password);
         this.Controls.Add(this.MealName);
         this.Controls.Add(this.MealCost);
         this.Name = "AddMeal";
         this.Text = "AddMeal";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealTableDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryDataSetBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button save;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button reset;
      private System.Windows.Forms.PictureBox user;
      private System.Windows.Forms.PictureBox password;
      private System.Windows.Forms.TextBox MealName;
      private System.Windows.Forms.TextBox MealCost;
      private System.Windows.Forms.ComboBox MealCategory;
      private System.Windows.Forms.BindingSource categoryDataSetBindingSource;
      private CategoryDataSet categoryDataSet;
      private System.Windows.Forms.BindingSource categoryBindingSource;
//      private CategoryDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
      private MealTableDataSet mealTableDataSet;
      private System.Windows.Forms.BindingSource mealBindingSource;
      private MealTableDataSetTableAdapters.MealTableAdapter mealTableAdapter;
   }
}