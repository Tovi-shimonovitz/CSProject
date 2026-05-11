namespace UI
{
    partial class sales
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
            panelRead = new Panel();
            dataGridOneSale = new DataGridView();
            readId = new NumericUpDown();
            endRead = new Button();
            label3 = new Label();
            panelReadAll = new Panel();
            filter = new Button();
            dataGridAllSales = new DataGridView();
            panelDelete = new Panel();
            endDelete = new Button();
            idDelete = new NumericUpDown();
            label4 = new Label();
            panelProperties = new Panel();
            label9 = new Label();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label7 = new Label();
            dateEnd = new DateTimePicker();
            label10 = new Label();
            dateStart = new DateTimePicker();
            checkBoxClub = new CheckBox();
            priceForSale = new NumericUpDown();
            amountSale = new NumericUpDown();
            idProduct = new NumericUpDown();
            endCreateAndUpdate = new Button();
            idSale = new NumericUpDown();
            label2 = new Label();
            panelTitle = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            read = new Button();
            readAll = new Button();
            create = new Button();
            delete = new Button();
            update = new Button();
            panelCenter.SuspendLayout();
            panelRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOneSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readId).BeginInit();
            panelReadAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllSales).BeginInit();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idDelete).BeginInit();
            panelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceForSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idSale).BeginInit();
            panelTitle.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "מבצעים🌟";
            // 
            // back
            // 
            back.Location = new Point(887, 528);
            back.Name = "back";
            back.Size = new Size(163, 29);
            back.TabIndex = 30;
            back.Text = "לחזרה לתפריט הקודם";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(panelRead);
            panelCenter.Controls.Add(panelReadAll);
            panelCenter.Controls.Add(panelDelete);
            panelCenter.Location = new Point(26, 126);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(789, 446);
            panelCenter.TabIndex = 29;
            // 
            // panelRead
            // 
            panelRead.Controls.Add(dataGridOneSale);
            panelRead.Controls.Add(readId);
            panelRead.Controls.Add(endRead);
            panelRead.Controls.Add(label3);
            panelRead.Location = new Point(3, 187);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(299, 259);
            panelRead.TabIndex = 19;
            // 
            // dataGridOneSale
            // 
            dataGridOneSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOneSale.Location = new Point(67, 81);
            dataGridOneSale.Name = "dataGridOneSale";
            dataGridOneSale.RowHeadersWidth = 51;
            dataGridOneSale.Size = new Size(172, 108);
            dataGridOneSale.TabIndex = 21;
            // 
            // readId
            // 
            readId.Location = new Point(25, 13);
            readId.Name = "readId";
            readId.Size = new Size(150, 27);
            readId.TabIndex = 21;
            // 
            // endRead
            // 
            endRead.Location = new Point(71, 46);
            endRead.Name = "endRead";
            endRead.Size = new Size(170, 29);
            endRead.TabIndex = 20;
            endRead.Text = "הטען נתונים";
            endRead.UseVisualStyleBackColor = true;
            endRead.Click += endRead_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 4);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 14;
            label3.Text = "הכנס מזהה";
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(filter);
            panelReadAll.Controls.Add(dataGridAllSales);
            panelReadAll.Location = new Point(342, 212);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(251, 222);
            panelReadAll.TabIndex = 15;
            // 
            // filter
            // 
            filter.Location = new Point(77, 160);
            filter.Name = "filter";
            filter.Size = new Size(94, 29);
            filter.TabIndex = 8;
            filter.Text = "סינון לקוחות מועדון";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // dataGridAllSales
            // 
            dataGridAllSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllSales.Location = new Point(3, 12);
            dataGridAllSales.Name = "dataGridAllSales";
            dataGridAllSales.RowHeadersWidth = 51;
            dataGridAllSales.Size = new Size(245, 142);
            dataGridAllSales.TabIndex = 7;
            dataGridAllSales.CellContentClick += dataGridAllSales_CellContentClick;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(endDelete);
            panelDelete.Controls.Add(idDelete);
            panelDelete.Controls.Add(label4);
            panelDelete.Location = new Point(6, 3);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(277, 208);
            panelDelete.TabIndex = 18;
            // 
            // endDelete
            // 
            endDelete.Location = new Point(108, 85);
            endDelete.Name = "endDelete";
            endDelete.Size = new Size(94, 29);
            endDelete.TabIndex = 19;
            endDelete.Text = "הטען נתונים";
            endDelete.UseVisualStyleBackColor = true;
            endDelete.Click += endDelete_Click;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(68, 51);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(150, 27);
            idDelete.TabIndex = 18;
            idDelete.ValueChanged += idDelete_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 14);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 13;
            label4.Text = "הכנס מזהה";
            // 
            // panelProperties
            // 
            panelProperties.Controls.Add(label9);
            panelProperties.Controls.Add(label12);
            panelProperties.Controls.Add(label8);
            panelProperties.Controls.Add(label11);
            panelProperties.Controls.Add(label7);
            panelProperties.Controls.Add(dateEnd);
            panelProperties.Controls.Add(label10);
            panelProperties.Controls.Add(dateStart);
            panelProperties.Controls.Add(checkBoxClub);
            panelProperties.Controls.Add(priceForSale);
            panelProperties.Controls.Add(amountSale);
            panelProperties.Controls.Add(idProduct);
            panelProperties.Controls.Add(endCreateAndUpdate);
            panelProperties.Controls.Add(idSale);
            panelProperties.Controls.Add(label2);
            panelProperties.Location = new Point(544, 126);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(285, 388);
            panelProperties.TabIndex = 14;
            panelProperties.Paint += panelProperties_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 144);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 33;
            label9.Text = "מחיר במבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(179, 236);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 32;
            label12.Text = "תאריך סיום";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 114);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 28;
            label8.Text = "כמות למבצע";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(172, 203);
            label11.Name = "label11";
            label11.Size = new Size(103, 20);
            label11.TabIndex = 31;
            label11.Text = "תאריך התחלה";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 39);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 27;
            label7.Text = "מזהה מבצע";
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(20, 234);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(148, 27);
            dateEnd.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 82);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 30;
            label10.Text = "מזהה מוצר";
            // 
            // dateStart
            // 
            dateStart.Location = new Point(18, 202);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(148, 27);
            dateStart.TabIndex = 25;
            // 
            // checkBoxClub
            // 
            checkBoxClub.AutoSize = true;
            checkBoxClub.Cursor = Cursors.IBeam;
            checkBoxClub.ForeColor = Color.DarkCyan;
            checkBoxClub.Location = new Point(47, 171);
            checkBoxClub.Name = "checkBoxClub";
            checkBoxClub.Size = new Size(114, 24);
            checkBoxClub.TabIndex = 24;
            checkBoxClub.Text = "למועדון בלבד";
            checkBoxClub.UseVisualStyleBackColor = true;
            // 
            // priceForSale
            // 
            priceForSale.Location = new Point(12, 138);
            priceForSale.Name = "priceForSale";
            priceForSale.Size = new Size(150, 27);
            priceForSale.TabIndex = 23;
            // 
            // amountSale
            // 
            amountSale.Location = new Point(13, 105);
            amountSale.Name = "amountSale";
            amountSale.Size = new Size(150, 27);
            amountSale.TabIndex = 22;
            // 
            // idProduct
            // 
            idProduct.Location = new Point(13, 74);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(150, 27);
            idProduct.TabIndex = 21;
            // 
            // endCreateAndUpdate
            // 
            endCreateAndUpdate.Location = new Point(64, 279);
            endCreateAndUpdate.Name = "endCreateAndUpdate";
            endCreateAndUpdate.Size = new Size(156, 29);
            endCreateAndUpdate.TabIndex = 18;
            endCreateAndUpdate.Text = "הטען נתונים";
            endCreateAndUpdate.UseVisualStyleBackColor = true;
            endCreateAndUpdate.Click += endCreateAndUpdate_Click;
            // 
            // idSale
            // 
            idSale.Location = new Point(13, 37);
            idSale.Name = "idSale";
            idSale.Size = new Size(150, 27);
            idSale.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 13;
            label2.Text = "הנס פרטי מבצע";
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(label6);
            panelTitle.Controls.Add(label5);
            panelTitle.Controls.Add(label1);
            panelTitle.Location = new Point(544, 70);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(250, 50);
            panelTitle.TabIndex = 28;
            panelTitle.Paint += panelTitle_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 97);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 2;
            label6.Text = "מבצעים🌟";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 15);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 1;
            label5.Text = "מבצעים🌟";
            // 
            // panel3
            // 
            panel3.Controls.Add(read);
            panel3.Controls.Add(readAll);
            panel3.Controls.Add(create);
            panel3.Controls.Add(delete);
            panel3.Controls.Add(update);
            panel3.Location = new Point(835, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 341);
            panel3.TabIndex = 27;
            panel3.Paint += panel3_Paint;
            // 
            // read
            // 
            read.Location = new Point(59, 57);
            read.Name = "read";
            read.Size = new Size(133, 29);
            read.TabIndex = 2;
            read.Text = "הצגת מבצע";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // readAll
            // 
            readAll.Location = new Point(32, 114);
            readAll.Name = "readAll";
            readAll.Size = new Size(160, 29);
            readAll.TabIndex = 5;
            readAll.Text = "הצגת כל המבצעים";
            readAll.UseVisualStyleBackColor = true;
            readAll.Click += readAll_Click;
            // 
            // create
            // 
            create.Location = new Point(98, 165);
            create.Name = "create";
            create.Size = new Size(94, 29);
            create.TabIndex = 4;
            create.Text = "יצירת מבצע חדש";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // delete
            // 
            delete.Location = new Point(88, 278);
            delete.Name = "delete";
            delete.Size = new Size(104, 29);
            delete.TabIndex = 6;
            delete.Text = "מחיקת מבצע";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(98, 224);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 3;
            update.Text = "עדכון לקוח";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 643);
            Controls.Add(panelProperties);
            Controls.Add(back);
            Controls.Add(panelCenter);
            Controls.Add(panelTitle);
            Controls.Add(panel3);
            Name = "sales";
            Text = "sales";
            panelCenter.ResumeLayout(false);
            panelRead.ResumeLayout(false);
            panelRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOneSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)readId).EndInit();
            panelReadAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridAllSales).EndInit();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idDelete).EndInit();
            panelProperties.ResumeLayout(false);
            panelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceForSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)idProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)idSale).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button back;
        private Panel panelCenter;
        private Panel panelProperties;
        private Button endCreateAndUpdate;
        private NumericUpDown idSale;
        private Label label2;
        private Panel panelRead;
        private DataGridView dataGridOneSale;
        private NumericUpDown readId;
        private Button endRead;
        private Label label3;
        private Panel panelReadAll;
        private Button filter;
        private DataGridView dataGridAllSales;
        private Panel panelDelete;
        private Button endDelete;
        private NumericUpDown idDelete;
        private Label label4;
        private Panel panelTitle;
        private Panel panel3;
        private Button read;
        private Button readAll;
        private Button create;
        private Button delete;
        private Button update;
        private NumericUpDown idProduct;
        private DateTimePicker dateStart;
        private CheckBox checkBoxClub;
        private NumericUpDown priceForSale;
        private NumericUpDown amountSale;
        private DateTimePicker dateEnd;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label10;
        private Label label9;
    }
}