namespace Thai_restaurant
{
   partial class Customer_Form
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
         this.AddCustomer = new System.Windows.Forms.Button();
         this.UpdateCustomer = new System.Windows.Forms.Button();
         this.DeleteCustomer = new System.Windows.Forms.Button();
         this.RefreshCustomer = new System.Windows.Forms.Button();
         this.CustomerGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.customerDataSet = new Thai_restaurant.CustomerDataSet();
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.pictureBox3 = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.customerTableAdapter = new Thai_restaurant.CustomerDataSetTableAdapters.CustomerTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // AddCustomer
         // 
         this.AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(161)))), ((int)(((byte)(154)))));
         this.AddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.AddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.AddCustomer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.AddCustomer.ForeColor = System.Drawing.Color.White;
         this.AddCustomer.Location = new System.Drawing.Point(37, 271);
         this.AddCustomer.Name = "AddCustomer";
         this.AddCustomer.Size = new System.Drawing.Size(129, 43);
         this.AddCustomer.TabIndex = 7;
         this.AddCustomer.Text = "Add";
         this.AddCustomer.UseVisualStyleBackColor = false;
         this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
         // 
         // UpdateCustomer
         // 
         this.UpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(161)))), ((int)(((byte)(154)))));
         this.UpdateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.UpdateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.UpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.UpdateCustomer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.UpdateCustomer.ForeColor = System.Drawing.Color.White;
         this.UpdateCustomer.Location = new System.Drawing.Point(260, 271);
         this.UpdateCustomer.Name = "UpdateCustomer";
         this.UpdateCustomer.Size = new System.Drawing.Size(129, 43);
         this.UpdateCustomer.TabIndex = 8;
         this.UpdateCustomer.Text = "Update";
         this.UpdateCustomer.UseVisualStyleBackColor = false;
         this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
         // 
         // DeleteCustomer
         // 
         this.DeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(161)))), ((int)(((byte)(154)))));
         this.DeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.DeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.DeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.DeleteCustomer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DeleteCustomer.ForeColor = System.Drawing.Color.White;
         this.DeleteCustomer.Location = new System.Drawing.Point(494, 271);
         this.DeleteCustomer.Name = "DeleteCustomer";
         this.DeleteCustomer.Size = new System.Drawing.Size(129, 43);
         this.DeleteCustomer.TabIndex = 9;
         this.DeleteCustomer.Text = "Delete";
         this.DeleteCustomer.UseVisualStyleBackColor = false;
         this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
         // 
         // RefreshCustomer
         // 
         this.RefreshCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(161)))), ((int)(((byte)(154)))));
         this.RefreshCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.RefreshCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.RefreshCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.RefreshCustomer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RefreshCustomer.ForeColor = System.Drawing.Color.White;
         this.RefreshCustomer.Location = new System.Drawing.Point(260, 405);
         this.RefreshCustomer.Name = "RefreshCustomer";
         this.RefreshCustomer.Size = new System.Drawing.Size(129, 43);
         this.RefreshCustomer.TabIndex = 10;
         this.RefreshCustomer.Text = "Refresh";
         this.RefreshCustomer.UseVisualStyleBackColor = false;
         this.RefreshCustomer.Click += new System.EventHandler(this.RefreshCustomer_Click);
         // 
         // CustomerGridView
         // 
         this.CustomerGridView.AutoGenerateColumns = false;
         this.CustomerGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
         this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.CustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.CustomerGridView.DataSource = this.customerBindingSource;
         this.CustomerGridView.Location = new System.Drawing.Point(724, 12);
         this.CustomerGridView.Name = "CustomerGridView";
         this.CustomerGridView.Size = new System.Drawing.Size(443, 482);
         this.CustomerGridView.TabIndex = 13;
//         this.CustomerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer_id";
         this.dataGridViewTextBoxColumn1.HeaderText = "Customer_id";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_name";
         this.dataGridViewTextBoxColumn2.HeaderText = "Customer_name";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer_phone";
         this.dataGridViewTextBoxColumn3.HeaderText = "Customer_phone";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "Customer_address";
         this.dataGridViewTextBoxColumn4.HeaderText = "Customer_address";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // customerBindingSource
         // 
         this.customerBindingSource.DataMember = "Customer";
         this.customerBindingSource.DataSource = this.customerDataSet;
         // 
         // customerDataSet
         // 
         this.customerDataSet.DataSetName = "CustomerDataSet";
         this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // pictureBox4
         // 
         this.pictureBox4.Image = global::Thai_restaurant.Properties.Resources.delete_customer;
         this.pictureBox4.Location = new System.Drawing.Point(459, 72);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(180, 181);
         this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox4.TabIndex = 3;
         this.pictureBox4.TabStop = false;
         // 
         // pictureBox3
         // 
         this.pictureBox3.Image = global::Thai_restaurant.Properties.Resources.update_customer;
         this.pictureBox3.Location = new System.Drawing.Point(232, 72);
         this.pictureBox3.Name = "pictureBox3";
         this.pictureBox3.Size = new System.Drawing.Size(180, 181);
         this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox3.TabIndex = 2;
         this.pictureBox3.TabStop = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Thai_restaurant.Properties.Resources.add_customer;
         this.pictureBox1.Location = new System.Drawing.Point(12, 72);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(180, 181);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // customerTableAdapter
         // 
         this.customerTableAdapter.ClearBeforeFill = true;
         // 
         // Customer_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Orange;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.background1;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.CustomerGridView);
         this.Controls.Add(this.RefreshCustomer);
         this.Controls.Add(this.DeleteCustomer);
         this.Controls.Add(this.UpdateCustomer);
         this.Controls.Add(this.AddCustomer);
         this.Controls.Add(this.pictureBox4);
         this.Controls.Add(this.pictureBox3);
         this.Controls.Add(this.pictureBox1);
         this.Name = "Customer_Form";
         this.Text = "Customer";
         this.Load += new System.EventHandler(this.Customer_Load);
         ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.PictureBox pictureBox3;
      private System.Windows.Forms.PictureBox pictureBox4;
      private System.Windows.Forms.Button AddCustomer;
      private System.Windows.Forms.Button UpdateCustomer;
      private System.Windows.Forms.Button DeleteCustomer;
      private System.Windows.Forms.Button RefreshCustomer;
      private System.Windows.Forms.DataGridView CustomerGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
      private CustomerDataSet customerDataSet;
      private System.Windows.Forms.BindingSource customerBindingSource;
      private CustomerDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
   }
}