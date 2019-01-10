namespace Service
{
    partial class AddServiceJournalForm
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
            this.serviceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minLabel = new System.Windows.Forms.Label();
            this.addServiceJournal = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(14, 20);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(43, 13);
            this.serviceLabel.TabIndex = 0;
            this.serviceLabel.Text = "Услуга";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(14, 54);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(107, 13);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Затраченное время";
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(63, 17);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(165, 21);
            this.serviceComboBox.TabIndex = 2;
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.Location = new System.Drawing.Point(128, 54);
            this.timeNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.timeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.timeNumericUpDown.TabIndex = 3;
            this.timeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(198, 56);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 13);
            this.minLabel.TabIndex = 4;
            this.minLabel.Text = "мин.";
            // 
            // addServiceJournal
            // 
            this.addServiceJournal.Location = new System.Drawing.Point(72, 97);
            this.addServiceJournal.Name = "addServiceJournal";
            this.addServiceJournal.Size = new System.Drawing.Size(75, 23);
            this.addServiceJournal.TabIndex = 5;
            this.addServiceJournal.Text = "Добавить";
            this.addServiceJournal.UseVisualStyleBackColor = true;
            this.addServiceJournal.Click += new System.EventHandler(this.addServiceJournal_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(153, 97);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddServiceJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 130);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addServiceJournal);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.timeNumericUpDown);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.serviceLabel);
            this.Name = "AddServiceJournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление услуги";
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Button addServiceJournal;
        private System.Windows.Forms.Button cancelButton;
    }
}