using System;
using System.Windows.Forms;

namespace Stopwatch_and_timer
{
    public partial class Form1 : Form
    {
        private TimeSpan elapsedTime; // Для секундомера
        private DateTime endTime; // Для таймера
        private bool isRunning; // Статус секундомера

        public Form1()
        {
            InitializeComponent();
            elapsedTime = TimeSpan.Zero;
            isRunning = false;
            labelTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            labelTimer.Text = "00:00:00"; // Изначально таймер не запущен
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                // Остановить секундомер
                timer1.Stop();
                buttonStartStop.Text = "Старт";
            }
            else
            {
                // Запустить секундомер
                timer1.Start();
                buttonStartStop.Text = "Остановить";
            }
            isRunning = !isRunning;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            labelTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Сбросить секундомер
            timer1.Stop();
            elapsedTime = TimeSpan.Zero;
            labelTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            buttonStartStop.Text = "Старт";
            isRunning = false;
        }

        private void buttonSetTimer_Click(object sender, EventArgs e)
        {
            // Установить таймер на выбранное количество секунд
            int seconds = (int)numericUpDownTime.Value;
            endTime = DateTime.Now.AddSeconds(seconds);
            labelTimer.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            // Запустить таймер
            timer2.Start();
            timer2.Tick += Timer2_Tick; // Привязка обработчика событий для таймера
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            // Остановить таймер
            timer2.Stop();
        }

        private void buttonResetTimer_Click(object sender, EventArgs e)
        {
            // Сбросить таймер
            timer2.Stop();
            labelTimer.Text = "00:00:00";
            numericUpDownTime.Value = 0;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Проверка, не истек ли таймер
            if (DateTime.Now >= endTime)
            {
                timer2.Stop();
                MessageBox.Show("Таймер истёк!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelTimer.Text = "00:00:00"; // Сброс таймера
            }
            else
            {
                TimeSpan remainingTime = endTime - DateTime.Now;
                labelTimer.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
        }

        
    }
}
