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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void AddAlarmClockButton_Click(object sender, EventArgs e)
        {
            new AlarmClockAddingForm().ShowDialog();
        }
    }
}
