using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.BlApi;
using BL.BO;

namespace UI
{
    public partial class products : Form
    {
        static IBl ibl;
        static string typeButton = "create";
        static IProduct _productLogic;
        public products()
        {
            ibl = Factory.Get();
            _productLogic = ibl.Product;
            InitializeComponent();
            SetFilterVisibility();

        }
        private void SetFilterVisibility()
        {
            panelReadAll.Visible = false;
            panelDetailes.Visible = false;
            panelDelete.Visible = false;
            panelRead.Visible = false;
        }
        private void products_Load(object sender, EventArgs e)
        {
            price.Maximum = int.MaxValue;
            category.DataSource = Enum.GetValues(typeof(BL.BO.Category));
            Color darkBlue = Color.FromArgb(45, 52, 71);
            Color actionBlue = Color.FromArgb(0, 120, 215);

            // --- הגדרות חלון ---
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(240, 242, 245);

            // --- סרגל צד ימין ---
            actions.Dock = DockStyle.Right;
            actions.Width = 380; // רחב מספיק לכל טקסט
            actions.BackColor = darkBlue;
            actions.Padding = new Padding(20, 100, 20, 20);

            foreach (Control c in actions.Controls)
            {
                if (c is Button btn)
                {
                    btn.Dock = DockStyle.Top;
                    btn.Height = 85;
                    btn.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                    btn.Margin = new Padding(0, 0, 0, 20);
                    btn.Cursor = Cursors.Hand;
                }
            }

            // --- פאנל מרכזי לבן ---
            panelCenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCenter.Location = new Point(60, 140);
            panelCenter.Size = new Size(this.ClientSize.Width - actions.Width - 120, this.ClientSize.Height - 220);
            panelCenter.BackColor = Color.White;

            // --- סידור פאנלים פנימיים וטבלאות ---
            foreach (Control p in panelCenter.Controls)
            {
                if (p is Panel inner)
                {
                    inner.Dock = DockStyle.Fill;
                    inner.BackColor = Color.White;
                    inner.Visible = false;

                    foreach (Control child in inner.Controls)
                    {
                        // הטבלה תמיד תמלא את כל הפאנל - אין יותר דפדוף!
                        if (child is DataGridView dgv)
                        {
                            dgv.Dock = DockStyle.Fill;
                            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgv.Font = new Font("Segoe UI", 12);
                            DesignModernGrid(dgv);
                        }

                        // מרכוז פקדים אחרים (לייבלים ותיבות טקסט)
                        if (!(child is DataGridView))
                        {
                            child.Font = new Font("Segoe UI", 14);
                            child.Left = (inner.Width - child.Width) / 2;
                        }
                    }
                }
            }

            // כפתור חזרה
            back.Dock = DockStyle.Bottom;
            back.Height = 80;
            back.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            back.BackColor = Color.FromArgb(231, 76, 60);
        }
        private void RefreshPanelLayout(Panel activePanel)
        {
            if (activePanel == null) return;

            activePanel.Dock = DockStyle.Fill;

            // מוודא שהפקדים מסודרים לפי הסדר שקבעת (TabIndex)
            var visibleControls = activePanel.Controls.Cast<Control>()
                                  .Where(c => c.Visible)
                                  .OrderBy(c => c.TabIndex)
                                  .ToList();

            if (visibleControls.Count == 0) return;

            int centerX = activePanel.Width / 2;

            // קובעים נקודת התחלה קבועה מלמעלה (למשל 50 פיקסלים מהקצה העליון)
            // זה ימנע מהם "לברוח" למטה כמו בתמונה ששלחת
            int currentY = 50;
            int spacing = 15; // רווח קטן בין פקדים כדי שהכל ייכנס

            foreach (Control ctrl in visibleControls)
            {
                // עיצוב גדלים (כדי שלא יהיו קטנים מדי)
                if (ctrl is Button btn)
                {
                    btn.Size = new Size(300, 50);
                    btn.BackColor = Color.FromArgb(0, 120, 215);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
                else if (ctrl is TextBox || ctrl is NumericUpDown || ctrl is ComboBox)
                {
                    ctrl.Size = new Size(350, 30);
                    ctrl.Font = new Font("Segoe UI", 12);
                }
                else if (ctrl is Label)
                {
                    ctrl.AutoSize = true;
                    ctrl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                }

                // מיקום במרכז ה-X
                ctrl.Left = centerX - (ctrl.Width / 2);

                // הצבה ב-Y הנוכחי
                ctrl.Top = currentY;

                // עדכון ה-Y לפקד הבא
                currentY += ctrl.Height + spacing;
            }
        }
        
        private void DesignModernGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowTemplate.Height = 40;
            dgv.ColumnHeadersHeight = 45;
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // כותרות
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);

            // שורות
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 120, 215);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {

            SetFilterVisibility();
            panelRead.Visible = true;
            panelRead.BringToFront();
            panelRead.Dock = DockStyle.Fill;
            dataGridView2.Visible = false;
            readMassage.Visible = false;
            RefreshPanelLayout(panelRead);
        }

        private void readAllProducts_Click(object sender, EventArgs e)
        {
            SetFilterVisibility();
            readAllMassage.Visible = false;
            panelReadAll.Visible = true; panelReadAll.BringToFront();
            RefreshPanelLayout(panelReadAll);
            panelReadAll.Dock = DockStyle.Fill;
            List<BL.BO.Product?> productsList = _productLogic.ReadAll();
            if (productsList != null)
            {
                dataGridView1.DataSource = productsList;
            }
            else
            {
                readAllMassage.Visible = true;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            updateId.Visible = false;
            typeButton = "create";
            SetFilterVisibility();
            panelDetailes.Visible = true; panelDetailes.BringToFront();
            RefreshPanelLayout(panelDetailes);
            massageCreate.Visible = false;
            panelDetailes.Dock = DockStyle.Fill;

        }

        private void update_Click(object sender, EventArgs e)
        {
            updateId.Visible = true;
            typeButton = "update";
            SetFilterVisibility();
            panelDetailes.Visible = true;
            massageCreate.Visible = false;
            panelDetailes.Dock = DockStyle.Fill;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SetFilterVisibility();
            panelDelete.Visible = true; panelDelete.BringToFront();
            RefreshPanelLayout(panelDelete);
            panelDelete.Dock = DockStyle.Fill;
            massageDelete.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Manager nextForm = new Manager();

            nextForm.Show();
            this.Hide();
        }

        private void endCreate_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    BL.BO.Product? product = new BL.BO.Product();

                    product.ProductName = name.Text;
                    product.Category = (BL.BO.Category?)category.SelectedItem;
                    product.Price = (int)price.Value;
                    product.InStock = (int)stock.Value;
                    product.SaleInProduct = new List<BL.BO.SaleInProduct>();
                    if (typeButton == "create")
                    {
                        _productLogic.Create(product);
                        massageCreate.Visible = true;

                    }
                    else
                    {
                        product.ProductId = (int)updateId.Value;
                        _productLogic.Update(product);
                        massageCreate.Visible = true;

                    }

                }
                catch (BlInvalidInputException)
                {
                    massageCreate.Visible = true;

                    massageCreate.Text = "הפעולה נכשלה, מזהה קיים";
                }

                catch (BlObjectNotFoundException ex)
                {
                    massageCreate.Visible = true;
                    massageCreate.Text = "הפעולה נכשלה, מוצר לא קיים";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var product = _productLogic.Read(int.Parse(readId.Text));

                dataGridView2.Visible = true;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = new List<BL.BO.Product?> { product };
            }
            catch { readMassage.Visible = true; }
        }

        private void endDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _productLogic.Delete((int)onlyId.Value);
                massageDelete.Visible = true;
            }
            catch (BlObjectNotFoundException ex)
            {
                massageDelete.Text = "מוצר לא קיים";
                massageDelete.Visible = true;
            }
            catch (BL.BO.BlIneligibleException)
            {
                massageDelete.Text = "אין אפשרות למחוק מוצר עם מבצע";
                massageDelete.Visible = true;
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            List<BL.BO.Product?> productsList = _productLogic.ReadAll(c => c.Price > 100);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productsList;
        }

        private void updateId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void actions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {

        }
        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
