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
            this.shortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateCreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dateEndLabel = new System.Windows.Forms.Label();
            this.dateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.workItemsLabel = new System.Windows.Forms.Label();
            this.workItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workItemsDataGridView)).BeginInit();
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
            // shortDescriptionTextBox
            // 
            this.shortDescriptionTextBox.Location = new System.Drawing.Point(12, 28);
            this.shortDescriptionTextBox.Name = "shortDescriptionTextBox";
            this.shortDescriptionTextBox.Size = new System.Drawing.Size(529, 20);
            this.shortDescriptionTextBox.TabIndex = 3;
            // 
            // dateCreateDateTimePicker
            // 
            this.dateCreateDateTimePicker.CustomFormat = "dd MMM yyyy HH:mm";
            this.dateCreateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCreateDateTimePicker.Location = new System.Drawing.Point(115, 54);
            this.dateCreateDateTimePicker.Name = "dateCreateDateTimePicker";
            this.dateCreateDateTimePicker.Size = new System.Drawing.Size(166, 20);
            this.dateCreateDateTimePicker.TabIndex = 4;
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
            // workItemsDataGridView
            // 
            this.workItemsDataGridView.AllowUserToAddRows = false;
            this.workItemsDataGridView.AllowUserToDeleteRows = false;
            this.workItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workItemsDataGridView.Location = new System.Drawing.Point(287, 80);
            this.workItemsDataGridView.Name = "workItemsDataGridView";
            this.workItemsDataGridView.ReadOnly = true;
            this.workItemsDataGridView.Size = new System.Drawing.Size(254, 169);
            this.workItemsDataGridView.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(336, 53);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceButton.TabIndex = 14;
            this.addServiceButton.Text = "Добавить";
            this.addServiceButton.UseVisualStyleBackColor = true;
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
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 290);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workItemsDataGridView);
            this.Controls.Add(this.workItemsLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.dateEndDateTimePicker);
            this.Controls.Add(this.dateEndLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.dateCreateDateTimePicker);
            this.Controls.Add(this.shortDescriptionTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateCreateLabel);
            this.Name = "EditOrderForm";
            this.Text = "Редактирование заказа";
            ((System.ComponentModel.ISupportInitialize)(this.workItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateCreateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox shortDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateCreateDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label dateEndLabel;
        private System.Windows.Forms.DateTimePicker dateEndDateTimePicker;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label workItemsLabel;
        private System.Windows.Forms.DataGridView workItemsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label descriptionLabel;
    }
}