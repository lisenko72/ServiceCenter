using System;
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
            dataGridView1.DataSource = Controller.GetOrders();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if (selectedIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["Id"].Value);
                var editOrderForm = new EditOrderForm(this, orderId);
                editOrderForm.ShowDialog();
            }
        }
    }
}