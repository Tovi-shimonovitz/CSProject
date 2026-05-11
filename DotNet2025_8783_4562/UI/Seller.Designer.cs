namespace UI
{
    partial class back
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            hasClub = new Button();
            noClub = new Button();
            startOrder = new Panel();
            totalPrice = new Label();
            showAllProducts = new DataGridView();
            doOrder = new Button();
            showPrice = new Button();
            addProduct = new Button();
            label2 = new Label();
            enterProperties = new Panel();
            submitClub = new Button();
            label3 = new Label();
            idClub = new NumericUpDown();
            bindingSource1 = new BindingSource(components);
            newOrder = new Panel();
            panel2 = new Panel();
            submitDataProduct = new Button();
            amountOfProduct = new NumericUpDown();
            idOfNewProduct = new NumericUpDown();
            label4 = new Label();
            button1 = new Button();
            startOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showAllProducts).BeginInit();
            enterProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idClub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            newOrder.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountOfProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idOfNewProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "האם יש לך מועדון";
            // 
            // hasClub
            // 
            hasClub.Location = new Point(65, 78);
            hasClub.Name = "hasClub";
            hasClub.Size = new Size(94, 29);
            hasClub.TabIndex = 2;
            hasClub.Text = "כן";
            hasClub.UseVisualStyleBackColor = true;
            hasClub.Click += hasClub_Click;
            // 
            // noClub
            // 
            noClub.Location = new Point(65, 113);
            noClub.Name = "noClub";
            noClub.Size = new Size(94, 29);
            noClub.TabIndex = 3;
            noClub.Text = "לא";
            noClub.UseVisualStyleBackColor = true;
            noClub.Click += noClub_Click;
            // 
            // startOrder
            // 
            startOrder.Controls.Add(totalPrice);
            startOrder.Controls.Add(showAllProducts);
            startOrder.Controls.Add(doOrder);
            startOrder.Controls.Add(showPrice);
            startOrder.Controls.Add(addProduct);
            startOrder.Location = new Point(12, 12);
            startOrder.Name = "startOrder";
            startOrder.Size = new Size(468, 260);
            startOrder.TabIndex = 4;
            startOrder.Paint += startOrder_Paint;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(151, 18);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(17, 20);
            totalPrice.TabIndex = 4;
            totalPrice.Text = "0";
            totalPrice.Click += totalPrice_Click;
            // 
            // showAllProducts
            // 
            showAllProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showAllProducts.Location = new Point(163, 58);
            showAllProducts.Name = "showAllProducts";
            showAllProducts.RowHeadersWidth = 51;
            showAllProducts.Size = new Size(293, 153);
            showAllProducts.TabIndex = 3;
            showAllProducts.CellContentClick += showAllProducts_CellContentClick;
            // 
            // doOrder
            // 
            doOrder.Location = new Point(20, 217);
            doOrder.Name = "doOrder";
            doOrder.Size = new Size(94, 29);
            doOrder.TabIndex = 2;
            doOrder.Text = "לתשלום";
            doOrder.UseVisualStyleBackColor = true;
            doOrder.Click += doOrder_Click;
            // 
            // showPrice
            // 
            showPrice.Location = new Point(188, 14);
            showPrice.Name = "showPrice";
            showPrice.Size = new Size(131, 29);
            showPrice.TabIndex = 1;
            showPrice.Text = "מחיר לתשלום";
            showPrice.UseVisualStyleBackColor = true;
            showPrice.Click += showPrice_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(334, 14);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(94, 29);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוסף מוצר";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 7);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "הזמנה חדשה";
            // 
            // enterProperties
            // 
            enterProperties.Controls.Add(submitClub);
            enterProperties.Controls.Add(label3);
            enterProperties.Controls.Add(idClub);
            enterProperties.Location = new Point(538, 184);
            enterProperties.Name = "enterProperties";
            enterProperties.Size = new Size(250, 125);
            enterProperties.TabIndex = 6;
            enterProperties.Paint += enterProperties_Paint;
            // 
            // submitClub
            // 
            submitClub.Location = new Point(65, 45);
            submitClub.Name = "submitClub";
            submitClub.Size = new Size(163, 29);
            submitClub.TabIndex = 24;
            submitClub.Text = "הטען נתונים";
            submitClub.UseVisualStyleBackColor = true;
            submitClub.Click += submitClub_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 12);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 23;
            label3.Text = "הכנס ת\"ז";
            // 
            // idClub
            // 
            idClub.Location = new Point(3, 12);
            idClub.Name = "idClub";
            idClub.Size = new Size(150, 27);
            idClub.TabIndex = 22;
            idClub.ValueChanged += idClub_ValueChanged;
            // 
            // newOrder
            // 
            newOrder.Controls.Add(label1);
            newOrder.Controls.Add(hasClub);
            newOrder.Controls.Add(noClub);
            newOrder.Controls.Add(label2);
            newOrder.Location = new Point(538, 5);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(250, 164);
            newOrder.TabIndex = 7;
            newOrder.Paint += newOrder_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(submitDataProduct);
            panel2.Controls.Add(amountOfProduct);
            panel2.Controls.Add(idOfNewProduct);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(32, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 160);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // submitDataProduct
            // 
            submitDataProduct.Location = new Point(131, 100);
            submitDataProduct.Name = "submitDataProduct";
            submitDataProduct.Size = new Size(163, 29);
            submitDataProduct.TabIndex = 28;
            submitDataProduct.Text = "הטען נתונים";
            submitDataProduct.UseVisualStyleBackColor = true;
            submitDataProduct.Click += submitDataProduct_Click;
            // 
            // amountOfProduct
            // 
            amountOfProduct.Location = new Point(143, 67);
            amountOfProduct.Name = "amountOfProduct";
            amountOfProduct.Size = new Size(150, 27);
            amountOfProduct.TabIndex = 26;
            // 
            // idOfNewProduct
            // 
            idOfNewProduct.Location = new Point(143, 35);
            idOfNewProduct.Name = "idOfNewProduct";
            idOfNewProduct.Size = new Size(150, 27);
            idOfNewProduct.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 9);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 0;
            label4.Text = "הכנס מזהה מוצר וכמות";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(616, 366);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 25;
            button1.Text = "לחזרה לתפריט הראשי";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // back
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(newOrder);
            Controls.Add(enterProperties);
            Controls.Add(startOrder);
            Name = "back";
            Text = "Seller";
            startOrder.ResumeLayout(false);
            startOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showAllProducts).EndInit();
            enterProperties.ResumeLayout(false);
            enterProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idClub).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            newOrder.ResumeLayout(false);
            newOrder.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountOfProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)idOfNewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button hasClub;
        private Button noClub;
        private Panel startOrder;
        private Button showPrice;
        private Button addProduct;
        private Label label2;
        private Button doOrder;
        private DataGridView showAllProducts;
        private Panel enterProperties;
        private Button submitClub;
        private Label label3;
        private NumericUpDown idClub;
        private BindingSource bindingSource1;
        private Panel newOrder;
        private Panel panel2;
        private Label label4;
        private NumericUpDown amountOfProduct;
        private NumericUpDown idOfNewProduct;
        private Button submitDataProduct;
        private Label totalPrice;
        private Button button1;
    }
}