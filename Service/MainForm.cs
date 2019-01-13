using System;
using System.Windows.Forms;
using Service.Logic;

namespace Service
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ListStatuses.GetInstance();
            ListServices.GetInstance();
            ListOrders.GetInstance();
            ListOrdersAndServices.MakeCompletedService(1, 1, 13);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orders = new OrdersForm();
            orders.ShowDialog();
        }
    }
}