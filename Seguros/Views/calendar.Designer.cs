namespace Seguros.Views
{
    partial class calendar
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
            this.scheduleControl2 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.SuspendLayout();
            // 
            // scheduleControl2
            // 
            this.scheduleControl2.Appearance.WeekHeaderFormat = "MMMM dd";
            this.scheduleControl2.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy";
            this.scheduleControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.scheduleControl2.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl2.DataSource = null;
            this.scheduleControl2.ISO8601CalenderFormat = false;
            this.scheduleControl2.Location = new System.Drawing.Point(82, 12);
            this.scheduleControl2.Name = "scheduleControl2";
            this.scheduleControl2.Size = new System.Drawing.Size(737, 499);
            this.scheduleControl2.TabIndex = 0;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 923);
            this.Controls.Add(this.scheduleControl2);
            this.Name = "calendar";
            this.Text = "calendar";
            this.Load += new System.EventHandler(this.calendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl2;
    }
}