namespace Thai_restaurant
{
   partial class Meal
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal));
         this.AddMeal = new System.Windows.Forms.Button();
         this.UpdateMeal = new System.Windows.Forms.Button();
         this.DeleteMeal = new System.Windows.Forms.Button();
         this.RefreshMeal = new System.Windows.Forms.Button();
         this.MealGridView = new System.Windows.Forms.DataGridView();
         this.mealidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.mealnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.mealcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.mealViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.mealDataSet = new Thai_restaurant.MealDataSet();
         this.thaiRestaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.thaiRestaurantDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.meal_ViewTableAdapter = new Thai_restaurant.MealDataSetTableAdapters.Meal_ViewTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.MealGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealViewBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.thaiRestaurantDataSetBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.thaiRestaurantDataSet2BindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // AddMeal
         // 
         this.AddMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.AddMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.AddMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
         this.AddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.AddMeal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.AddMeal.ForeColor = System.Drawing.Color.White;
         this.AddMeal.Location = new System.Drawing.Point(37, 273);
         this.AddMeal.Name = "AddMeal";
         this.AddMeal.Size = new System.Drawing.Size(129, 43);
         this.AddMeal.TabIndex = 8;
         this.AddMeal.Text = "Add";
         this.AddMeal.UseVisualStyleBackColor = false;
         this.AddMeal.Click += new System.EventHandler(this.AddMeal_Click);
         // 
         // UpdateMeal
         // 
         this.UpdateMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.UpdateMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.UpdateMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
         this.UpdateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.UpdateMeal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.UpdateMeal.ForeColor = System.Drawing.Color.White;
         this.UpdateMeal.Location = new System.Drawing.Point(260, 273);
         this.UpdateMeal.Name = "UpdateMeal";
         this.UpdateMeal.Size = new System.Drawing.Size(129, 43);
         this.UpdateMeal.TabIndex = 10;
         this.UpdateMeal.Text = "Update";
         this.UpdateMeal.UseVisualStyleBackColor = false;
         this.UpdateMeal.Click += new System.EventHandler(this.UpdateMeal_Click);
         // 
         // DeleteMeal
         // 
         this.DeleteMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.DeleteMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.DeleteMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
         this.DeleteMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.DeleteMeal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DeleteMeal.ForeColor = System.Drawing.Color.White;
         this.DeleteMeal.Location = new System.Drawing.Point(486, 273);
         this.DeleteMeal.Name = "DeleteMeal";
         this.DeleteMeal.Size = new System.Drawing.Size(129, 43);
         this.DeleteMeal.TabIndex = 12;
         this.DeleteMeal.Text = "Delete";
         this.DeleteMeal.UseVisualStyleBackColor = false;
         this.DeleteMeal.Click += new System.EventHandler(this.DeleteMeal_Click);
         // 
         // RefreshMeal
         // 
         this.RefreshMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.RefreshMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.RefreshMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
         this.RefreshMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.RefreshMeal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RefreshMeal.ForeColor = System.Drawing.Color.White;
         this.RefreshMeal.Location = new System.Drawing.Point(260, 405);
         this.RefreshMeal.Name = "RefreshMeal";
         this.RefreshMeal.Size = new System.Drawing.Size(129, 43);
         this.RefreshMeal.TabIndex = 13;
         this.RefreshMeal.Text = "Refresh";
         this.RefreshMeal.UseVisualStyleBackColor = false;
         this.RefreshMeal.Click += new System.EventHandler(this.RefreshMeal_Click);
         // 
         // MealGridView
         // 
         this.MealGridView.AutoGenerateColumns = false;
         this.MealGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(19)))), ((int)(((byte)(179)))));
         this.MealGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.MealGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealidDataGridViewTextBoxColumn,
            this.mealnameDataGridViewTextBoxColumn,
            this.mealcostDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn});
         this.MealGridView.DataSource = this.mealViewBindingSource;
         this.MealGridView.Location = new System.Drawing.Point(739, 12);
         this.MealGridView.Name = "MealGridView";
         this.MealGridView.Size = new System.Drawing.Size(443, 479);
         this.MealGridView.TabIndex = 14;
         // 
         // mealidDataGridViewTextBoxColumn
         // 
         this.mealidDataGridViewTextBoxColumn.DataPropertyName = "Meal_id";
         this.mealidDataGridViewTextBoxColumn.HeaderText = "Meal_id";
         this.mealidDataGridViewTextBoxColumn.Name = "mealidDataGridViewTextBoxColumn";
         // 
         // mealnameDataGridViewTextBoxColumn
         // 
         this.mealnameDataGridViewTextBoxColumn.DataPropertyName = "Meal_name";
         this.mealnameDataGridViewTextBoxColumn.HeaderText = "Meal_name";
         this.mealnameDataGridViewTextBoxColumn.Name = "mealnameDataGridViewTextBoxColumn";
         // 
         // mealcostDataGridViewTextBoxColumn
         // 
         this.mealcostDataGridViewTextBoxColumn.DataPropertyName = "Meal_cost";
         this.mealcostDataGridViewTextBoxColumn.HeaderText = "Meal_cost";
         this.mealcostDataGridViewTextBoxColumn.Name = "mealcostDataGridViewTextBoxColumn";
         // 
         // categorynameDataGridViewTextBoxColumn
         // 
         this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "Category_name";
         this.categorynameDataGridViewTextBoxColumn.HeaderText = "Category_name";
         this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
         // 
         // mealViewBindingSource
         // 
         this.mealViewBindingSource.DataMember = "Meal_View";
         this.mealViewBindingSource.DataSource = this.mealDataSet;
         // 
         // mealDataSet
         // 
         this.mealDataSet.DataSetName = "MealDataSet";
         this.mealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // pictureBox4
         // 
         this.pictureBox4.BackgroundImage = global::Thai_restaurant.Properties.Resources.backgroung;
         this.pictureBox4.Image = global::Thai_restaurant.Properties.Resources.delete_meal;
         this.pictureBox4.Location = new System.Drawing.Point(451, 72);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(180, 181);
         this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox4.TabIndex = 11;
         this.pictureBox4.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = global::Thai_restaurant.Properties.Resources.update_meal;
         this.pictureBox2.Location = new System.Drawing.Point(232, 72);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(180, 181);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 9;
         this.pictureBox2.TabStop = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 72);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(180, 181);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // meal_ViewTableAdapter
         // 
         this.meal_ViewTableAdapter.ClearBeforeFill = true;
         // 
         // Meal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.background1;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.MealGridView);
         this.Controls.Add(this.RefreshMeal);
         this.Controls.Add(this.DeleteMeal);
         this.Controls.Add(this.pictureBox4);
         this.Controls.Add(this.UpdateMeal);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.AddMeal);
         this.Controls.Add(this.pictureBox1);
         this.Name = "Meal";
         this.Text = "Meal";
         this.Load += new System.EventHandler(this.Meal_Load);
         ((System.ComponentModel.ISupportInitialize)(this.MealGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealViewBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mealDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.thaiRestaurantDataSetBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.thaiRestaurantDataSet2BindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button AddMeal;
      private System.Windows.Forms.Button UpdateMeal;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Button DeleteMeal;
      private System.Windows.Forms.PictureBox pictureBox4;
      private System.Windows.Forms.Button RefreshMeal;
      private System.Windows.Forms.DataGridView MealGridView;
      private System.Windows.Forms.BindingSource thaiRestaurantDataSet2BindingSource;
      private System.Windows.Forms.BindingSource thaiRestaurantDataSetBindingSource;
      private MealDataSet mealDataSet;
      private System.Windows.Forms.BindingSource mealViewBindingSource;
      private MealDataSetTableAdapters.Meal_ViewTableAdapter meal_ViewTableAdapter;
      private System.Windows.Forms.DataGridViewTextBoxColumn mealidDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn mealnameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn mealcostDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
    }
}