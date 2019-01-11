namespace Service
{
    partial class EditOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateCreateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dateEndLabel = new System.Windows.Forms.Label();
            this.dateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.workItemsLabel = new System.Windows.Forms.Label();
            this.serviceJournalsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.shortDescriptionLabel = new System.Windows.Forms.Label();
            this.dateStartValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceJournalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateCreateLabel
            // 
            this.dateCreateLabel.AutoSize = true;
            this.dateCreateLabel.Location = new System.Drawing.Point(9, 58);
            this.dateCreateLabel.Name = "dateCreateLabel";
            this.dateCreateLabel.Size = new System.Drawing.Size(72, 13);
            this.dateCreateLabel.TabIndex = 1;
            this.dateCreateLabel.Text = "Дата заявки";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 86);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(115, 80);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(166, 21);
            this.statusComboBox.TabIndex = 5;
            // 
            // dateEndLabel
            // 
            this.dateEndLabel.AutoSize = true;
            this.dateEndLabel.Location = new System.Drawing.Point(9, 113);
            this.dateEndLabel.Name = "dateEndLabel";
            this.dateEndLabel.Size = new System.Drawing.Size(98, 13);
            this.dateEndLabel.TabIndex = 6;
            this.dateEndLabel.Text = "Дата завершения";
            // 
            // dateEndDateTimePicker
            // 
            this.dateEndDateTimePicker.CustomFormat = " ";
            this.dateEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEndDateTimePicker.Location = new System.Drawing.Point(115, 107);
            this.dateEndDateTimePicker.Name = "dateEndDateTimePicker";
            this.dateEndDateTimePicker.Size = new System.Drawing.Size(166, 20);
            this.dateEndDateTimePicker.TabIndex = 7;
            this.dateEndDateTimePicker.ValueChanged += new System.EventHandler(this.dateEndDateTimePicker_ValueChanged);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(12, 152);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(269, 126);
            this.descriptionRichTextBox.TabIndex = 8;
            this.descriptionRichTextBox.Text = "";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(12, 12);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(44, 13);
            this.orderLabel.TabIndex = 9;
            this.orderLabel.Text = "Заявка";
            // 
            // workItemsLabel
            // 
            this.workItemsLabel.AutoSize = true;
            this.workItemsLabel.Location = new System.Drawing.Point(287, 58);
            this.workItemsLabel.Name = "workItemsLabel";
            this.workItemsLabel.Size = new System.Drawing.Size(43, 13);
            this.workItemsLabel.TabIndex = 10;
            this.workItemsLabel.Text = "Услуги";
            // 
            // serviceJournalsDataGridView
            // 
            this.serviceJournalsDataGridView.AllowUserToAddRows = false;
            this.serviceJournalsDataGridView.AllowUserToDeleteRows = false;
            this.serviceJournalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceJournalsDataGridView.Location = new System.Drawing.Point(287, 80);
            this.serviceJournalsDataGridView.Name = "serviceJournalsDataGridView";
            this.serviceJournalsDataGridView.ReadOnly = true;
            this.serviceJournalsDataGridView.RowHeadersVisible = false;
            this.serviceJournalsDataGridView.Size = new System.Drawing.Size(254, 169);
            this.serviceJournalsDataGridView.TabIndex = 11;
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(385, 255);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(75, 23);
            this.saveOrderButton.TabIndex = 12;
            this.saveOrderButton.Text = "Сохранить";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(466, 255);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(336, 53);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceButton.TabIndex = 14;
            this.addServiceButton.Text = "Добавить";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 135);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Описание";
            // 
            // shortDescriptionLabel
            // 
            this.shortDescriptionLabel.AutoSize = true;
            this.shortDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortDescriptionLabel.Location = new System.Drawing.Point(11, 29);
            this.shortDescriptionLabel.Name = "shortDescriptionLabel";
            this.shortDescriptionLabel.Size = new System.Drawing.Size(13, 17);
            this.shortDescriptionLabel.TabIndex = 16;
            this.shortDescriptionLabel.Text = "-";
            // 
            // dateStartValueLabel
            // 
            this.dateStartValueLabel.AutoSize = true;
            this.dateStartValueLabel.Location = new System.Drawing.Point(115, 57);
            this.dateStartValueLabel.Name = "dateStartValueLabel";
            this.dateStartValueLabel.Size = new System.Drawing.Size(10, 13);
            this.dateStartValueLabel.TabIndex = 17;
            this.dateStartValueLabel.Text = "-";
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 290);
            this.Controls.Add(this.dateStartValueLabel);
            this.Controls.Add(this.shortDescriptionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.serviceJournalsDataGridView);
            this.Controls.Add(this.workItemsLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.dateEndDateTimePicker);
            this.Controls.Add(this.dateEndLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateCreateLabel);
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            ((System.ComponentModel.ISupportInitialize)(this.serviceJournalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateCreateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label dateEndLabel;
        private System.Windows.Forms.DateTimePicker dateEndDateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label workItemsLabel;
        private System.Windows.Forms.DataGridView serviceJournalsDataGridView;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label shortDescriptionLabel;
        private System.Windows.Forms.Label dateStartValueLabel;
    }
}