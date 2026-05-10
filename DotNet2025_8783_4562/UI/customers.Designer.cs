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
            massageDelete = new Label();
            endDelete = new Button();
            onlyId = new NumericUpDown();
            label2 = new Label();
            panel4 = new Panel();
            readMassage = new Label();
            dataGridView2 = new DataGridView();
            readId = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            panelCenter = new Panel();
            readAllMassage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)id).BeginInit();
            panelReadAll.SuspendLayout();
            panel3.SuspendLayout();
            panelTitle.SuspendLayout();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)onlyId).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readId).BeginInit();
            panelCenter.SuspendLayout();
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
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(245, 142);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // name
            // 
            name.Location = new Point(98, 75);
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
            panel1.Location = new Point(553, 15);
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
            massageCreate.Size = new Size(147, 20);
            massageCreate.TabIndex = 19;
            massageCreate.Text = "הלקוח עודכן בהצלחה";
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
            panelReadAll.Controls.Add(readAllMassage);
            panelReadAll.Controls.Add(filter);
            panelReadAll.Controls.Add(dataGridView1);
            panelReadAll.Location = new Point(342, 212);
            panelReadAll.Name = "panelReadAll";
            panelReadAll.Size = new Size(251, 222);
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
            panelTitle.Location = new Point(525, 12);
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
            panelDelete.Location = new Point(6, 3);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(277, 208);
            panelDelete.TabIndex = 18;
            panelDelete.Paint += panelDelete_Paint;
            // 
            // massageDelete
            // 
            massageDelete.AutoSize = true;
            massageDelete.Location = new Point(68, 137);
            massageDelete.Name = "massageDelete";
            massageDelete.Size = new Size(168, 20);
            massageDelete.TabIndex = 20;
            massageDelete.Text = "המחיקה בוצעה בהצלחה";
            massageDelete.Click += massageDelete_Click;
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
            // onlyId
            // 
            onlyId.Location = new Point(68, 51);
            onlyId.Name = "onlyId";
            onlyId.Size = new Size(150, 27);
            onlyId.TabIndex = 18;
            onlyId.ValueChanged += onlyId_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 14);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 13;
            label2.Text = "הכנס מזהה";
            // 
            // panel4
            // 
            panel4.Controls.Add(readMassage);
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(readId);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 259);
            panel4.TabIndex = 19;
            panel4.Paint += panel4_Paint;
            // 
            // readMassage
            // 
            readMassage.AutoSize = true;
            readMassage.Location = new Point(123, 213);
            readMassage.Name = "readMassage";
            readMassage.Size = new Size(95, 20);
            readMassage.TabIndex = 22;
            readMassage.Text = "לקוח לא קיים";
            readMassage.Click += readMassage_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(67, 81);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(172, 108);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // readId
            // 
            readId.Location = new Point(25, 13);
            readId.Name = "readId";
            readId.Size = new Size(150, 27);
            readId.TabIndex = 21;
            readId.ValueChanged += readId_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(71, 46);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 20;
            button1.Text = "הטען נתונים";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 4);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 14;
            label3.Text = "הכנס מזהה";
            label3.Click += label3_Click;
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(panel1);
            panelCenter.Controls.Add(panel4);
            panelCenter.Controls.Add(panelReadAll);
            panelCenter.Controls.Add(panelDelete);
            panelCenter.Location = new Point(12, 68);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(789, 446);
            panelCenter.TabIndex = 20;
            panelCenter.Paint += panelCenter_Paint;
            // 
            // readAllMassage
            // 
            readAllMassage.AutoSize = true;
            readAllMassage.Location = new Point(37, 199);
            readAllMassage.Name = "readAllMassage";
            readAllMassage.Size = new Size(183, 20);
            readAllMassage.TabIndex = 23;
            readAllMassage.Text = "לא קיימים לקוחות במערכת";
            readAllMassage.Click += readAllMassage_Click;
            // 
            // customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 514);
            Controls.Add(panelCenter);
            Controls.Add(panelTitle);
            Controls.Add(panel3);
            Name = "customers";
            Text = "customers";
            Load += customers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)id).EndInit();
            panelReadAll.ResumeLayout(false);
            panelReadAll.PerformLayout();
            panel3.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)onlyId).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)readId).EndInit();
            panelCenter.ResumeLayout(false);
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
        private Panel panel4;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button1;
        private NumericUpDown readId;
        private Panel panelCenter;
        private Label readMassage;
        private Label readAllMassage;
    }
}