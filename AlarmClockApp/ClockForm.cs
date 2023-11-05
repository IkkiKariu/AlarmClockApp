using AlarmClockApp.Forms;
using AlarmClockApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockApp
{
    public partial class ClockForm : Form
    {
        ClockModel _model = new ClockModel();

        public Settings settings = new Settings();

        public ClockForm()
        {
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

            Settings.AlarmClockQueueDisplayig();

            settingsForm.ShowDialog();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DisplayLabel.Text = _model.CurrentTime.ToString(@"hh\:mm\:ss");

            if (Settings.AlarmTimes != null)
            {
                foreach (var alarmTime in Settings.AlarmTimes)
                {
                    foreach (var time in alarmTime.Value)
                    {
                        if (DisplayLabel.Text == time.Value) 
                        {
                            settings.InitiateAlarm(alarmTime.Key);
                            return;
                        }
                    }
                }
            }
            
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void StopWatch_Click(object sender, EventArgs e)
        {
            this.StopWatchForm.ShowDialog();
        }

        private void StopWatchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
