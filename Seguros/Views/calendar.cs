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
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
            data.MasterList = new SimpleScheduleAppointmentList();
            data.FileName = "default.schedule";
            this.scheduleControl2.ScheduleType = ScheduleViewType.Month;
            this.scheduleControl2.DataSource = data;
        }
    }
}
