using System;
using System.Windows.Forms;

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
            serviceComboBox.DisplayMember = "Наименование";
            serviceComboBox.ValueMember = "Id";
        }

        private void addServiceJournal_Click(object sender, EventArgs e)
        {
            //Controller.AddServiceJournal((int)serviceComboBox.SelectedValue, idOrder, (int)timeNumericUpDown.Value);
            Controller.MakeServiceJournal(Convert.ToInt32(serviceComboBox.SelectedValue), idOrder, (int)timeNumericUpDown.Value);
            parentForm.ShowServiceJournals();
            this.Close();
        }
    }
}
