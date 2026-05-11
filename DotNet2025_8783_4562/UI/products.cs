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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            SetFilterVisibility();
            panelRead.Visible = true;
            panelRead.Dock = DockStyle.Fill;
            dataGridView2.Visible = false;
            readMassage.Visible = false;
        }

        private void readAllProducts_Click(object sender, EventArgs e)
        {
            SetFilterVisibility();
            readAllMassage.Visible = false;

            panelReadAll.Visible = true;
            panelReadAll.Dock = DockStyle.Fill;
            List<BL.BO.Product?> productsList = _productLogic.ReadAll();
            if (productsList != null)
            {
                //dataGridView1.DataSource = null;
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
            panelDetailes.Visible = true;
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
            panelDelete.Visible = true;
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
                        //  product.ProductId = 0;
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

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
