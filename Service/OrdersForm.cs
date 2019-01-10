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

        public void ShowOrders()
        {
            var orders = Controller.GetOrders();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Дата создания");
            dataTable.Columns.Add("Краткое описание");
            dataTable.Columns.Add("Статус");
            dataTable.Columns.Add("Дата завершения");
            foreach (var order in orders)
            {
                dataTable.Rows.Add(order.Id, order.DateCreate, order.ShortDescription, order.Status.Name, order.DateEnd);
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if (selectedIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["Id"].Value);
                var editOrderForm = new EditOrderForm(this, orderId);
                editOrderForm.ShowDialog();
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}