using System.Windows.Forms;

namespace AlarmClockApp.Forms
{
    partial class SettingsForm
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
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.AddAlarmClockButton = new System.Windows.Forms.Button();
            this.alarmClockQueueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(155, 260);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // AddAlarmClockButton
            // 
            this.AddAlarmClockButton.Location = new System.Drawing.Point(12, 12);
            this.AddAlarmClockButton.Name = "AddAlarmClockButton";
            this.AddAlarmClockButton.Size = new System.Drawing.Size(129, 38);
            this.AddAlarmClockButton.TabIndex = 3;
            this.AddAlarmClockButton.Text = "Add alarm clock";
            this.AddAlarmClockButton.UseVisualStyleBackColor = true;
            this.AddAlarmClockButton.Click += new System.EventHandler(this.AddAlarmClockButton_Click);
            // 
            // alarmClockQueueLabel
            // 
            this.alarmClockQueueLabel.AutoSize = true;
            this.alarmClockQueueLabel.Location = new System.Drawing.Point(12, 83);
            this.alarmClockQueueLabel.Name = "alarmClockQueueLabel";
            this.alarmClockQueueLabel.Size = new System.Drawing.Size(0, 13);
            this.alarmClockQueueLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alarm clock queue:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarmClockQueueLabel);
            this.Controls.Add(this.AddAlarmClockButton);
            this.Controls.Add(this.okButton);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button okButton;
        private Button AddAlarmClockButton;
        public Label alarmClockQueueLabel;
        private Label label1;
    }
}