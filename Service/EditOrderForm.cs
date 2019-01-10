using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Service.Logic;

namespace Service
{
    public partial class EditOrderForm : Form
    {
        private readonly int idOrder;
        public EditOrderForm(int idOrder)
        {
            this.idOrder = idOrder;
            InitializeComponent();

            FillStatuses();
            ShowOrder();
            ShowServiceJournals();
        }

        private void ShowOrder()
        {
            var order = Controller.GetOrder(idOrder);
            shortDescriptionTextBox.Text = order.ShortDescription;
            dateCreateDateTimePicker.Value = order.DateCreate;
            if (order.DateEnd != DateTime.MinValue)
                dateEndDateTimePicker.Value = order.DateEnd;
            statusComboBox.SelectedValue = order.Status.Id;
            descriptionRichTextBox.Text = order.Description;
        }
        
        private void FillStatuses()
        {
            statusComboBox.DataSource = Controller.GetStatuses();
            statusComboBox.DisplayMember = "Name";
            statusComboBox.ValueMember = "Id";
        }

        public void ShowServiceJournals()
        {
            var serviceJournals = (from serviceJournal in Controller.GetServiceJournals(idOrder)
                                    group serviceJournal by serviceJournal.Service.Name
                                    into g
                                    select new { g.Key, Sum = g.Sum(s => s.Time) }).ToList();
            var dataTable = new DataTable();
            dataTable.Columns.Add("Услуга");
            dataTable.Columns.Add("Время");
            foreach (var serviceJournal in serviceJournals)
            {
                dataTable.Rows.Add(serviceJournal.Key, serviceJournal.Sum);
            }

            serviceJournalsDataGridView.DataSource = dataTable;
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
    }
}