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
            label1.Location = new Point(132, 22);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "מבצעים🌟";
            // 
            // back
            // 
            back.Location = new Point(1441, 845);
            back.Margin = new Padding(5, 5, 5, 5);
            back.Name = "back";
            back.Size = new Size(265, 46);
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
            panelCenter.Location = new Point(42, 202);
            panelCenter.Margin = new Padding(5, 5, 5, 5);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1282, 714);
            panelCenter.TabIndex = 29;
            // 
            // panelRead
            // 
            panelRead.Controls.Add(dataGridOneSale);
            panelRead.Controls.Add(readId);
            panelRead.Controls.Add(endRead);
            panelRead.Controls.Add(label3);
            panelRead.Location = new Point(5, 299);
            panelRead.Margin = new Padding(5, 5, 5, 5);
            panelRead.Name = "panelRead";
            panelRead.Size = new Size(486, 414);
            panelRead.TabIndex = 19;
            // 
            // dataGridOneSale
            // 
            dataGridOneSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOneSale.Location = new Point(109, 130);
            dataGridOneSale.Margin = new Padding(5, 5, 5, 5);
            dataGridOneSale.Name = "dataGridOneSale";
            dataGridOneSale.RowHeadersWidth = 51;
            dataGridOneSale.Size = new Size(280, 173);
            dataGridOneSale.TabIndex = 21;
            // 
            // readId
            // 
            readId.Location = new Point(41, 21);
            readId.Margin = new Padding(5, 5, 5, 5);
            readId.Name = "readId";
            readId.Size = new Size(244, 39);
            readId.TabIndex = 21;
            // 
            // endRead
            // 
            endRead.Location = new Point(115, 74);
            endRead.Margin = new Padding(5, 5, 5, 5);
            endRead.Name = "endRead";
            endRead.Size = new Size(276, 46);
            endRead.TabIndex = 20;
            endRead.Text = "הטען נתונים";
            endRead.UseVisualStyleBackColor = true;
            endRead.Click += endRead_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 6);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 14;
            label3.Text = "הכנס מזהה";
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(filter);
            panelReadAll.Controls.Add(dataGridAllSales);
            panelReadAll.Location = new Point(556, 339);
            panelReadAll.Margin = new Padding(5, 5, 5, 5);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(408, 355);
            panelReadAll.TabIndex = 15;
            // 
            // filter
            // 
            filter.Location = new Point(125, 256);
            filter.Margin = new Padding(5, 5, 5, 5);
            filter.Name = "filter";
            filter.Size = new Size(153, 46);
            filter.TabIndex = 8;
            filter.Text = "סינון לקוחות מועדון";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // dataGridAllSales
            // 
            dataGridAllSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllSales.Location = new Point(5, 19);
            dataGridAllSales.Margin = new Padding(5, 5, 5, 5);
            dataGridAllSales.Name = "dataGridAllSales";
            dataGridAllSales.RowHeadersWidth = 51;
            dataGridAllSales.Size = new Size(398, 227);
            dataGridAllSales.TabIndex = 7;
            dataGridAllSales.CellContentClick += dataGridAllSales_CellContentClick;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(endDelete);
            panelDelete.Controls.Add(idDelete);
            panelDelete.Controls.Add(label4);
            panelDelete.Location = new Point(10, 5);
            panelDelete.Margin = new Padding(5, 5, 5, 5);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(450, 333);
            panelDelete.TabIndex = 18;
            // 
            // endDelete
            // 
            endDelete.Location = new Point(176, 136);
            endDelete.Margin = new Padding(5, 5, 5, 5);
            endDelete.Name = "endDelete";
            endDelete.Size = new Size(153, 46);
            endDelete.TabIndex = 19;
            endDelete.Text = "הטען נתונים";
            endDelete.UseVisualStyleBackColor = true;
            endDelete.Click += endDelete_Click;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(110, 82);
            idDelete.Margin = new Padding(5, 5, 5, 5);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(244, 39);
            idDelete.TabIndex = 18;
            idDelete.ValueChanged += idDelete_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 22);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
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
            panelProperties.Location = new Point(884, 202);
            panelProperties.Margin = new Padding(5, 5, 5, 5);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(463, 621);
            panelProperties.TabIndex = 14;
            panelProperties.Paint += panelProperties_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 230);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 32);
            label9.TabIndex = 33;
            label9.Text = "מחיר במבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(291, 378);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(130, 32);
            label12.TabIndex = 32;
            label12.Text = "תאריך סיום";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 182);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 32);
            label8.TabIndex = 28;
            label8.Text = "כמות למבצע";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(280, 325);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(162, 32);
            label11.TabIndex = 31;
            label11.Text = "תאריך התחלה";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 62);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 32);
            label7.TabIndex = 27;
            label7.Text = "מזהה מבצע";
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(32, 374);
            dateEnd.Margin = new Padding(5, 5, 5, 5);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(238, 39);
            dateEnd.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(276, 131);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(126, 32);
            label10.TabIndex = 30;
            label10.Text = "מזהה מוצר";
            // 
            // dateStart
            // 
            dateStart.Location = new Point(29, 323);
            dateStart.Margin = new Padding(5, 5, 5, 5);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(238, 39);
            dateStart.TabIndex = 25;
            // 
            // checkBoxClub
            // 
            checkBoxClub.AutoSize = true;
            checkBoxClub.Cursor = Cursors.IBeam;
            checkBoxClub.ForeColor = Color.DarkCyan;
            checkBoxClub.Location = new Point(76, 274);
            checkBoxClub.Margin = new Padding(5, 5, 5, 5);
            checkBoxClub.Name = "checkBoxClub";
            checkBoxClub.Size = new Size(178, 36);
            checkBoxClub.TabIndex = 24;
            checkBoxClub.Text = "למועדון בלבד";
            checkBoxClub.UseVisualStyleBackColor = true;
            // 
            // priceForSale
            // 
            priceForSale.Location = new Point(20, 221);
            priceForSale.Margin = new Padding(5, 5, 5, 5);
            priceForSale.Name = "priceForSale";
            priceForSale.Size = new Size(244, 39);
            priceForSale.TabIndex = 23;
            // 
            // amountSale
            // 
            amountSale.Location = new Point(21, 168);
            amountSale.Margin = new Padding(5, 5, 5, 5);
            amountSale.Name = "amountSale";
            amountSale.Size = new Size(244, 39);
            amountSale.TabIndex = 22;
            // 
            // idProduct
            // 
            idProduct.Location = new Point(21, 118);
            idProduct.Margin = new Padding(5, 5, 5, 5);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(244, 39);
            idProduct.TabIndex = 21;
            // 
            // endCreateAndUpdate
            // 
            endCreateAndUpdate.Location = new Point(104, 446);
            endCreateAndUpdate.Margin = new Padding(5, 5, 5, 5);
            endCreateAndUpdate.Name = "endCreateAndUpdate";
            endCreateAndUpdate.Size = new Size(254, 46);
            endCreateAndUpdate.TabIndex = 18;
            endCreateAndUpdate.Text = "הטען נתונים";
            endCreateAndUpdate.UseVisualStyleBackColor = true;
            endCreateAndUpdate.Click += endCreateAndUpdate_Click;
            // 
            // idSale
            // 
            idSale.Location = new Point(21, 59);
            idSale.Margin = new Padding(5, 5, 5, 5);
            idSale.Name = "idSale";
            idSale.Size = new Size(244, 39);
            idSale.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 22);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 13;
            label2.Text = "הנס פרטי מבצע";
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(label6);
            panelTitle.Controls.Add(label5);
            panelTitle.Controls.Add(label1);
            panelTitle.Location = new Point(884, 112);
            panelTitle.Margin = new Padding(5, 5, 5, 5);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(406, 80);
            panelTitle.TabIndex = 28;
            panelTitle.Paint += panelTitle_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 155);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 32);
            label6.TabIndex = 2;
            label6.Text = "מבצעים🌟";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 22);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 32);
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
            panel3.Location = new Point(1357, 202);
            panel3.Margin = new Padding(5, 5, 5, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 546);
            panel3.TabIndex = 27;
            panel3.Paint += panel3_Paint;
            // 
            // read
            // 
            read.Location = new Point(96, 91);
            read.Margin = new Padding(5, 5, 5, 5);
            read.Name = "read";
            read.Size = new Size(216, 46);
            read.TabIndex = 2;
            read.Text = "הצגת מבצע";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // readAll
            // 
            readAll.Location = new Point(52, 182);
            readAll.Margin = new Padding(5, 5, 5, 5);
            readAll.Name = "readAll";
            readAll.Size = new Size(260, 46);
            readAll.TabIndex = 5;
            readAll.Text = "הצגת כל המבצעים";
            readAll.UseVisualStyleBackColor = true;
            readAll.Click += readAll_Click;
            // 
            // create
            // 
            create.Location = new Point(159, 264);
            create.Margin = new Padding(5, 5, 5, 5);
            create.Name = "create";
            create.Size = new Size(153, 46);
            create.TabIndex = 4;
            create.Text = "יצירת מבצע חדש";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // delete
            // 
            delete.Location = new Point(143, 445);
            delete.Margin = new Padding(5, 5, 5, 5);
            delete.Name = "delete";
            delete.Size = new Size(169, 46);
            delete.TabIndex = 6;
            delete.Text = "מחיקת מבצע";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(159, 358);
            update.Margin = new Padding(5, 5, 5, 5);
            update.Name = "update";
            update.Size = new Size(153, 46);
            update.TabIndex = 3;
            update.Text = "עדכון לקוח";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1788, 1029);
            Controls.Add(panelProperties);
            Controls.Add(back);
            Controls.Add(panelCenter);
            Controls.Add(panelTitle);
            Controls.Add(panel3);
            Margin = new Padding(5, 5, 5, 5);
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