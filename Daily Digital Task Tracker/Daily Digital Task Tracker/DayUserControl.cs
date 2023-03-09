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
        private int num = 0;
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
            ColourControl.callControlColours(this);

            string search = day.ToString() + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();

            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => search.Equals(line.Split(',')[0])));

            using (StreamReader tempRead = new StreamReader("Temp.csv"))
            {
                String line;

                while ((line = tempRead.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    num++;

                    //If there are more than 3 tasks stop adding them to the text box.
                    if (num <= 4)
                    {
                        eventsDisplay_txt.AppendText( " " + num + ". " + parts[1] + "\r\n");
                    }
                }
                //displays the total number of tasks
                if (num != 0)
                {
                    if (num == 1) { taskCount_lbl.Text = num + " Task"; }
                    else { taskCount_lbl.Text = num + " Tasks"; };
                }
            }
        }
        //Loads day expanded form
        private void DayUserControl_Click(object sender, EventArgs e)
        {
            day_stc = date_lbl.Text;
            taskCreation dayExpanded = new taskCreation();
            dayExpanded.Show();
        }
        private void eventsDisplay_txt_Click(object sender, EventArgs e)
        {
            //Loads day expanded form
            day_stc = date_lbl.Text;

            expandedDay ExpandedDay = new expandedDay();
            ExpandedDay.Show();
        }


        private void DayUserControl_Resize(object sender, EventArgs e)
        {
            //Sets the text size based on Form1's resized size
            date_lbl.Font = Form1.largeFont;
            eventsDisplay_txt.Font = Form1.smallFont;
            taskCount_lbl.Font = Form1.smallFont;
        }

        private void DayUserControl_Load(object sender, EventArgs e)
        {
            //Sets the text size based on Form1's current size
            date_lbl.Font = Form1.largeFont;
            eventsDisplay_txt.Font = Form1.smallFont;
        }

        private void day_count_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    //https://stackoverflow.com/questions/2189376/how-to-change-row-color-in-datagridview
}
