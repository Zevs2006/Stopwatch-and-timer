namespace Stopwatch_and_timer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Чистит все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемые ресурсы должны быть удалены; иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный Windows Form Designer

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            buttonStartStop = new Button();
            buttonReset = new Button();
            labelTime = new Label();
            numericUpDownTime = new NumericUpDown();
            buttonSetTimer = new Button();
            buttonStartTimer = new Button();
            buttonStopTimer = new Button();
            buttonResetTimer = new Button();
            labelTimer = new Label();
            buttonLap = new Button(); // Кнопка для установки флажка
            listBoxLaps = new ListBox(); // Список для отображения флажков

            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += Timer2_Tick;
            // 
            // buttonStartStop
            // 
            buttonStartStop.Location = new Point(14, 14);
            buttonStartStop.Margin = new Padding(4, 3, 4, 3);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(88, 27);
            buttonStartStop.TabIndex = 0;
            buttonStartStop.Text = "Старт";
            buttonStartStop.UseVisualStyleBackColor = true;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(108, 14);
            buttonReset.Margin = new Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(88, 27);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(14, 44);
            labelTime.Margin = new Padding(4, 0, 4, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(49, 15);
            labelTime.TabIndex = 2;
            labelTime.Text = "00:00:00";
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Location = new Point(14, 74);
            numericUpDownTime.Margin = new Padding(4, 3, 4, 3);
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new Size(140, 23);
            numericUpDownTime.Minimum = 0; // Устанавливаем минимальное значение
            numericUpDownTime.Maximum = 100000; // Увеличиваем максимальное значение
            numericUpDownTime.DecimalPlaces = 0; // Убираем дробные числа
            numericUpDownTime.Increment = 1; // Шаг увеличения на 1
            // 
            // buttonSetTimer
            // 
            buttonSetTimer.Location = new Point(161, 72);
            buttonSetTimer.Margin = new Padding(4, 3, 4, 3);
            buttonSetTimer.Name = "buttonSetTimer";
            buttonSetTimer.Size = new Size(88, 27);
            buttonSetTimer.TabIndex = 4;
            buttonSetTimer.Text = "Установить";
            buttonSetTimer.UseVisualStyleBackColor = true;
            buttonSetTimer.Click += buttonSetTimer_Click;
            // 
            // buttonStartTimer
            // 
            buttonStartTimer.Location = new Point(14, 104);
            buttonStartTimer.Margin = new Padding(4, 3, 4, 3);
            buttonStartTimer.Name = "buttonStartTimer";
            buttonStartTimer.Size = new Size(88, 27);
            buttonStartTimer.TabIndex = 5;
            buttonStartTimer.Text = "Запустить";
            buttonStartTimer.UseVisualStyleBackColor = true;
            buttonStartTimer.Click += buttonStartTimer_Click;
            // 
            // buttonStopTimer
            // 
            buttonStopTimer.Location = new Point(108, 104);
            buttonStopTimer.Margin = new Padding(4, 3, 4, 3);
            buttonStopTimer.Name = "buttonStopTimer";
            buttonStopTimer.Size = new Size(88, 27);
            buttonStopTimer.TabIndex = 6;
            buttonStopTimer.Text = "Остановить";
            buttonStopTimer.UseVisualStyleBackColor = true;
            buttonStopTimer.Click += buttonStopTimer_Click;
            // 
            // buttonResetTimer
            // 
            buttonResetTimer.Location = new Point(203, 104);
            buttonResetTimer.Margin = new Padding(4, 3, 4, 3);
            buttonResetTimer.Name = "buttonResetTimer";
            buttonResetTimer.Size = new Size(88, 27);
            buttonResetTimer.TabIndex = 7;
            buttonResetTimer.Text = "Сброс";
            buttonResetTimer.UseVisualStyleBackColor = true;
            buttonResetTimer.Click += buttonResetTimer_Click;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(14, 134);
            labelTimer.Margin = new Padding(4, 0, 4, 0);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(49, 15);
            labelTimer.TabIndex = 8;
            labelTimer.Text = "00:00:00";
            // 
            // buttonLap
            // 
            buttonLap.Location = new Point(203, 14);
            buttonLap.Margin = new Padding(4, 3, 4, 3);
            buttonLap.Name = "buttonLap";
            buttonLap.Size = new Size(88, 27);
            buttonLap.TabIndex = 9;
            buttonLap.Text = "Флажок";
            buttonLap.UseVisualStyleBackColor = true;
            buttonLap.Click += buttonLap_Click; // Обработчик события
            // 
            // listBoxLaps
            // 
            listBoxLaps.Location = new Point(14, 160);
            listBoxLaps.Margin = new Padding(4, 3, 4, 3);
            listBoxLaps.Name = "listBoxLaps";
            listBoxLaps.Size = new Size(277, 100);
            listBoxLaps.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 273); // Обновлено для отображения списка флажков
            Controls.Add(listBoxLaps); // Добавляем список флажков на форму
            Controls.Add(buttonLap); // Добавляем кнопку флажка на форму
            Controls.Add(labelTimer);
            Controls.Add(buttonResetTimer);
            Controls.Add(buttonStopTimer);
            Controls.Add(buttonStartTimer);
            Controls.Add(buttonSetTimer);
            Controls.Add(numericUpDownTime);
            Controls.Add(labelTime);
            Controls.Add(buttonReset);
            Controls.Add(buttonStartStop);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Секундомер и Таймер";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Button buttonSetTimer;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Button buttonStopTimer;
        private System.Windows.Forms.Button buttonResetTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonLap; // Новый элемент
        private System.Windows.Forms.ListBox listBoxLaps; // Новый элемент
    }
}
