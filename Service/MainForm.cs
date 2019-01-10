using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Logic;

namespace Service
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseContext.db();
        }

        private void open_FormOrders(object sender, EventArgs e)
        {
            this.Hide();
            var orders = new OrdersForm();
            //orders.Closed += (s, args) => this.Close();
            orders.Show();
        }
    }
}
