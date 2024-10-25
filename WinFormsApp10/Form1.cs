using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        // ������ ������������� ���
        private List<DateTime> bookedDates = new List<DateTime>
        {
            new DateTime(2024, 10, 28), // ������� ������������ ����
            new DateTime(2024, 10, 30), // �� ���� �������
            new DateTime(2024, 11, 18)  // ���� ������������ ����
        };

        public Form1()
        {
            InitializeComponent();

            // ϳ��������� ��������� ����
            this.buttonConfirmDeparture.Click += new EventHandler(this.buttonConfirmDeparture_Click);
            this.buttonConfirmEnd.Click += new EventHandler(this.buttonConfirmEnd_Click);
            this.buttonConfirmBooking.Click += new EventHandler(this.buttonConfirmBooking_Click);

            // ����������� ����������� ���� � ListBox
            LoadBookedDates();
        }

        private void LoadBookedDates()
        {
            // �������� ListBox ����� �������������
            listBoxBookedDates.Items.Clear();

            // ������ ����������� ���� �� ListBox
            foreach (var date in bookedDates)
            {
                listBoxBookedDates.Items.Add(date.ToShortDateString());
            }
        }

        private void buttonConfirmDeparture_Click(object sender, EventArgs e)
        {
            // ³��������� �������� ��� ������ ���� �����������
            dateTimePickerDeparture.Visible = true;
        }

        private void buttonConfirmEnd_Click(object sender, EventArgs e)
        {
            // ³��������� �������� ��� ������ ���� ���������
            dateTimePickerEnd.Visible = true;
        }

        private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDeparture.Value.Date;

            // ��������� ������ ������ �� ������� ��� ����� ���� �����������
            labelDeparture.Text = "������ ���� �����������: " + selectedDate.ToShortDateString();

            if (bookedDates.Contains(selectedDate))
            {
                labelDeparture.ForeColor = System.Drawing.Color.Red; // �������� ���� ��� ������������ ����
            }
            else
            {
                labelDeparture.ForeColor = System.Drawing.Color.Black; // ������ ���� ��� �������� ����
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerEnd.Value.Date;

            // ��������� ������ ������ �����
            labelEnd.Text = "������ ���� �����: " + selectedDate.ToShortDateString();
            labelEnd.ForeColor = System.Drawing.Color.Black; // ������ ���� �� �������������
        }

        private void buttonConfirmBooking_Click(object sender, EventArgs e)
        {
            DateTime departureDate = dateTimePickerDeparture.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            bool isDepartureBooked = bookedDates.Contains(departureDate);
            bool isEndBooked = bookedDates.Contains(endDate);

            // �������� �������� ������������� ���
            if (isDepartureBooked || isEndBooked)
            {
                // ���� ���� � ���� � ��� �������
                if (isDepartureBooked)
                {
                    labelDeparture.ForeColor = System.Drawing.Color.Red; // �������� ���� ��� ������� ����
                }
                if (isEndBooked)
                {
                    labelEnd.ForeColor = System.Drawing.Color.Red; // �������� ���� ��� ������� ����
                }
                MessageBox.Show("���� � ������� ��� ��� ������������. ���� �����, ������ ���� ����.", "������� ����������");
            }
            else
            {
                // ������ ���� ������������ ���� �� ������
                bookedDates.Add(departureDate);

                // ������� ����������� ��� ������ ����������
                MessageBox.Show("�����, �� ����������� ������, ������ ��������� ���.", "ϳ����������� ����������");

                // ������ ���� ������ ������ �� �������
                labelDeparture.ForeColor = System.Drawing.Color.Green;
                labelEnd.ForeColor = System.Drawing.Color.Green;

                // ������� ������ ������������� ���
                LoadBookedDates();
            }
        }
    }
}
