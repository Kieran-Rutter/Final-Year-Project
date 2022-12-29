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
    public partial class DayExpanded : Form
    {
        public DayExpanded()
        {
            InitializeComponent();
        }

        private void DayExpanded_Load(object sender, EventArgs e)
        {
            eventDate_txt.Text = DayUserControl.day_stc + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();
            this.Text = eventDate_txt.Text;
            getIni();

            searchCSV(eventDate_txt.Text, 0, 1, "startup");

            for (int i = 0; i < 60; i++)
            {
                this.seconds_cmb.Items.Add(i.ToString());
                this.mins_cmb.Items.Add(i.ToString());
            }
        }
        //Creates a new task in the events csv file
        private void CreateEvent_btn_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Events.csv", eventDate_txt.Text + "," + eventName_txt.Text + "," + 
                seconds_cmb.Text + "," + mins_cmb.Text + "," + hours_cmb.Text + "\n");
            MessageBox.Show("Created");
            //Adds new event to the combo box
            task_cmb.Items.Add(eventName_txt.Text);
        }

        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            backColour = Form1.backColour;
            textColour = Form1.textColour;

            //User control colours
            this.BackColor = ColorTranslator.FromHtml(backColour);


            //Expand button

        }
        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;

        private void time_btn_Click(object sender, EventArgs e)
        {
            searchCSV(task_cmb.Text,1 ,2, "time");
        }
        private void searchCSV(string search,int posSearch, int posWrite, string mode)
        {
            //Loop to find time of task
            var lines = File.ReadAllLines("Events.csv");
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 5)
                {
                    if(values[0] == this.Text)
                    {
                        if (values[posSearch] == search)
                        {
                            if (mode == "startup")
                            {
                                Console.WriteLine("startup " + values[posWrite]);
                                task_cmb.Items.Add(values[posWrite]);
                            }
                            else if (mode == "time")
                            {
                                Console.WriteLine(values[posWrite]);
                                seconds_cmb.Text = values[posWrite];
                                mins_cmb.Text = values[posWrite + 1];
                                hours_cmb.Text = values[posWrite + 2];
                            }
                        }
                    }
                }
            }
        }
        private int counter;
        DateTime dt = new DateTime();
        //https://stackoverflow.com/questions/10576024/c-sharp-windows-form-countdown-timer
        private void start_btn_Click(object sender, EventArgs e)
        {
            //Calculates how long the counter needs to be
            int seconds = Int32.Parse(seconds_cmb.Text);
            int minutes = Int32.Parse(mins_cmb.Text);
            int hours = Int32.Parse(hours_cmb.Text);

            minutes = (minutes + (hours * 60));
            counter = (seconds + (minutes * 60));

            //Sets the progress bar settings
            progressBar1.Maximum = counter * 1000;
            progressBar1.Step = 1000;
            progressBar1.Value = 0;

            //Sets the timer settings
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();

            label1.Text = counter.ToString();

        }
        //Function is run when the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;

            // Performs one step
            progressBar1.PerformStep();

            if (timer1.Enabled)
            {
                label1.Text = dt.AddSeconds(counter).ToString("hh:mm:ss");
            }
            if (counter == 0)
            {
                timer1.Stop();
            }
        }
        //Inserts the time into the input fields when a task is selected
        private void task_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCSV(task_cmb.Text, 1, 2, "time");
        }
    }
}
