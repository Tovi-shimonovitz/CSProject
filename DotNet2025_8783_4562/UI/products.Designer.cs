namespace UI
{
    partial class products
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
            label1 = new Label();
            back = new Button();
            panelCenter = new Panel();
            panelDetailes = new Panel();
            massageCreate = new Label();
            updateId = new NumericUpDown();
            stock = new NumericUpDown();
            price = new NumericUpDown();
            category = new ComboBox();
            endCreate = new Button();
            panel2 = new Panel();
            label2 = new Label();
            name = new TextBox();
            panelRead = new Panel();
            readMassage = new Label();
            dataGridView2 = new DataGridView();
            readId = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            panelDelete = new Panel();
            massageDelete = new Label();
            endDelete = new Button();
            onlyId = new NumericUpDown();
            label4 = new Label();
            panelReadAll = new Panel();
            readAllMassage = new Label();
            filter = new Button();
            dataGridView1 = new DataGridView();
            actions = new Panel();
            read = new Button();
            readAllProducts = new Button();
            create = new Button();
            delete = new Button();
            update = new Button();
            panelCenter.SuspendLayout();
            panelDetailes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readId).BeginInit();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)onlyId).BeginInit();
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            actions.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(773, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "מוצרים\U0001f6d2";
            // 
            // back
            // 
            back.Location = new Point(315, 2);
            back.Margin = new Padding(5);
            back.Name = "back";
            back.Size = new Size(265, 46);
            back.TabIndex = 30;
            back.Text = "לחזרה לתפריט הקודם";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(panelDetailes);
            panelCenter.Controls.Add(panelRead);
            panelCenter.Controls.Add(panelDelete);
            panelCenter.Controls.Add(panelReadAll);
            panelCenter.Location = new Point(14, 58);
            panelCenter.Margin = new Padding(5);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1707, 801);
            panelCenter.TabIndex = 29;
            // 
            // panelDetailes
            // 
            panelDetailes.Controls.Add(massageCreate);
            panelDetailes.Controls.Add(updateId);
            panelDetailes.Controls.Add(stock);
            panelDetailes.Controls.Add(price);
            panelDetailes.Controls.Add(category);
            panelDetailes.Controls.Add(endCreate);
            panelDetailes.Controls.Add(panel2);
            panelDetailes.Controls.Add(label2);
            panelDetailes.Controls.Add(name);
            panelDetailes.Location = new Point(1017, 5);
            panelDetailes.Margin = new Padding(5);
            panelDetailes.Name = "panelDetailes";
            panelDetailes.Size = new Size(664, 498);
            panelDetailes.TabIndex = 14;
            // 
            // massageCreate
            // 
            massageCreate.AutoSize = true;
            massageCreate.Location = new Point(75, 407);
            massageCreate.Margin = new Padding(5, 0, 5, 0);
            massageCreate.Name = "massageCreate";
            massageCreate.Size = new Size(233, 32);
            massageCreate.TabIndex = 19;
            massageCreate.Text = "המוצר עודכן בהצלחה";
            // 
            // updateId
            // 
            updateId.Location = new Point(9, 57);
            updateId.Name = "updateId";
            updateId.Size = new Size(655, 39);
            updateId.TabIndex = 23;
            updateId.ValueChanged += updateId_ValueChanged;
            // 
            // stock
            // 
            stock.Location = new Point(11, 296);
            stock.Name = "stock";
            stock.Size = new Size(657, 39);
            stock.TabIndex = 22;
            // 
            // price
            // 
            price.Location = new Point(11, 248);
            price.Name = "price";
            price.Size = new Size(650, 39);
            price.TabIndex = 21;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "WATCH", "DISH", "BAG", "BEAUTY", "FLOWER" });
            category.Location = new Point(11, 194);
            category.Name = "category";
            category.Size = new Size(657, 40);
            category.TabIndex = 20;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // endCreate
            // 
            endCreate.Location = new Point(9, 343);
            endCreate.Margin = new Padding(5);
            endCreate.Name = "endCreate";
            endCreate.Size = new Size(655, 46);
            endCreate.TabIndex = 18;
            endCreate.Text = "הטען נתונים";
            endCreate.UseVisualStyleBackColor = true;
            endCreate.Click += endCreate_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(359, 51);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 614);
            panel2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 14);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(409, 32);
            label2.TabIndex = 13;
            label2.Text = "הכנס מזהה, שם, קטגוריה , מחיר ומלאי";
            label2.Click += label2_Click;
            // 
            // name
            // 
            name.Location = new Point(11, 128);
            name.Margin = new Padding(5);
            name.Name = "name";
            name.Size = new Size(657, 39);
            name.TabIndex = 10;
            // 
            // panelRead
            // 
            panelRead.Controls.Add(readMassage);
            panelRead.Controls.Add(dataGridView2);
            panelRead.Controls.Add(readId);
            panelRead.Controls.Add(button1);
            panelRead.Controls.Add(label3);
            panelRead.Location = new Point(5, 352);
            panelRead.Margin = new Padding(5);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(874, 414);
            panelRead.TabIndex = 19;
            // 
            // readMassage
            // 
            readMassage.AutoSize = true;
            readMassage.Location = new Point(355, 359);
            readMassage.Margin = new Padding(5, 0, 5, 0);
            readMassage.Name = "readMassage";
            readMassage.Size = new Size(150, 32);
            readMassage.TabIndex = 22;
            readMassage.Text = "מוצר לא קיים";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Margin = new Padding(5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(874, 414);
            dataGridView2.TabIndex = 21;
            // 
            // readId
            // 
            readId.Location = new Point(36, 59);
            readId.Margin = new Padding(5);
            readId.Name = "readId";
            readId.Size = new Size(801, 39);
            readId.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(41, 108);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(796, 46);
            button1.TabIndex = 20;
            button1.Text = "הטען נתונים";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 17);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 14;
            label3.Text = "הכנס מזהה";
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(massageDelete);
            panelDelete.Controls.Add(endDelete);
            panelDelete.Controls.Add(onlyId);
            panelDelete.Controls.Add(label4);
            panelDelete.Location = new Point(66, 5);
            panelDelete.Margin = new Padding(5);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(941, 272);
            panelDelete.TabIndex = 18;
            // 
            // massageDelete
            // 
            massageDelete.AutoSize = true;
            massageDelete.Location = new Point(312, 212);
            massageDelete.Margin = new Padding(5, 0, 5, 0);
            massageDelete.Name = "massageDelete";
            massageDelete.Size = new Size(267, 32);
            massageDelete.TabIndex = 20;
            massageDelete.Text = "המחיקה בוצעה בהצלחה";
            // 
            // endDelete
            // 
            endDelete.Location = new Point(170, 145);
            endDelete.Margin = new Padding(5);
            endDelete.Name = "endDelete";
            endDelete.Size = new Size(642, 46);
            endDelete.TabIndex = 19;
            endDelete.Text = "הטען נתונים";
            endDelete.UseVisualStyleBackColor = true;
            endDelete.Click += endDelete_Click;
            // 
            // onlyId
            // 
            onlyId.Location = new Point(161, 96);
            onlyId.Margin = new Padding(5);
            onlyId.Name = "onlyId";
            onlyId.Size = new Size(690, 39);
            onlyId.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 30);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 13;
            label4.Text = "הכנס מזהה";
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(readAllMassage);
            panelReadAll.Controls.Add(filter);
            panelReadAll.Controls.Add(dataGridView1);
            panelReadAll.Location = new Point(900, 412);
            panelReadAll.Margin = new Padding(5);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(781, 355);
            panelReadAll.TabIndex = 15;
            // 
            // readAllMassage
            // 
            readAllMassage.AutoSize = true;
            readAllMassage.Location = new Point(228, 322);
            readAllMassage.Margin = new Padding(5, 0, 5, 0);
            readAllMassage.Name = "readAllMassage";
            readAllMassage.Size = new Size(290, 32);
            readAllMassage.TabIndex = 23;
            readAllMassage.Text = "לא קיימים מוצרים במערכת";
            // 
            // filter
            // 
            filter.Location = new Point(60, 271);
            filter.Margin = new Padding(5);
            filter.Name = "filter";
            filter.Size = new Size(686, 46);
            filter.TabIndex = 8;
            filter.Text = "מוצרים מעל 100 ש\"ח";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(781, 355);
            dataGridView1.TabIndex = 7;
            // 
            // actions
            // 
            actions.Controls.Add(read);
            actions.Controls.Add(readAllProducts);
            actions.Controls.Add(create);
            actions.Controls.Add(delete);
            actions.Controls.Add(update);
            actions.Location = new Point(1731, 9);
            actions.Margin = new Padding(5);
            actions.Name = "actions";
            actions.Size = new Size(499, 836);
            actions.TabIndex = 27;
            // 
            // read
            // 
            read.Location = new Point(214, 136);
            read.Margin = new Padding(5);
            read.Name = "read";
            read.Size = new Size(153, 46);
            read.TabIndex = 2;
            read.Text = "הצגת מוצר";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // readAllProducts
            // 
            readAllProducts.Location = new Point(129, 266);
            readAllProducts.Margin = new Padding(5);
            readAllProducts.Name = "readAllProducts";
            readAllProducts.Size = new Size(307, 46);
            readAllProducts.TabIndex = 5;
            readAllProducts.Text = "הצגת כל המוצרים";
            readAllProducts.UseVisualStyleBackColor = true;
            readAllProducts.Click += readAllProducts_Click;
            // 
            // create
            // 
            create.Location = new Point(178, 405);
            create.Margin = new Padding(5);
            create.Name = "create";
            create.Size = new Size(244, 46);
            create.TabIndex = 4;
            create.Text = "יצירת מוצר חדש";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // delete
            // 
            delete.Location = new Point(229, 682);
            delete.Margin = new Padding(5);
            delete.Name = "delete";
            delete.Size = new Size(169, 46);
            delete.TabIndex = 6;
            delete.Text = "מחיקת מוצר";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(214, 534);
            update.Margin = new Padding(5);
            update.Name = "update";
            update.Size = new Size(170, 46);
            update.TabIndex = 3;
            update.Text = "עדכון מוצר";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // products
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2244, 909);
            Controls.Add(back);
            Controls.Add(panelCenter);
            Controls.Add(actions);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "products";
            Text = "products";
            Load += products_Load;
            panelCenter.ResumeLayout(false);
            panelDetailes.ResumeLayout(false);
            panelDetailes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateId).EndInit();
            ((System.ComponentModel.ISupportInitialize)stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)readId).EndInit();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)onlyId).EndInit();
            panelReadAll.ResumeLayout(false);
            panelReadAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            actions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button back;
        private Panel panelCenter;
        private Panel panelDetailes;
        private Label massageCreate;
        private Button endCreate;
        private Panel panel2;
        private Label label2;
        private TextBox name;
        private Panel panelRead;
        private Label readMassage;
        private DataGridView dataGridView2;
        private NumericUpDown readId;
        private Button button1;
        private Label label3;
        private Panel panelReadAll;
        private Label readAllMassage;
        private Button filter;
        private DataGridView dataGridView1;
        private Panel panelDelete;
        private Label massageDelete;
        private Button endDelete;
        private NumericUpDown onlyId;
        private Label label4;
        private Panel actions;
        private Button read;
        private Button readAllProducts;
        private Button create;
        private Button delete;
        private Button update;
        private NumericUpDown stock;
        private NumericUpDown price;
        private ComboBox category;
        private NumericUpDown updateId;
    }
}