namespace WinFormsApp10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dateTimePickerDeparture = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonConfirmDeparture = new Button();
            buttonConfirmEnd = new Button();
            labelDeparture = new Label();
            labelEnd = new Label();
            buttonConfirmBooking = new Button();
            listBoxBookedDates = new ListBox();
            labelBookedDates = new Label();
            SuspendLayout();
            // 
            // dateTimePickerDeparture
            // 
            dateTimePickerDeparture.Location = new Point(50, 12);
            dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            dateTimePickerDeparture.Size = new Size(200, 27);
            dateTimePickerDeparture.TabIndex = 0;
            dateTimePickerDeparture.Visible = false;
            dateTimePickerDeparture.ValueChanged += dateTimePickerDeparture_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(50, 176);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 27);
            dateTimePickerEnd.TabIndex = 1;
            dateTimePickerEnd.Visible = false;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // buttonConfirmDeparture
            // 
            buttonConfirmDeparture.Location = new Point(50, 45);
            buttonConfirmDeparture.Name = "buttonConfirmDeparture";
            buttonConfirmDeparture.Size = new Size(200, 42);
            buttonConfirmDeparture.TabIndex = 2;
            buttonConfirmDeparture.Text = "Підтвердити дату відправлення";
            buttonConfirmDeparture.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmEnd
            // 
            buttonConfirmEnd.Location = new Point(50, 209);
            buttonConfirmEnd.Name = "buttonConfirmEnd";
            buttonConfirmEnd.Size = new Size(200, 34);
            buttonConfirmEnd.TabIndex = 3;
            buttonConfirmEnd.Text = "Підтвердити дату виїзду";
            buttonConfirmEnd.UseVisualStyleBackColor = true;
            // 
            // labelDeparture
            // 
            labelDeparture.AutoSize = true;
            labelDeparture.Location = new Point(-3, 110);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new Size(204, 20);
            labelDeparture.TabIndex = 4;
            labelDeparture.Text = "Обрана дата відправлення: ";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(-3, 257);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(151, 20);
            labelEnd.TabIndex = 5;
            labelEnd.Text = "Обрана дата виїзду: ";
            // 
            // buttonConfirmBooking
            // 
            buttonConfirmBooking.Location = new Point(50, 291);
            buttonConfirmBooking.Name = "buttonConfirmBooking";
            buttonConfirmBooking.Size = new Size(200, 33);
            buttonConfirmBooking.TabIndex = 6;
            buttonConfirmBooking.Text = "Підтвердити бронювання";
            buttonConfirmBooking.UseVisualStyleBackColor = true;
            // 
            // listBoxBookedDates
            // 
            listBoxBookedDates.FormattingEnabled = true;
            listBoxBookedDates.Location = new Point(349, 45);
            listBoxBookedDates.Name = "listBoxBookedDates";
            listBoxBookedDates.Size = new Size(150, 284);
            listBoxBookedDates.TabIndex = 7;
            // 
            // labelBookedDates
            // 
            labelBookedDates.AutoSize = true;
            labelBookedDates.Location = new Point(349, 19);
            labelBookedDates.Name = "labelBookedDates";
            labelBookedDates.Size = new Size(141, 20);
            labelBookedDates.TabIndex = 8;
            labelBookedDates.Text = "Забраньовані дати";
            // 
            // Form1
            // 
            ClientSize = new Size(1018, 791);
            Controls.Add(labelBookedDates);
            Controls.Add(listBoxBookedDates);
            Controls.Add(buttonConfirmBooking);
            Controls.Add(labelEnd);
            Controls.Add(labelDeparture);
            Controls.Add(buttonConfirmEnd);
            Controls.Add(buttonConfirmDeparture);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerDeparture);
            Name = "Form1";
            Text = "Вибір дати";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonConfirmDeparture;
        private System.Windows.Forms.Button buttonConfirmEnd;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Button buttonConfirmBooking;
        private ListBox listBoxBookedDates;
        private Label labelBookedDates;
    }
}
