﻿using System;
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
            task_pnl.Controls.Clear();
            string search = day + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();

            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => search.Equals(line.Split(',')[0])));

            using (StreamReader tempRead = new StreamReader("Temp.csv"))
            {
                //Displays the users controls with tasks information
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
        //Function that reads and displays all stats from that day.
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
        //Sets up the dat agrid view when loaded.
        private void expandedDay_Load(object sender, EventArgs e)
        {
            ColourControl.callColours(this);
            string day = DayUserControl.day_stc;
            taskDisplay(day);
            statisticsGridView.RowHeadersVisible = false;
            statisticsGridView.DataSource = statsDisplay(day);

            //First line is the date and not needed
            statisticsGridView.Columns["eventDate"].Visible = false;
            statisticsGridView.ColumnHeadersVisible = false;

            statisticsGridView.Columns[1].Width = (int)(statisticsGridView.Width * 0.5);
            statisticsGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Works out completed ratio
            int completed = 1;
            int created = 1;

            try
            {
                DataGridViewRow row = statisticsGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["eventName"].Value.ToString().Equals("Tasks Completed"))
                    .First();

                completed = int.Parse(statisticsGridView.Rows[row.Index].Cells[2].Value.ToString());

                row = statisticsGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["eventName"].Value.ToString().Equals("Tasks Created"))
                .First();

                created = int.Parse(statisticsGridView.Rows[row.Index].Cells[2].Value.ToString());

                completionRation_lbl.Text = ("You have a completion ratio of roughly %" + ((completed / created) * 100).ToString());
            }
            catch {
                completionRation_lbl.Text = "Complete some tasks to see the completion ratio.";
            }
            CompletionChart.Series[0].Points[0].YValues[0] = completed;
            CompletionChart.Series[0].Points[1].YValues[0] = created;
        }


        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
        public static String buttonBorderColour;
        // Opens the task creation form and waits for it to close.
        private void create_btn_Click(object sender, EventArgs e)
        {
            //Loads day expanded form
            taskCreation TaskCreation = new taskCreation();
            TaskCreation.Show();

            TaskCreation.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }
        //Runs when the task creation form is closed and resets the task list.
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string day = DayUserControl.day_stc;
            taskDisplay(day);
            statisticsGridView.RowHeadersVisible = false;
            statisticsGridView.DataSource = statsDisplay(day);
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
