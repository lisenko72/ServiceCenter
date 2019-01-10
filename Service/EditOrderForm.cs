using System;
using System.Windows.Forms;
using Service.Logic;

namespace Service
{
    public partial class EditOrderForm : Form
    {
        public EditOrderForm(int idOrder)
        {
            InitializeComponent();

            LoadStatuses();
            ShowOrder(idOrder);
        }

        private void ShowOrder(int id)
        {
            var order = Controller.GetOrder(id);
            shortDescriptionTextBox.Text = order.ShortDescription;
            dateCreateDateTimePicker.Value = order.DateCreate;
            if (order.DateEnd != DateTime.MinValue)
                dateEndDateTimePicker.Value = order.DateEnd;
            statusComboBox.SelectedValue = order.Status.Id;
            descriptionRichTextBox.Text = order.Description;
        }
        
        public void LoadStatuses()
        {
            statusComboBox.DataSource = Controller.GetStatuses();
            statusComboBox.DisplayMember = "Name";
            statusComboBox.ValueMember = "Id";
        }

        private void dateEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateEndDateTimePicker.CustomFormat = "dd MMM yyyy HH:mm";
        }
    }
}