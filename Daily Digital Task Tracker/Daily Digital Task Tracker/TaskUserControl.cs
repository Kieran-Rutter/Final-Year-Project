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
        public int seconds;
        public int minutes;
        public int hours;

        public int counter;

        DateTime dt = new DateTime();
        public TaskUserControl()
        {
            InitializeComponent();
        }

        private void TaskUserControl_Load(object sender, EventArgs e)
        {
            ColourControl.callControlColours(this);

            //Sets the timer settings
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;

            //Calculates how long the counter needs to be
            seconds = Int32.Parse(expandedDay.task[2]);
            minutes = Int32.Parse(expandedDay.task[3]);
            hours = Int32.Parse(expandedDay.task[4]);

            minutes += (hours * 60);
            seconds += (minutes * 60);

            counter = seconds;

            Console.WriteLine((seconds, minutes, hours, counter).ToString());

            title_lbl.Text = expandedDay.task[1];
            timer_lbl.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
        }

        private void TaskUserControl_Click(object sender, EventArgs e)
        {

        }

        private void TaskUserControl_Resize(object sender, EventArgs e)
        {
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (start_btn.Text == "Start")
            {
                //Sets the progress bar
                progressBar.Series[0].Points[0].YValues[0] = counter;

                timer.Start();
                start_btn.Text = "Pause";
            }
            else if (start_btn.Text == "Pause")
            {
                timer.Stop();
                start_btn.Text = "Resume";
            }
            else if (start_btn.Text == "Resume")
            {
                timer.Start();
                start_btn.Text = "Pause";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            Console.WriteLine(counter.ToString());

            // Performs one step
            progressBar.Series[0].Points[0].YValues[0] -= 1;
            progressBar.Series[0].Points[1].YValues[0] += 1;
            progressBar.Refresh();

            if (timer.Enabled)
            {
                timer_lbl.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
            }
            if (counter == 0)
            {
                timer.Stop();
                start_btn.Text = "Completed";
                string day = DayUserControl.day_stc;
                string dayDate = day + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();
                csvControl.plusOneStat("Tasks Completed", dayDate);
            }
        }
    }
}
