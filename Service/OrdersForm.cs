using Service.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Service
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowOrders()
        {
            var orders = Controller.GetOrders();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Краткое описание");
            dataTable.Columns.Add("Статус");
            foreach (var order in orders)
            {
                dataTable.Rows.Add(order.ShortDescription, order.Status.Name);
            }

            dataGridView1.DataSource = dataTable;
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            int selectedOrder = 1;
            var editOrderForm = new EditOrderForm(selectedOrder);
            editOrderForm.ShowDialog();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}