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
    public partial class expandedDay : Form
    {
        public static string[] task;
        public expandedDay()
        {
            InitializeComponent();
        }

        public void day(int day)
        {

        }

        public void taskDisplay(string day)
        {
            string search = day + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();

            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => search.Equals(line.Split(',')[0])));

            using (StreamReader tempRead = new StreamReader("Temp.csv"))
            {

                String line;
                while ((line = tempRead.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    task = parts;
                    TaskUserControl tuc = new TaskUserControl();

                    tuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                        | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));

                    task_pnl.Controls.Add(tuc);
                    tuc.taskDisplay();
                }
            }
        }

        private void expandedDay_Load(object sender, EventArgs e)
        {
            string day = DayUserControl.day_stc;
            taskDisplay(day);
        }
    }
}
