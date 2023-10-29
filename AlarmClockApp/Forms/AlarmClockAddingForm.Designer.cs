namespace AlarmClockApp.Forms
{
    partial class AlarmClockAddingForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(96, 58);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 20);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "default";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Time";
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 61);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Message";
            // 
            // setTimeButton
            // 
            this.setTimeButton.Location = new System.Drawing.Point(116, 140);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.Size = new System.Drawing.Size(75, 23);
            this.setTimeButton.TabIndex = 4;
            this.setTimeButton.Text = "Set";
            this.setTimeButton.UseVisualStyleBackColor = true;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            this.setTimeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // AlarmClockAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 209);
            this.Controls.Add(this.setTimeButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AlarmClockAddingForm";
            this.Text = "AlarmClockAddingForm";
            this.Load += new System.EventHandler(this.AlarmClockAddingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button setTimeButton;
    }
}