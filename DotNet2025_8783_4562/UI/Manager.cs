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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            customers nextForm = new customers();

            nextForm.Show();
            this.Hide();

        }

        private void products_Click(object sender, EventArgs e)
        {
            products nextForm = new products();

            nextForm.Show();
            this.Hide();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            sales nextForm = new sales();

            nextForm.Show();
            this.Hide();
        }
    }
}
