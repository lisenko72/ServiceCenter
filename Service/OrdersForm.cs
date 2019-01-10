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
using Service.Logic;

namespace Service
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void openWorkLog(object sender, EventArgs e)
        {
            WorkJournalForm workLog = new WorkJournalForm();
            workLog.Show();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseContext.Statuses;
            dataGridView1.Columns["Id"].Visible = false;
        }
    }
}
