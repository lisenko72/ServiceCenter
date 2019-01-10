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
    public partial class AddServiceJournalForm : Form
    {
        private int idOrder;
        private EditOrderForm parentForm;

        public AddServiceJournalForm(int idOrder, EditOrderForm editOrderForm)
        {
            this.idOrder = idOrder;
            parentForm = editOrderForm;
            InitializeComponent();

            FillServices();
        }

        public void FillServices()
        {
            serviceComboBox.DataSource = Controller.GetServices();
            serviceComboBox.DisplayMember = "Name";
            serviceComboBox.ValueMember = "Id";
        }

        private void addServiceJournal_Click(object sender, EventArgs e)
        {
            Controller.AddServiceJournal((int)serviceComboBox.SelectedValue, idOrder, (int)timeNumericUpDown.Value);
            parentForm.ShowServiceJournals();
            this.Close();
        }
    }
}
