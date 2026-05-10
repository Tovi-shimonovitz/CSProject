using BL.BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class customers : Form

    {
        static IBl ibl;
        static ICustomer _customerLogic;
        static string typeButton = "create";

        public customers()
        {
            InitializeComponent();
            SetFilterVisibility();

            panelTitle.Dock = DockStyle.Top;
            panel3.Dock = DockStyle.Right;
            panelCenter.Dock = DockStyle.Fill;
            ibl = Factory.Get();
            _customerLogic = ibl.Customer;

        }
        private void SetFilterVisibility()
        {
            panelReadAll.Visible = false;
            panel1.Visible = false;
            panelDelete.Visible = false;
            panel4.Visible = false;
            //     dataGridView2.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void readAllCustomers_Click(object sender, EventArgs e)
        {

            SetFilterVisibility();
            readAllMassage.Visible = false;

            panelReadAll.Visible = true;
            panelReadAll.Dock = DockStyle.Fill;
            List<BL.BO.Customer?> customersList = _customerLogic.ReadAll();
            if (customersList != null) { 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customersList;
        }
            else
            {
                readAllMassage.Visible = true;
            }


        }

        private void create_Click(object sender, EventArgs e)
        {
            typeButton = "create";
            SetFilterVisibility();
            panel1.Visible = true;
            massageCreate.Visible = false;

            panel1.Dock = DockStyle.Fill;


        }

        private void read_Click(object sender, EventArgs e)
        {
            SetFilterVisibility();
            panel4.Visible = true;
            panel4.Dock = DockStyle.Fill;
            dataGridView2.Visible = false;
            readMassage.Visible = false;


        }

        private void update_Click(object sender, EventArgs e)
        {
            typeButton = "update";
            SetFilterVisibility();
            panel1.Visible = true;
            massageCreate.Visible = false;
            panel1.Dock = DockStyle.Fill;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SetFilterVisibility();
            panelDelete.Visible = true;
            panelDelete.Dock = DockStyle.Fill;
            massageDelete.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            List<BL.BO.Customer?> customersList = _customerLogic.ReadAll(c => c.CustomerId <= 100);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customersList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelReadAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endCreate_Click(object sender, EventArgs e)
        {
            if (typeButton == "create")
            {
                try
                {
                    BL.BO.Customer? customer = new BL.BO.Customer();
                    customer.CustomerId = (int)id.Value;
                    customer.CustomerName = name.Text;
                    customer.Address = adress.Text;
                    customer.Phone = phone.Text;
                    _customerLogic.Create(customer);
                    massageCreate.Visible = true;
                }
                catch
                {
                    massageCreate.Text = "הפעולה נכשלה, מזהה קיים";
                }
            }
            else
            {
                try
                {
                    BL.BO.Customer? customer = new BL.BO.Customer();
                    customer.CustomerId = (int)id.Value;
                    customer.CustomerName = name.Text;
                    customer.Address = adress.Text;
                    customer.Phone = phone.Text;
                    _customerLogic.Update(customer);
                    massageCreate.Visible = true;
                }
                catch
                {
                    massageCreate.Visible = true;
                    massageCreate.Text = "הפעולה נכשלה, לקוח לא קיים";

                }

            }
        }

        private void customers_Load(object sender, EventArgs e)
        {

        }

        private void massageCreate_Click(object sender, EventArgs e)
        {

        }

        private void onlyId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void endDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _customerLogic.Delete((int)onlyId.Value);
                massageDelete.Visible = true;
            }
            catch
            {
                massageDelete.Text = "לקוח לא קיים";
                massageDelete.Visible = true;

            }

        }

        private void massageDelete_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerLogic.Read(int.Parse(readId.Text));

                dataGridView2.Visible = true;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = new List<BL.BO.Customer?> { customer };
            }
            catch { readMassage.Visible = true; }

        }

        private void readId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void readMassage_Click(object sender, EventArgs e)
        {

        }

        private void readAllMassage_Click(object sender, EventArgs e)
        {

        }
    }
}
