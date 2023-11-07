using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmClockApp.Models;

namespace AlarmClockApp.Forms
{
    public partial class StopWatchForm : Form
    {
        StopWatch stopWatchModel = new StopWatch();
        public StopWatchForm()
        {
            InitializeComponent();
        }

        private void stopWatchTimer_Tick(object sender, EventArgs e)
        {
            this.stopWatchModel.ElapsedTime = DateTime.Now - this.stopWatchModel.StartTime + this.stopWatchModel.TotalElapsedTime;

            DisplayLabel.Text = this.stopWatchModel.ElapsedTime.ToString(@"hh\:mm\:ss\:ff");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!stopWatchTimer.Enabled)
            {
                this.stopWatchModel.StartTime = DateTime.Now;
                stopWatchTimer.Start();
            }
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (stopWatchTimer.Enabled)
            {
                stopWatchTimer.Stop();
                this.stopWatchModel.TotalElapsedTime = this.stopWatchModel.ElapsedTime;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopWatchTimer.Stop();
            this.stopWatchModel.ElapsedTime = TimeSpan.Zero;
            this.stopWatchModel.TotalElapsedTime = TimeSpan.Zero;
            DisplayLabel.Text = "00:00:00:00";
        }
    }
}
