using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        // Список заброньованих дат
        private List<DateTime> bookedDates = new List<DateTime>
        {
            new DateTime(2024, 10, 28), // Приклад заброньованої дати
            new DateTime(2024, 10, 30), // Ще одна приклад
            new DateTime(2024, 11, 18)  // Інша заброньована дата
        };

        public Form1()
        {
            InitializeComponent();

            // Підключення обробників подій
            this.buttonConfirmDeparture.Click += new EventHandler(this.buttonConfirmDeparture_Click);
            this.buttonConfirmEnd.Click += new EventHandler(this.buttonConfirmEnd_Click);
            this.buttonConfirmBooking.Click += new EventHandler(this.buttonConfirmBooking_Click);

            // Завантажити заброньовані дати в ListBox
            LoadBookedDates();
        }

        private void LoadBookedDates()
        {
            // Очистити ListBox перед завантаженням
            listBoxBookedDates.Items.Clear();

            // Додати заброньовані дати до ListBox
            foreach (var date in bookedDates)
            {
                listBoxBookedDates.Items.Add(date.ToShortDateString());
            }
        }

        private void buttonConfirmDeparture_Click(object sender, EventArgs e)
        {
            // Відобразити календар для вибору дати відправлення
            dateTimePickerDeparture.Visible = true;
        }

        private void buttonConfirmEnd_Click(object sender, EventArgs e)
        {
            // Відобразити календар для вибору дати закінчення
            dateTimePickerEnd.Visible = true;
        }

        private void dateTimePickerDeparture_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDeparture.Value.Date;

            // Оновлення тексту лейбла та кольору при виборі дати відправлення
            labelDeparture.Text = "Обрана дата відправлення: " + selectedDate.ToShortDateString();

            if (bookedDates.Contains(selectedDate))
            {
                labelDeparture.ForeColor = System.Drawing.Color.Red; // Червоний колір для заброньованої дати
            }
            else
            {
                labelDeparture.ForeColor = System.Drawing.Color.Black; // Чорний колір для доступної дати
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerEnd.Value.Date;

            // Оновлення тексту лейбла виїзду
            labelEnd.Text = "Обрана дата виїзду: " + selectedDate.ToShortDateString();
            labelEnd.ForeColor = System.Drawing.Color.Black; // Чорний колір за замовчуванням
        }

        private void buttonConfirmBooking_Click(object sender, EventArgs e)
        {
            DateTime departureDate = dateTimePickerDeparture.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            bool isDepartureBooked = bookedDates.Contains(departureDate);
            bool isEndBooked = bookedDates.Contains(endDate);

            // Перевірка наявності заброньованих дат
            if (isDepartureBooked || isEndBooked)
            {
                // Якщо хоча б одна з дат зайнята
                if (isDepartureBooked)
                {
                    labelDeparture.ForeColor = System.Drawing.Color.Red; // Червоний колір для зайнятої дати
                }
                if (isEndBooked)
                {
                    labelEnd.ForeColor = System.Drawing.Color.Red; // Червоний колір для зайнятої дати
                }
                MessageBox.Show("Одна з обраних дат вже заброньована. Будь ласка, оберіть іншу дату.", "Помилка бронювання");
            }
            else
            {
                // Додати нову заброньовану дату до списку
                bookedDates.Add(departureDate);

                // Вивести повідомлення про успішне бронювання
                MessageBox.Show("Добре, ви забронювали поїздку, будемо очікувати вас.", "Підтвердження бронювання");

                // Змінити колір тексту лейблів на зелений
                labelDeparture.ForeColor = System.Drawing.Color.Green;
                labelEnd.ForeColor = System.Drawing.Color.Green;

                // Оновити список заброньованих дат
                LoadBookedDates();
            }
        }
    }
}
