using System;
using System.Windows.Forms;

namespace Service
{
    public partial class EditOrderForm : Form
    {
        private readonly int idOrder;
        private OrdersForm parentForm;

        public EditOrderForm(OrdersForm ordersForm, int idOrder)
        {
            this.idOrder = idOrder;
            parentForm = ordersForm;

            InitializeComponent();

            FillStatuses();
            ShowOrder();
            ShowServiceJournals();
        }

        private void ShowOrder()
        {
            shortDescriptionLabel.Text = Controller.GetOrderShortDescription(idOrder);
            dateStartValueLabel.Text = Controller.GetOrderDateCreate(idOrder).ToLongDateString();
            statusComboBox.SelectedValue = Controller.GetOrderStatusId(idOrder);
            descriptionRichTextBox.Text = Controller.GetOrderDescription(idOrder);
            timeOrderLabel.Text = Controller.GetOrderTime(idOrder) + " мин.";
            if (Controller.GetOrderDateEnd(idOrder) != DateTime.MinValue)
                dateEndDateTimePicker.Value = Controller.GetOrderDateEnd(idOrder);
        }

        private void FillStatuses()
        {
            statusComboBox.DataSource = Controller.GetStatuses();
            statusComboBox.DisplayMember = "Наименование";
            statusComboBox.ValueMember = "Id";
        }

        public void ShowServiceJournals()
        {
            serviceJournalsDataGridView.DataSource = Controller.GetServiceJournals(idOrder);
        }

        private void dateEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateEndDateTimePicker.CustomFormat = "dd MMM yyyy HH:mm";
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            var addServiceJournalForm = new AddServiceJournalForm(idOrder, this);
            addServiceJournalForm.ShowDialog();
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            if (Controller.UpdateOrder(
                idOrder,
                dateEndDateTimePicker.Value,
                Convert.ToInt32(statusComboBox.SelectedValue),
                descriptionRichTextBox.Text))
            {
                parentForm.ShowOrders();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}