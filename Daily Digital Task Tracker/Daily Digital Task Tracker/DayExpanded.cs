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
            date_lbl.Text = DayUserControl.day_stc + "/" + Form1.month.ToString() + "/" + Form1.year.ToString();
            this.Text = date_lbl.Text;
            getIni();

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

            //function at bottom to reduce code clutter.
            originalRectangle();

        }
        //Creates a new task in the events csv file
        private void CreateEvent_btn_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Events.csv", date_lbl.Text + "," + task_cmb.Text + "," +
                seconds_cmb.Text + "," + mins_cmb.Text + "," + hours_cmb.Text + "\n");
            MessageBox.Show("Created");
            //Adds new event to the combo box
            task_cmb.Items.Add(task_cmb.Text);
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
        }
        //Function is run when the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;

            // Performs one step
            progressBar1.PerformStep();


            if (timer1.Enabled)
            {
                timer_lbl.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
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

        /*
         * Functions for theme and auto sizing
         */
        //Dynamic scale
        private float fontScale = 1f;

        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
        public static String buttonBorderColour;
        private void getIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            backColour = settings.backColour;
            textColour = settings.textColour;
            buttonBackColour = settings.buttonBackColour;
            buttonBorderColour = settings.buttonBorderColour;

            //User control colours
            this.BackColor = ColorTranslator.FromHtml(backColour);

            //Buttons
            this.CreateEvent_btn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.CreateEvent_btn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
            this.CreateEvent_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);

            this.start_btn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.start_btn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
            this.start_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);

            //Progress bar
            this.progressBar1.ForeColor = ColorTranslator.FromHtml(textColour);
            this.progressBar1.BackColor = ColorTranslator.FromHtml(buttonBackColour);

            //Labels
            this.timer_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.date_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
        }

        private void DayExpanded_Resize(object sender, EventArgs e)
        {
            resizeControl(CreateEvent_btnlOriginalRectangle, CreateEvent_btn, buttonlOriginalFontSize);
            resizeControl(start_btnOriginalRectangle, start_btn, buttonlOriginalFontSize);
            //Combo box
            resizeControl(task_cmbOriginalRectangle, task_cmb, cmbOriginalFontSize);
            resizeControl(hours_cmbOriginalRectangle, hours_cmb, cmbOriginalFontSize);
            resizeControl(mins_cmbOriginalRectangle, mins_cmb, cmbOriginalFontSize);
            resizeControl(seconds_cmbOriginalRectangle, seconds_cmb, cmbOriginalFontSize);

            resizeControl(progressBarOriginalRectangle, progressBar1, buttonlOriginalFontSize);

            //Labels
            resizeControl(date_lblOriginalRectangle, date_lbl, date_lblOriginalFontSize);
            resizeControl(timer_lblOriginalRectangle, timer_lbl, timer_lblOriginalFontSize);

        }

        //Resize control function to calculate new sizes
        public void resizeControl(Rectangle r, Control c, float originalFontSize)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }

            float newFontSize = originalFontSize * ratio * fontScale;
            Font newFont = new Font(c.Font.FontFamily, newFontSize);
            c.Font = newFont;
        }
        public void originalRectangle()
        {
            //Variables for resize
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            CreateEvent_btnlOriginalRectangle = new Rectangle(CreateEvent_btn.Location.X, CreateEvent_btn.Location.Y,
                CreateEvent_btn.Width, CreateEvent_btn.Height);
            start_btnOriginalRectangle = new Rectangle(start_btn.Location.X, start_btn.Location.Y,
                start_btn.Width, start_btn.Height);
            //Combo boxes
            task_cmbOriginalRectangle = new Rectangle(task_cmb.Location.X, task_cmb.Location.Y,
                task_cmb.Width, task_cmb.Height);
            hours_cmbOriginalRectangle = new Rectangle(hours_cmb.Location.X, hours_cmb.Location.Y,
                hours_cmb.Width, hours_cmb.Height);
            mins_cmbOriginalRectangle = new Rectangle(mins_cmb.Location.X, mins_cmb.Location.Y,
                mins_cmb.Width, mins_cmb.Height);
            seconds_cmbOriginalRectangle = new Rectangle(seconds_cmb.Location.X, seconds_cmb.Location.Y,
                seconds_cmb.Width, seconds_cmb.Height);

            //Progress bar
            progressBarOriginalRectangle = new Rectangle(progressBar1.Location.X, progressBar1.Location.Y,
                progressBar1.Width, progressBar1.Height);

            //Labels
            date_lblOriginalRectangle = new Rectangle(date_lbl.Location.X, date_lbl.Location.Y,
                date_lbl.Width, date_lbl.Height);
            timer_lblOriginalRectangle = new Rectangle(timer_lbl.Location.X, timer_lbl.Location.Y,
                timer_lbl.Width, timer_lbl.Height);

            //Text
            lblOriginalFontSize = date_lbl.Font.Size;
            buttonlOriginalFontSize = CreateEvent_btn.Font.Size;
            cmbOriginalFontSize = hours_cmb.Font.Size;

            date_lblOriginalFontSize = date_lbl.Font.Size;
            timer_lblOriginalFontSize = timer_lbl.Font.Size;
        }
        private Rectangle originalFormSize;
        private Rectangle CreateEvent_btnlOriginalRectangle;
        private Rectangle start_btnOriginalRectangle;

        private Rectangle task_cmbOriginalRectangle;

        private Rectangle hours_cmbOriginalRectangle;
        private Rectangle mins_cmbOriginalRectangle;
        private Rectangle seconds_cmbOriginalRectangle;

        private Rectangle progressBarOriginalRectangle;

        private Rectangle date_lblOriginalRectangle;
        private Rectangle timer_lblOriginalRectangle;

        private float lblOriginalFontSize;

        private float date_lblOriginalFontSize;
        private float timer_lblOriginalFontSize;
        private float buttonlOriginalFontSize;
        private float cmbOriginalFontSize;
    }
}
