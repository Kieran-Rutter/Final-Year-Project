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
    public partial class taskCreation : Form
    {
        public static int seconds;
        public static int minutes;
        public static int hours;
        //Shown used to make sure the form has fully loaded, used to make sure form does not try to resize before loaded.
        private static bool shown = false;

        public taskCreation()
        {
            InitializeComponent();
        }

        private void DayExpanded_Load(object sender, EventArgs e)
        {
            shown = false;
            string icon = "_"+ DayUserControl.day_stc;
            this.Icon = (Icon)Properties.Resources.ResourceManager.GetObject(icon);

            date_lbl.Text = DayUserControl.day_stc + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();
            this.Text = date_lbl.Text;
            ColourControl.callColours(this);

            searchCSV(date_lbl.Text, 0, 1, "startup");

            //Loops to insert values into combo boxes
            for (int i = 0; i < 60; i++)
            {
                this.seconds_cmb.Items.Add(i.ToString());
                this.mins_cmb.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 24; i++)
            {
                this.hours_cmb.Items.Add(i.ToString());
            }
        }
        //Creates a new task in the events csv file
        private void CreateEvent_btn_Click(object sender, EventArgs e)
        {
            csvControl.Append("Events.csv", (date_lbl.Text + "," + task_cmb.Text + "," +
                seconds_cmb.Text + "," + mins_cmb.Text + "," + hours_cmb.Text + "\n"));
            //Adds new event to the combo box
            task_cmb.Items.Add(task_cmb.Text);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string search = task_cmb.Text;
            string dateSearch = date_lbl.Text;
            Console.WriteLine(search);
            Console.WriteLine(dateSearch);
            //Gets all tasks not in the selected date
            File.WriteAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => (!dateSearch.Equals(line.Split(',')[0]))));
            //Gets all tasks that are in the selected date but not = to the task name
            File.AppendAllLines("Temp.csv", File.ReadAllLines("Events.csv").Where(line => !search.Equals(line.Split(',')[1])).Where(line => (dateSearch.Equals(line.Split(',')[0]))));
            //Writes both statements above to the events file
            File.WriteAllLines("Events.csv", File.ReadAllLines("Temp.csv"));
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            delete_btn_Click(sender, e);
            CreateEvent_btn_Click(sender, e);
        }

        private void searchCSV(string search, int posSearch, int posWrite, string mode)
        {
            //Loop to find time of task
            var lines = File.ReadAllLines("Events.csv");
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 5)
                {
                    if (values[0] == this.Text)
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
        //Inserts the time into the input fields when a task is selected
        private void task_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCSV(task_cmb.Text, 1, 2, "time");
        }

        /*
         * Functions for theme and auto sizing
         */

        private void DayExpanded_Resize(object sender, EventArgs e)
        {
            if (shown)
            {
                //Loads the resize control class for each controll in the form.
                foreach (Control textc in this.Controls)
                {
                    resizeTest(textc);
                }

                //Labels
                //Daily_Digital_Task_Tracker.Resize.resizeControl(date_lblOriginalRectangle, date_lbl, date_lblOriginalFontSize, originalFormSize, this.Height, this.Width);
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
                ResizeControl.resizeTextControl(textc, time_lblOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
            if (textc is Button)
            {
                ResizeControl.resizeTextControl(textc, buttonlOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
            if (textc is ComboBox)
            {
                ResizeControl.resizeTextControl(textc, cmbOriginalFontSize, originalFormSize, this.Height, this.Width);
            }
        }

        private void DayExpanded_Shown(object sender, EventArgs e)
        {
            //Sets combo boxes to 0 to avoid error
            hours_cmb.SelectedIndex = 0;
            mins_cmb.SelectedIndex = 0;
            seconds_cmb.SelectedIndex = 0;
            //Variables for resize
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            //Buttons
            CreateEvent_btnlOriginalRectangle = new Rectangle(CreateEvent_btn.Location.X, CreateEvent_btn.Location.Y,
                CreateEvent_btn.Width, CreateEvent_btn.Height);
            edit_btnlOriginalRectangle = new Rectangle(edit_btn.Location.X, edit_btn.Location.Y,
    edit_btn.Width, edit_btn.Height);
            delete_btnlOriginalRectangle = new Rectangle(delete_btn.Location.X, delete_btn.Location.Y,
    delete_btn.Width, delete_btn.Height);
            //Combo boxes
            task_cmbOriginalRectangle = new Rectangle(task_cmb.Location.X, task_cmb.Location.Y,
                task_cmb.Width, task_cmb.Height);
            hours_cmbOriginalRectangle = new Rectangle(hours_cmb.Location.X, hours_cmb.Location.Y,
                hours_cmb.Width, hours_cmb.Height);
            mins_cmbOriginalRectangle = new Rectangle(mins_cmb.Location.X, mins_cmb.Location.Y,
                mins_cmb.Width, mins_cmb.Height);
            seconds_cmbOriginalRectangle = new Rectangle(seconds_cmb.Location.X, seconds_cmb.Location.Y,
                seconds_cmb.Width, seconds_cmb.Height);

            //Labels
            date_lblOriginalRectangle = new Rectangle(date_lbl.Location.X, date_lbl.Location.Y,
                date_lbl.Width, date_lbl.Height);

            taskName_lblOriginalRectangle = new Rectangle(taskName_lbl.Location.X, taskName_lbl.Location.Y,
                taskName_lbl.Width, taskName_lbl.Height);
            hours_lblOriginalRectangle = new Rectangle(hours_lbl.Location.X, hours_lbl.Location.Y,
                hours_lbl.Width, hours_lbl.Height);
            minutes_lblOriginalRectangle = new Rectangle(mins_lbl.Location.X, mins_lbl.Location.Y,
                mins_lbl.Width, mins_lbl.Height);
            seconds_lblOriginalRectangle = new Rectangle(seconds_lbl.Location.X, seconds_lbl.Location.Y,
                seconds_lbl.Width, seconds_lbl.Height);


            //Text
            buttonlOriginalFontSize = CreateEvent_btn.Font.Size;
            cmbOriginalFontSize = hours_cmb.Font.Size;

            date_lblOriginalFontSize = date_lbl.Font.Size;
            time_lblOriginalFontSize = taskName_lbl.Font.Size;

            shown = true;
        }


        private Rectangle originalFormSize;
        private Rectangle CreateEvent_btnlOriginalRectangle;
        private Rectangle edit_btnlOriginalRectangle;
        private Rectangle delete_btnlOriginalRectangle;

        private Rectangle task_cmbOriginalRectangle;

        private Rectangle hours_cmbOriginalRectangle;
        private Rectangle mins_cmbOriginalRectangle;
        private Rectangle seconds_cmbOriginalRectangle;
        //Labels
        private Rectangle date_lblOriginalRectangle;
        private Rectangle taskName_lblOriginalRectangle;
        private Rectangle hours_lblOriginalRectangle;
        private Rectangle minutes_lblOriginalRectangle;
        private Rectangle seconds_lblOriginalRectangle;

        private float date_lblOriginalFontSize;
        private float time_lblOriginalFontSize;
        private float buttonlOriginalFontSize;
        private float cmbOriginalFontSize;
    }
}
