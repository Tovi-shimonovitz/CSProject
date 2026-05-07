namespace UI
{
    partial class customers
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
            title = new Label();
            read = new Button();
            update = new Button();
            create = new Button();
            readAllCustomers = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            filter = new Button();
            name = new TextBox();
            adress = new TextBox();
            phone = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            massageCreate = new Label();
            endCreate = new Button();
            id = new NumericUpDown();
            panel2 = new Panel();
            panelReadAll = new Panel();
            panel3 = new Panel();
            panelTitle = new Panel();
            panelDelete = new Panel();
            endDelete = new Button();
            onlyId = new NumericUpDown();
            label2 = new Label();
            massageDelete = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)id).BeginInit();
            panelReadAll.SuspendLayout();
            panel3.SuspendLayout();
            panelTitle.SuspendLayout();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)onlyId).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(82, 14);
            title.Name = "title";
            title.Size = new Size(77, 20);
            title.TabIndex = 0;
            title.Text = "לקוחות🏬";
            title.Click += label1_Click;
            // 
            // read
            // 
            read.Location = new Point(98, 57);
            read.Name = "read";
            read.Size = new Size(94, 29);
            read.TabIndex = 2;
            read.Text = "הצגת לקוח";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
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
            // create
            // 
            create.Location = new Point(98, 165);
            create.Name = "create";
            create.Size = new Size(94, 29);
            create.TabIndex = 4;
            create.Text = "יצירת לקוח חדש";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // readAllCustomers
            // 
            readAllCustomers.Location = new Point(32, 114);
            readAllCustomers.Name = "readAllCustomers";
            readAllCustomers.Size = new Size(160, 29);
            readAllCustomers.TabIndex = 5;
            readAllCustomers.Text = "הצגת כל הלקוחות";
            readAllCustomers.UseVisualStyleBackColor = true;
            readAllCustomers.Click += readAllCustomers_Click;
            // 
            // delete
            // 
            delete.Location = new Point(88, 278);
            delete.Name = "delete";
            delete.Size = new Size(104, 29);
            delete.TabIndex = 6;
            delete.Text = "מחיקת לקוח";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(172, 108);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // filter
            // 
            filter.Location = new Point(75, 146);
            filter.Name = "filter";
            filter.Size = new Size(94, 29);
            filter.TabIndex = 8;
            filter.Text = "סינון לקוחות מועדון";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // name
            // 
            name.Location = new Point(90, 70);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 10;
            name.TextChanged += name_TextChanged;
            // 
            // adress
            // 
            adress.Location = new Point(98, 111);
            adress.Name = "adress";
            adress.Size = new Size(125, 27);
            adress.TabIndex = 11;
            adress.TextChanged += adress_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(95, 149);
            phone.Name = "phone";
            phone.Size = new Size(125, 27);
            phone.TabIndex = 12;
            phone.TextChanged += phone_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 13;
            label1.Text = "הכנס מזהה שם כתובת וטלפון";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(massageCreate);
            panel1.Controls.Add(endCreate);
            panel1.Controls.Add(id);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(phone);
            panel1.Controls.Add(name);
            panel1.Controls.Add(adress);
            panel1.Location = new Point(525, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 284);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // massageCreate
            // 
            massageCreate.AutoSize = true;
            massageCreate.Location = new Point(46, 246);
            massageCreate.Name = "massageCreate";
            massageCreate.Size = new Size(142, 20);
            massageCreate.TabIndex = 19;
            massageCreate.Text = "הלקוח נוצר בהצלחה";
            massageCreate.Click += massageCreate_Click;
            // 
            // endCreate
            // 
            endCreate.Location = new Point(64, 194);
            endCreate.Name = "endCreate";
            endCreate.Size = new Size(156, 29);
            endCreate.TabIndex = 18;
            endCreate.Text = "הטען נתונים";
            endCreate.UseVisualStyleBackColor = true;
            endCreate.Click += endCreate_Click;
            // 
            // id
            // 
            id.Location = new Point(70, 37);
            id.Name = "id";
            id.Size = new Size(150, 27);
            id.TabIndex = 17;
            id.ValueChanged += id_ValueChanged;
            // 
            // panel2
            // 
            panel2.Location = new Point(221, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 384);
            panel2.TabIndex = 16;
            // 
            // panelReadAll
            // 
            panelReadAll.Controls.Add(filter);
            panelReadAll.Controls.Add(dataGridView1);
            panelReadAll.Location = new Point(257, 82);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(250, 197);
            panelReadAll.TabIndex = 15;
            panelReadAll.Paint += panelReadAll_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(read);
            panel3.Controls.Add(readAllCustomers);
            panel3.Controls.Add(create);
            panel3.Controls.Add(delete);
            panel3.Controls.Add(update);
            panel3.Location = new Point(807, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 341);
            panel3.TabIndex = 16;
            panel3.Paint += panelMenue_Paint;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(title);
            panelTitle.Location = new Point(400, 12);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(250, 50);
            panelTitle.TabIndex = 17;
            panelTitle.Paint += panelTitle_Paint;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(massageDelete);
            panelDelete.Controls.Add(endDelete);
            panelDelete.Controls.Add(onlyId);
            panelDelete.Controls.Add(label2);
            panelDelete.Location = new Point(1, 86);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(250, 220);
            panelDelete.TabIndex = 18;
            panelDelete.Paint += panelDelete_Paint;
            // 
            // endDelete
            // 
            endDelete.Location = new Point(80, 81);
            endDelete.Name = "endDelete";
            endDelete.Size = new Size(94, 29);
            endDelete.TabIndex = 19;
            endDelete.Text = "הטען נתונים";
            endDelete.UseVisualStyleBackColor = true;
            endDelete.Click += endDelete_Click;
            // 
            // onlyId
            // 
            onlyId.Location = new Point(53, 34);
            onlyId.Name = "onlyId";
            onlyId.Size = new Size(150, 27);
            onlyId.TabIndex = 18;
            onlyId.ValueChanged += onlyId_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 6);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 13;
            label2.Text = "הכנס מזהה";
            // 
            // massageDelete
            // 
            massageDelete.AutoSize = true;
            massageDelete.Location = new Point(35, 168);
            massageDelete.Name = "massageDelete";
            massageDelete.Size = new Size(168, 20);
            massageDelete.TabIndex = 20;
            massageDelete.Text = "המחיקה בוצעה בהצלחה";
            massageDelete.Click += massageDelete_Click;
            // 
            // customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 514);
            Controls.Add(panelDelete);
            Controls.Add(panelTitle);
            Controls.Add(panel3);
            Controls.Add(panelReadAll);
            Controls.Add(panel1);
            Name = "customers";
            Text = "customers";
            Load += customers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)id).EndInit();
            panelReadAll.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)onlyId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Button read;
        private Button update;
        private Button create;
        private Button readAllCustomers;
        private Button delete;
        private DataGridView dataGridView1;
        private Button filter;
        private TextBox name;
        private TextBox adress;
        private TextBox phone;
        private Label label1;
        private Panel panel1;
        private Panel panelReadAll;
        private Panel panel2;
        private Panel panel3;
        private Panel panelTitle;
        private NumericUpDown id;
        private Button endCreate;
        private Label massageCreate;
        private Panel panelDelete;
        private NumericUpDown onlyId;
        private Label label2;
        private Button endDelete;
        private Label massageDelete;
    }
}