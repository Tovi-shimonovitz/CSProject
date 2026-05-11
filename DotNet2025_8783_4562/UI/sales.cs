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

namespace UI
{
    public partial class sales : Form
    {
        static IBl ibl;
        static ISale _saleLogic;
        static string typeButton = "create";
        public sales()
        {
            ibl = Factory.Get();
            _saleLogic = ibl.Sale;
            InitializeComponent();
            visable();
        }
        public void visable()
        {
            panelReadAll.Visible = false;
            panelDelete.Visible = false;
            panelRead.Visible = false;
            panelProperties.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void readAllMassage_Click(object sender, EventArgs e)
        {

        }

        private void panelProperties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            visable();
            panelRead.Visible = true;
        }

        private void readAll_Click(object sender, EventArgs e)
        {
            visable();
            panelReadAll.Visible = true;
            dataGridAllSales.DataSource = null;




            List<BL.BO.Sale?> saleList = _saleLogic.ReadAll();
            if (saleList != null)
            {
                dataGridAllSales.DataSource = null;
                dataGridAllSales.DataSource = saleList;
            }
            else
            {
                MessageBox.Show($"לא קיימים מבצעים במערכת");

            }


        }

        private void dataGridAllSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            visable();
            panelProperties.Visible = true;
            typeButton = "create";
        }

        private void update_Click(object sender, EventArgs e)
        {
            visable();
            panelProperties.Visible = true;
            typeButton = "update";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            visable();
            panelDelete.Visible = true;
        }

        private void endCreateAndUpdate_Click(object sender, EventArgs e)
        {
            if (typeButton == "create")
            {
                try
                {
                    _saleLogic.Create(new BL.BO.Sale
                    {
                        SaleId = int.Parse(idSale.Text),
                        ProductId = int.Parse(idProduct.Text),
                        AmountForSale = int.Parse(amountSale.Text),
                        PriceSale = double.Parse(priceForSale.Text),
                        JustForClub = checkBoxClub.Checked,
                    });
                    MessageBox.Show("Sale created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating sale: {ex.Message}");
                }
            }
            else if (typeButton == "update")
            {
                try
                {
                    _saleLogic.Update(new BL.BO.Sale
                    {
                        SaleId = int.Parse(idSale.Text),
                        ProductId = int.Parse(idProduct.Text),
                        AmountForSale = int.Parse(amountSale.Text),
                        PriceSale = double.Parse(priceForSale.Text),
                        JustForClub = checkBoxClub.Checked
                    });
                    MessageBox.Show("Sale updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating sale: {ex.Message}");
                }
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            dataGridAllSales.DataSource = null;
            dataGridAllSales.DataSource = _saleLogic.ReadAll(s => s.JustForClub = true);
        }

        private void endDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _saleLogic.Delete(int.Parse(idDelete.Text));
                MessageBox.Show("Sale deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting sale: {ex.Message}");
            }


        }

        private void idDelete_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endRead_Click(object sender, EventArgs e)
        {
            try
            {
                var sale = _saleLogic.Read(int.Parse(readId.Text));
                dataGridOneSale.DataSource = new List<BL.BO.Sale?> { sale };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading sale: {ex.Message}");
            }
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Manager nextForm = new Manager();

            nextForm.Show();
            this.Hide();
        }
    }
}
