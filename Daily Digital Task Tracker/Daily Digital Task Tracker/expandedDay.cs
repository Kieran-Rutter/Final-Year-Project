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
        public static int incom_count = 0;
        public expandedDay()
        {
            InitializeComponent();
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
                }
            }
        }
        public List<dateStatistic> statsDisplay(string day)
        {
            string daySearch = day + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();

            File.WriteAllLines("Temp.csv", File.ReadAllLines("Stats.csv").Where(line => daySearch.Equals(line.Split(',')[0])));

            var query = from l in File.ReadAllLines("Temp.csv")
                        let data = l.Split(',')
                        select new dateStatistic
                        {
                            eventDate = data[0],
                            eventName = data[1],
                            eventCount = Int32.Parse(data[2]),
                        };
            return query.ToList();
        }

        public class dateStatistic
        {
            public string eventDate { get; set; }
            public string eventName { get; set; }
            public int eventCount { get; set; }
        }

        private void expandedDay_Load(object sender, EventArgs e)
        {
            ColourControl.callColours(this);
            string day = DayUserControl.day_stc;
            taskDisplay(day);
            statisticsGridView.RowHeadersVisible = false;
            statisticsGridView.DataSource = statsDisplay(day);
        }


        /*
 * Functions for theme and auto sizing
*/
        //Dynamic scale

        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
        public static String buttonBorderColour;

        private void create_btn_Click(object sender, EventArgs e)
        {
            //Loads day expanded form
            taskCreation TaskCreation = new taskCreation();
            TaskCreation.Show();
        }

        private Rectangle originalFormSize;
        private Rectangle create_btnOriginalRectangle;
        private Rectangle taskTBL_pnlOriginalRectangle;
        private Rectangle tasks_lblOriginalRectangle;

        private float buttonlOriginalFontSize;
        private void expandedDay_Resize(object sender, EventArgs e)
        {
            if (shown)
            {
                //Daily_Digital_Task_Tracker.Resize.resizeControl(taskTBL_pnlOriginalRectangle, taskTBL_pnl, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);
                //Daily_Digital_Task_Tracker.Resize.resizeControl(tasks_lblOriginalRectangle, tasks_lbl, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);
                //Daily_Digital_Task_Tracker.Resize.resizeControl(create_btnOriginalRectangle, create_btn, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);

            }
        }
        public void resizeTest(Control textc)
        {
            if (textc is TableLayoutPanel)
            {
                foreach (Control c in textc.Controls)
                {
                    resizeTest(c);
                }
            }
            if (textc is Label)
            {
                //ResizeControl.resizeTextControl(textc, lblOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
            if (textc is Button)
            {
                ResizeControl.resizeTextControl(textc, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
        }

        private static bool shown = false;
        private void expandedDay_Shown(object sender, EventArgs e)
        {
            //Variables for resize
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);

            //Text
            buttonlOriginalFontSize = tasks_lbl.Font.Size;

            shown = true;
        }

    }
}
