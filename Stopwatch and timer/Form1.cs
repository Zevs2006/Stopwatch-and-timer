using System;
using System.Windows.Forms;

namespace Stopwatch_and_timer
{
    public partial class Form1 : Form
    {
        private TimeSpan timeSpan;
        private bool isRunning;

        public Form1()
        {
            InitializeComponent();
            timeSpan = TimeSpan.Zero;
            isRunning = false;
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                buttonStartStop.Text = "Старт";
            }
            else
            {
                timer1.Start();
                buttonStartStop.Text = "Стоп";
            }
            isRunning = !isRunning;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSpan = timeSpan.Add(TimeSpan.FromSeconds(1));
            labelTime.Text = timeSpan.ToString(@"d\:hh\:mm\:ss"); // Вывод с учетом дней
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeSpan = TimeSpan.Zero;
            labelTime.Text = "00:00:00";
            isRunning = false;
            buttonStartStop.Text = "Старт";
        }

        private void buttonSetTimer_Click(object sender, EventArgs e)
        {
            // Получаем общее время в минутах, и преобразуем в TimeSpan
            timeSpan = TimeSpan.FromSeconds((double)numericUpDownTime.Value);
            labelTimer.Text = timeSpan.ToString(@"d\:hh\:mm\:ss"); // Вывод с учетом дней
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void buttonResetTimer_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timeSpan = TimeSpan.Zero;
            labelTimer.Text = "00:00:00";
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (timeSpan.TotalSeconds > 0)
            {
                timeSpan = timeSpan.Add(TimeSpan.FromSeconds(-1));
                labelTimer.Text = timeSpan.ToString(@"d\:hh\:mm\:ss"); // Вывод с учетом дней
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Время вышло!");
            }
        }

        private void buttonLap_Click(object sender, EventArgs e)
        {
            // Добавляем текущее время флажка в список
            listBoxLaps.Items.Add(labelTime.Text);
        }
    }
}
