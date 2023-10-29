using AlarmClockApp.Models;


namespace AlarmClockApp.Forms
{
    partial class AlarmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int currentAlarmTimeID)
        {
            this.alarmMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alarmMessageLabel
            // 
            this.alarmMessageLabel.AutoSize = true;
            this.alarmMessageLabel.Location = new System.Drawing.Point(121, 111);
            this.alarmMessageLabel.Name = "alarmMessageLabel";
            this.alarmMessageLabel.Size = new System.Drawing.Size(35, 13);
            this.alarmMessageLabel.TabIndex = 0;
            this.alarmMessageLabel.Text = "label1";
            this.alarmMessageLabel.Text = $"{currentAlarmTimeID} : { Settings.AlarmTimes[currentAlarmTimeID]["message"]}";
            // 
            // AlarmForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.alarmMessageLabel);
            this.Name = "AlarmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label alarmMessageLabel;
    }
}