using System;
using System.Windows.Forms;

namespace Stopwatch_and_timer
{
    public partial class Form1 : Form
    {
        private TimeSpan elapsedTime; // ��� �����������
        private DateTime endTime; // ��� �������
        private bool isRunning; // ������ �����������

        public Form1()
        {
            InitializeComponent();
            elapsedTime = TimeSpan.Zero;
            isRunning = false;
            labelTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            labelTimer.Text = "00:00:00"; // ���������� ������ �� �������
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                // ���������� ����������
                timer1.Stop();
                buttonStartStop.Text = "�����";
            }
            else
            {
                // ��������� ����������
                timer1.Start();
                buttonStartStop.Text = "����������";
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
            // �������� ����������
            timer1.Stop();
            elapsedTime = TimeSpan.Zero;
            labelTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            buttonStartStop.Text = "�����";
            isRunning = false;
        }

        private void buttonSetTimer_Click(object sender, EventArgs e)
        {
            // ���������� ������ �� ��������� ���������� ������
            int seconds = (int)numericUpDownTime.Value;
            endTime = DateTime.Now.AddSeconds(seconds);
            labelTimer.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            // ��������� ������
            timer2.Start();
            timer2.Tick += Timer2_Tick; // �������� ����������� ������� ��� �������
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            // ���������� ������
            timer2.Stop();
        }

        private void buttonResetTimer_Click(object sender, EventArgs e)
        {
            // �������� ������
            timer2.Stop();
            labelTimer.Text = "00:00:00";
            numericUpDownTime.Value = 0;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // ��������, �� ����� �� ������
            if (DateTime.Now >= endTime)
            {
                timer2.Stop();
                MessageBox.Show("������ ����!", "�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelTimer.Text = "00:00:00"; // ����� �������
            }
            else
            {
                TimeSpan remainingTime = endTime - DateTime.Now;
                labelTimer.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
        }

        
    }
}
