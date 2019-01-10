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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void openWorkLog(object sender, EventArgs e)
        {
            FormWorkLog workLog = new FormWorkLog();
            workLog.Show();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseContext.Statuses;
            dataGridView1.Columns["Id"].Visible = false;
        }
    }
}
