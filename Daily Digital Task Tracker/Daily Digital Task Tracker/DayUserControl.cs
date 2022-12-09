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
    public partial class DayUserControl : UserControl
    {
        public static string day_stc;
        public DayUserControl()
        {
            InitializeComponent();
        }

        public void day(int day)
        {
            date_lbl.Text = day + "";
        }

        public void eventsDisplay(int day)
        {
            string search = Form1.month.ToString() + "/" + day.ToString() + "/" + Form1.year.ToString();
            Console.WriteLine(search);
            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => search.Equals(line.Split(',')[0])));
            eventsDisplay_txt.Text = File.ReadAllText("Temp.csv");
        }

        private void DayUserControl_Click(object sender, EventArgs e)
        {
            day_stc = date_lbl.Text;
            DayExpanded dayExpanded = new DayExpanded();
            dayExpanded.Show();
        }
    }
    //https://stackoverflow.com/questions/2189376/how-to-change-row-color-in-datagridview
}
