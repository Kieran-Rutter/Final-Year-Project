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
        }

        private void CreateEvent_btn_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Events.csv", eventDate_txt.Text + "," + eventName_txt.Text + "," + eventTime_txt.Text + "\n");
            MessageBox.Show("Created");
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
                if (values.Length == 3)
                {
                    if(values[0] == this.Text)
                    {
                        if (values[posSearch] == search)
                        {
                            if (mode == "startup")
                            {
                                task_cmb.Items.Add(values[posWrite]);
                            }
                            else if (mode == "time")
                            {
                                Console.WriteLine(values[posWrite]);
                            }
                        }
                    }
                }
            }
        }
    }
}
