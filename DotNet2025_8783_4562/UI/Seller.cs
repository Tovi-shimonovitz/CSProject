using BL.BlApi;
using BL.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class back : Form
    {
        static IBl ibl;
        static IOrder _orderLogic;
        static Order order = new Order();
        public back()
        {
            InitializeComponent();
            ibl = Factory.Get();
            _orderLogic = ibl.Order;
            enterProperties.Visible = false;
            startOrder.Visible = false;
            panel2.Visible = false;
        }
        public void showAllProductsInOrder()
        {
            showAllProducts.DataSource = null;
            showAllProducts.DataSource = order.productInOrder;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void createNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void isClub_Click(object sender, EventArgs e)
        {

        }

        private void hasClub_Click(object sender, EventArgs e)
        {
            enterProperties.Visible = true;
            enterProperties.Dock = DockStyle.Fill;

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }

        private void enterProperties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitClub_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = ibl.Customer.Read((int)idClub.Value);
                order.IsPreferred = true;
            }
            catch
            {
                order.IsPreferred = false;
                MessageBox.Show("לקוח לא קיים במועדון");
            }
            finally
            {
                enterProperties.Visible = false;
                startOrder.Visible = true;
                newOrder.Visible = false;
                totalPrice.Visible = false;


            }
        }

        private void idClub_ValueChanged(object sender, EventArgs e)
        {

        }

        private void noClub_Click(object sender, EventArgs e)
        {
            order.IsPreferred = false;
            MessageBox.Show("הזמנת לקוח ללא מועדון");
            startOrder.Visible = true;
            totalPrice.Visible = false;
            newOrder.Visible = false;


        }

        private void startOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showAllProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void submitDataProduct_Click(object sender, EventArgs e)
        {
            try
            {
                totalPrice.Visible = false;

                _orderLogic.AddProductToOrder(order, (int)idOfNewProduct.Value, (int)amountOfProduct.Value);
                showAllProductsInOrder();
            }
            catch (BlObjectNotFoundException)
            {
                MessageBox.Show("מוצר לא קיים ");

            }
            catch (BlIneligibleException)
            {
                MessageBox.Show("המוצר אזל מהמלאי ");
            }
            finally
            {
                panel2.Visible = false;
            }
        }

        private void totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void showPrice_Click(object sender, EventArgs e)
        {
            totalPrice.Text = order.TotalPrice.ToString();


            totalPrice.Visible = true;

        }

        private void doOrder_Click(object sender, EventArgs e)
        {
            try
            {
                _orderLogic.DoOrder(order);
                MessageBox.Show("הזמתנך בוצעה בהצלחה שמחנו לתת שרות🌟🌟🌟");
                startOrder.Visible = false;
                newOrder.Visible = true;
                order = new Order();

            }
            catch (BlInvalidInputException)
            {
                MessageBox.Show("הזמנה ללא מוצרים");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Store nextForm = new Store();

            nextForm.Show();
            this.Hide();
        }
    }
}
