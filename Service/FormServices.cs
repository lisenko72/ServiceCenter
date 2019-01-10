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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();

            comboBox1.DataSource = Register.getServices();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void addServiceItemLine(object sender, EventArgs e)
        {
            //добавление услуги и времени работы
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void FormServices_Load(object sender, EventArgs e)
        {

        }
    }
}
