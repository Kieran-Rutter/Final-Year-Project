using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    public partial class TaskUserControl : UserControl
    {
        public static int seconds;
        public static int minutes;
        public static int hours;
        public TaskUserControl()
        {
            InitializeComponent();
        }

        public void taskDisplay()
        {
            task_lbl.Text = expandedDay.task[1];
            hours_lbl.Text = "H: " + expandedDay.task[4];
            mins_lbl.Text = "M: " + expandedDay.task[3];
            seconds_lbl.Text = "S: " +expandedDay.task[2];
        }

        private void TaskUserControl_Load(object sender, EventArgs e)
        {
            getIni();
        }

        private void TaskUserControl_Click(object sender, EventArgs e)
        {
            //Calculates how long the counter needs to be
            seconds = Int32.Parse(expandedDay.task[2]);
            minutes = Int32.Parse(expandedDay.task[3]);
            hours = Int32.Parse(expandedDay.task[4]);

            minutes += (hours * 60);
            seconds += (minutes * 60);


            TimerExpanded timerExpanded = new TimerExpanded();
            timerExpanded.Show();
        }


        private void getIni()
        {
            ColourControl.UpdateControlBackColour(this);

            //Loads the colour control class for each controll in the form.
            foreach (Control c in this.Controls)
            {
                ColourControl.UpdateColorControls(c);
            }
        }
        public static String backColour;
        public static String textColour;

        private void TaskUserControl_Resize(object sender, EventArgs e)
        {
        }
    }
}
