namespace Thai_restaurant
{
   partial class Order
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
         this.OrderGridView = new System.Windows.Forms.DataGridView();
         this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.mealnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.deliverytimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.deliverypriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.bookingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.orderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.orderDataSet = new Thai_restaurant.OrderDataSet();
         this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.RefreshOrder = new System.Windows.Forms.Button();
         this.DeleteOrder = new System.Windows.Forms.Button();
         this.UpdateOrder = new System.Windows.Forms.Button();
         this.AddOrder = new System.Windows.Forms.Button();
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.order_ViewTableAdapter = new Thai_restaurant.OrderDataSetTableAdapters.Order_ViewTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.orderViewBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.orderDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // OrderGridView
         // 
         this.OrderGridView.AllowUserToOrderColumns = true;
         this.OrderGridView.AutoGenerateColumns = false;
         this.OrderGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(177)))), ((int)(((byte)(53)))));
         this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customernameDataGridViewTextBoxColumn,
            this.mealnameDataGridViewTextBoxColumn,
            this.deliverytimeDataGridViewTextBoxColumn,
            this.deliverypriceDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.bookingdateDataGridViewTextBoxColumn});
         this.OrderGridView.DataSource = this.orderViewBindingSource;
         this.OrderGridView.Location = new System.Drawing.Point(579, 15);
         this.OrderGridView.Name = "OrderGridView";
         this.OrderGridView.Size = new System.Drawing.Size(643, 479);
         this.OrderGridView.TabIndex = 22;
         // 
         // customernameDataGridViewTextBoxColumn
         // 
         this.customernameDataGridViewTextBoxColumn.DataPropertyName = "Customer_name";
         this.customernameDataGridViewTextBoxColumn.HeaderText = "Customer_name";
         this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
         // 
         // mealnameDataGridViewTextBoxColumn
         // 
         this.mealnameDataGridViewTextBoxColumn.DataPropertyName = "Meal_name";
         this.mealnameDataGridViewTextBoxColumn.HeaderText = "Meal_name";
         this.mealnameDataGridViewTextBoxColumn.Name = "mealnameDataGridViewTextBoxColumn";
         // 
         // deliverytimeDataGridViewTextBoxColumn
         // 
         this.deliverytimeDataGridViewTextBoxColumn.DataPropertyName = "Delivery_time";
         this.deliverytimeDataGridViewTextBoxColumn.HeaderText = "Delivery_time";
         this.deliverytimeDataGridViewTextBoxColumn.Name = "deliverytimeDataGridViewTextBoxColumn";
         // 
         // deliverypriceDataGridViewTextBoxColumn
         // 
         this.deliverypriceDataGridViewTextBoxColumn.DataPropertyName = "Delivery_price";
         this.deliverypriceDataGridViewTextBoxColumn.HeaderText = "Delivery_price";
         this.deliverypriceDataGridViewTextBoxColumn.Name = "deliverypriceDataGridViewTextBoxColumn";
         // 
         // deliverydateDataGridViewTextBoxColumn
         // 
         this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "Delivery_date";
         this.deliverydateDataGridViewTextBoxColumn.HeaderText = "Delivery_date";
         this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
         // 
         // bookingdateDataGridViewTextBoxColumn
         // 
         this.bookingdateDataGridViewTextBoxColumn.DataPropertyName = "Booking_date";
         this.bookingdateDataGridViewTextBoxColumn.HeaderText = "Booking_date";
         this.bookingdateDataGridViewTextBoxColumn.Name = "bookingdateDataGridViewTextBoxColumn";
         // 
         // orderViewBindingSource
         // 
         this.orderViewBindingSource.DataMember = "Order_View";
         this.orderViewBindingSource.DataSource = this.orderDataSet;
         // 
         // orderDataSet
         // 
         this.orderDataSet.DataSetName = "OrderDataSet";
         this.orderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // RefreshOrder
         // 
         this.RefreshOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
         this.RefreshOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.RefreshOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.RefreshOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.RefreshOrder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RefreshOrder.ForeColor = System.Drawing.Color.White;
         this.RefreshOrder.Location = new System.Drawing.Point(260, 404);
         this.RefreshOrder.Name = "RefreshOrder";
         this.RefreshOrder.Size = new System.Drawing.Size(129, 43);
         this.RefreshOrder.TabIndex = 21;
         this.RefreshOrder.Text = "Refresh";
         this.RefreshOrder.UseVisualStyleBackColor = false;
         this.RefreshOrder.Click += new System.EventHandler(this.RefreshOrder_Click);
         // 
         // DeleteOrder
         // 
         this.DeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
         this.DeleteOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.DeleteOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.DeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.DeleteOrder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DeleteOrder.ForeColor = System.Drawing.Color.White;
         this.DeleteOrder.Location = new System.Drawing.Point(419, 272);
         this.DeleteOrder.Name = "DeleteOrder";
         this.DeleteOrder.Size = new System.Drawing.Size(129, 43);
         this.DeleteOrder.TabIndex = 20;
         this.DeleteOrder.Text = "Delete";
         this.DeleteOrder.UseVisualStyleBackColor = false;
         this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
         // 
         // UpdateOrder
         // 
         this.UpdateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
         this.UpdateOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.UpdateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.UpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.UpdateOrder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.UpdateOrder.ForeColor = System.Drawing.Color.White;
         this.UpdateOrder.Location = new System.Drawing.Point(226, 272);
         this.UpdateOrder.Name = "UpdateOrder";
         this.UpdateOrder.Size = new System.Drawing.Size(129, 43);
         this.UpdateOrder.TabIndex = 18;
         this.UpdateOrder.Text = "Update";
         this.UpdateOrder.UseVisualStyleBackColor = false;
         this.UpdateOrder.Click += new System.EventHandler(this.UpdateOrder_Click);
         // 
         // AddOrder
         // 
         this.AddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
         this.AddOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(141)))));
         this.AddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(74)))));
         this.AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.AddOrder.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.AddOrder.ForeColor = System.Drawing.Color.White;
         this.AddOrder.Location = new System.Drawing.Point(37, 272);
         this.AddOrder.Name = "AddOrder";
         this.AddOrder.Size = new System.Drawing.Size(129, 43);
         this.AddOrder.TabIndex = 16;
         this.AddOrder.Text = "Add";
         this.AddOrder.UseVisualStyleBackColor = false;
         this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
         // 
         // pictureBox4
         // 
         this.pictureBox4.Image = global::Thai_restaurant.Properties.Resources.delete_order;
         this.pictureBox4.Location = new System.Drawing.Point(384, 71);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(180, 181);
         this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox4.TabIndex = 19;
         this.pictureBox4.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = global::Thai_restaurant.Properties.Resources.update_order;
         this.pictureBox2.Location = new System.Drawing.Point(198, 71);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(180, 181);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 17;
         this.pictureBox2.TabStop = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::Thai_restaurant.Properties.Resources.add_order;
         this.pictureBox1.Location = new System.Drawing.Point(12, 71);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(180, 181);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 15;
         this.pictureBox1.TabStop = false;
         // 
         // order_ViewTableAdapter
         // 
         this.order_ViewTableAdapter.ClearBeforeFill = true;
         // 
         // Order
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.PeachPuff;
         this.BackgroundImage = global::Thai_restaurant.Properties.Resources.background1;
         this.ClientSize = new System.Drawing.Size(1234, 506);
         this.Controls.Add(this.OrderGridView);
         this.Controls.Add(this.RefreshOrder);
         this.Controls.Add(this.DeleteOrder);
         this.Controls.Add(this.pictureBox4);
         this.Controls.Add(this.UpdateOrder);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.AddOrder);
         this.Controls.Add(this.pictureBox1);
         this.Name = "Order";
         this.Text = "Order";
         this.Load += new System.EventHandler(this.Order_Load);
         ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.orderViewBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.orderDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView OrderGridView;
      private System.Windows.Forms.Button RefreshOrder;
      private System.Windows.Forms.Button DeleteOrder;
      private System.Windows.Forms.PictureBox pictureBox4;
      private System.Windows.Forms.Button UpdateOrder;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Button AddOrder;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.BindingSource  BindingSource;
      private OrderDataSet orderDataSet;
      private System.Windows.Forms.BindingSource orderViewBindingSource;
      private OrderDataSetTableAdapters.Order_ViewTableAdapter order_ViewTableAdapter;
      private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn mealnameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn deliverytimeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn deliverypriceDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn bookingdateDataGridViewTextBoxColumn;
     // private    ;
   }
}