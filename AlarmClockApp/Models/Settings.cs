using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmClockApp.Forms;


namespace AlarmClockApp.Models
{
    public class Settings
    {
        public static Dictionary<int, Dictionary<string, string>> AlarmTimes = new Dictionary<int, Dictionary<string, string>>();

        private static int nextID = 1;

        public Settings()
        {
            //AlarmTimes = new Dictionary<int, Dictionary<string, string>>();
        }

        public static bool AddAlarmClockTime(string formatedTime, string message)
        {
            if (AlarmTimes != null)
            {
                foreach (Dictionary<string, string> time in AlarmTimes.Values)
                {
                    if (time.ContainsKey(formatedTime))
                    {
                        return false;
                    }
                }

            }

            AlarmTimes.Add(nextID, new Dictionary<string, string> () { { "time", formatedTime }, { "message", message } });

            nextID++;

            AlarmClockQueueDisplayig();

            return true;
        }

        public void InitiateAlarm(int alarmTimeID)
        {
            new AlarmForm(alarmTimeID).ShowDialog();

            AlarmTimes.Remove(alarmTimeID);

            AlarmClockQueueDisplayig();
        }

        public static void AlarmClockQueueDisplayig()
        {
            ClockForm.settingsForm.alarmClockQueueLabel.Text = "";

            foreach (Dictionary<string, string> timeDict in AlarmTimes.Values)
            {
                ClockForm.settingsForm.alarmClockQueueLabel.Text += $"Time: {timeDict["time"]}    Message: {timeDict["message"]}\n";
            }
        }
    }
}
