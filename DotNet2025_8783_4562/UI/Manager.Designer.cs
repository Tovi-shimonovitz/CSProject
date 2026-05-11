namespace UI
{
    partial class Manager
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
            products = new Button();
            customers = new Button();
            sales = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(611, 202);
            products.Name = "products";
            products.Size = new Size(94, 29);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(384, 202);
            customers.Name = "customers";
            customers.Size = new Size(94, 29);
            customers.TabIndex = 1;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(139, 202);
            sales.Name = "sales";
            sales.Size = new Size(94, 29);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // button1
            // 
            button1.Location = new Point(335, 383);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 26;
            button1.Text = "לחזרה לתפריט הראשי";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(sales);
            Controls.Add(customers);
            Controls.Add(products);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button sales;
        private Button button1;
    }
}