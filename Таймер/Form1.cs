using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace Таймер
{
    public partial class Form1 : Form
    {
        // Константы, необходимые для управления монитором
        private const int SC_MONITORPOWER = 0xF170;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int MONITOR_OFF = 2;
        
        [DllImport("user32.dll")]  // Импортируем функцию SendNotifyMessage из user32.dll
        private static extern int SendNotifyMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
       
        private string Hour = "";
        private string Minutes = "";
        private string Seconds = "";
        private bool timerActive = false; // Флаг, указывающий, активен ли таймер
        private bool sleepMode = false; // Флаг, указывающий, находится ли компьютер в спящем режиме
        [DllImport("powrprof.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);
        private bool soundChangesEnabled = false; // Добавляем переменную для отслеживания состояния функции

        public Form1()
        {
            InitializeComponent();
            timer1.Interval =60000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            PowerModeChangedEventHandler SystemEvents_PowerModeChanged = null;
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged; // Подписываемся на событие изменения режима энергосбережения

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hour = "0";
            Minutes = "0";
            Seconds = "0"; ;

            if (Hour.Length == 1)
            {
                Hour = "0" + Hour;
            }
            if (Minutes.Length == 1)
            {
                Minutes = "0" + Minutes;
            }
            if (Seconds.Length == 1)
            {
                Seconds = "0" + Seconds;
            }

            textBoxHour.Text = Hour;
            textBoxMinutes.Text = Minutes;
            textBoxSeconds.Text = Seconds;
        }

        private void textBoxHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxHour.Text.Length >= 0 && textBoxHour.Text.Length <= 1)
                {
                    return;
                }

            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
        private void textBoxMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxMinutes.Text.Length >= 0 && textBoxMinutes.Text.Length <= 1)
                {
                    return;
                }
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
        private void textBoxSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBoxSeconds.Text.Length >= 0 && textBoxSeconds.Text.Length <= 1)
                {
                    return;
                }

            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Запустить")
            {
                if (textBoxSeconds.Text == "" || Convert.ToInt32(textBoxSeconds.Text) > 59)
                {
                    MessageBox.Show("Не введены секунды!");
                    return;
                }
                if (textBoxMinutes.Text == "" || Convert.ToInt32(textBoxMinutes.Text) > 59)
                {
                    MessageBox.Show("Не введены минуты!");
                    return;
                }
                if (textBoxHour.Text == "")
                {
                    MessageBox.Show("Не введены часы!");
                    return;
                }

                timer1.Stop();
                timer1.Interval = 1000;
                timer1.Start();

                timer1.Enabled = true;
                //buttonStart.BackColor = Color.FromArgb(56, 55, 52);
               // buttonStart.ForeColor = Color.Black; // Добавленный код для изменения цвета текста на черный
                buttonStart.Text = "Стоп";
                textBoxHour.ReadOnly = true;
                textBoxMinutes.ReadOnly = true;
                textBoxSeconds.ReadOnly = true;
                timerActive = true;
            }
            else
            {
                
                timer1.Enabled = false;
                buttonStart.BackColor = Color.Transparent;
                buttonStart.Text = "Запустить";
                textBoxHour.ReadOnly = false;
                textBoxMinutes.ReadOnly = false;
                textBoxSeconds.ReadOnly = false;
                timerActive = false;
            }
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e) //обработчик событий изменения режима энергосбережения 
        {
            switch (e.Mode)
            {
                case PowerModes.Suspend:
                    sleepMode = true;
                    break;
                case PowerModes.Resume:
                    sleepMode = false;
                    break;
            }
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(textBoxHour.Text);
            int minutes = Convert.ToInt32(textBoxMinutes.Text);
            int seconds = Convert.ToInt32(textBoxSeconds.Text);

            if (seconds != 0)
            {
                seconds--;
            }
            else
            {
                if (minutes != 0)
                {
                    minutes--;
                    seconds = 59;
                }
                else
                {
                    if (hours != 0)
                    {
                        hours--;
                        minutes = 59;
                        seconds = 59;
                    }
                    else
                    {
                        if (!sleepMode) // проверяем, не находится ли компьютер в спящем режиме
                        {
                            SetSuspendState(false, true, true); // переводим компьютер в спящий режим
                        }
                    }
                }
            }
            textBoxHour.Text = hours.ToString("00");
            textBoxMinutes.Text = minutes.ToString("00");
            textBoxSeconds.Text = seconds.ToString("00");
        }

        private async void buttonSoundChanges_Click(object sender, EventArgs e)
        {
            // Создаем объект управления аудиоустройствами
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
            // Получаем устройство вывода по умолчанию
            MMDevice defaultDevice = deviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            // Получаем текущее значение громкости в процентах
            int currentVolume = (int)(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
           
            // Расчет задержки изменения громкости, относительно времени
            int hours = Int32.Parse(textBoxHour.Text);
            int minutes = Int32.Parse(textBoxMinutes.Text);
            int totalMinutes = hours * 60 + minutes;
            double delaySeconds = (double)totalMinutes / currentVolume * 60;
            if (soundChangesEnabled)
            {
                // Если функция уже включена, то выключаем ее
                buttonSoundChanges.Text = "Вкл. Снижение звука";
                soundChangesEnabled = false;
                return; // Выходим из функции
            }

            // Включаем функцию и меняем текст кнопки
            buttonSoundChanges.Text = "Выкл. Снижение звука";
            soundChangesEnabled = true;

            for (int i = currentVolume; i >= 0; i--)
            {
                if (!soundChangesEnabled)
                {
                    break; // Если функция была выключена во время выполнения, выходим из цикла
                }
                float newVolume = (float)i / 100;
                defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = newVolume; // установка значения громкости
                await Task.Delay(TimeSpan.FromSeconds(delaySeconds)); // добавляем задержку, чтобы изменения громкости были заметны
            }
        }
       
        private void buttonMonitorShutdown_Click(object sender, EventArgs e)
        {
            // Отправляем сообщение SC_MONITORPOWER с параметром MONITOR_OFF
             SendNotifyMessage((IntPtr)0xFFFF, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
             buttonMonitorShutdown.Enabled = false;
            // Ваш код здесь
            buttonMonitorShutdown.Enabled = true;
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(218, 13, 29);
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Goldenrod;
        }

        private void ButtonWelding_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ButtonWelding_MouseEnter(object sender, EventArgs e)
        {
            ButtonWelding.ForeColor = Color.FromArgb(218, 13, 29);
        }
        private void ButtonWelding_MouseLeave(object sender, EventArgs e)
        {
            ButtonWelding.ForeColor = Color.Goldenrod;
        }
    }
}

