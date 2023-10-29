using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlarmClockApp.Models;

namespace AlarmClockApp.Forms
{
    public partial class AlarmClockAddingForm : Form
    {
        Settings settings = new Settings();
        public AlarmClockAddingForm()
        {
            InitializeComponent();
        }

        private void AlarmClockAddingForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            
            Settings.AddAlarmClockTime(dateTimePicker1.Value.TimeOfDay.ToString(@"hh\:mm\:ss"), messageTextBox.Text);
        }
        
    }
}
