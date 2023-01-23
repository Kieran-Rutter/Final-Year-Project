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
            hours_lbl.Text = expandedDay.task[4];
            mins_lbl.Text = expandedDay.task[3];
            seconds_lbl.Text = expandedDay.task[2];
        }

        private void TaskUserControl_Load(object sender, EventArgs e)
        {
            getIni();
        }

        private void TaskUserControl_Click(object sender, EventArgs e)
        {
            //Calculates how long the counter needs to be
            seconds = Int32.Parse(seconds_lbl.Text);
            minutes = Int32.Parse(mins_lbl.Text);
            hours = Int32.Parse(hours_lbl.Text);

            minutes += (hours * 60);
            seconds += (minutes * 60);


            TimerExpanded timerExpanded = new TimerExpanded();
            timerExpanded.Show();
        }


        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            backColour = Form1.buttonBackColour;
            textColour = Form1.textColour;

            //User control colours
            this.BackColor = ColorTranslator.FromHtml(backColour);
            this.task_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.hours_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.mins_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.seconds_lbl.ForeColor = ColorTranslator.FromHtml(textColour);

        }
        public static String backColour;
        public static String textColour;

        private void TaskUserControl_Resize(object sender, EventArgs e)
        {
        }
    }
}
