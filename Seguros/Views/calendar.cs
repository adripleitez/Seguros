using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using GridScheduleSample;


namespace Seguros.Views
{
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
            ScheduleControl scheduleControl1 = new ScheduleControl();
            scheduleControl1.Location = new Point(82, 12);
            scheduleControl1.Size = new Size(350, 360);
            this.Controls.Add(scheduleControl1);
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
            data.MasterList = new SimpleScheduleAppointmentList();
            data.FileName = "default.schedule";
            this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
            this.scheduleControl1.DataSource = data;
        }
    }
}
