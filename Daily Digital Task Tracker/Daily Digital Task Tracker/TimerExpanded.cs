﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    public partial class TimerExpanded : Form
    {
        public TimerExpanded()
        {
            InitializeComponent();
        }

        private int counter;
        DateTime dt = new DateTime();
        //https://stackoverflow.com/questions/10576024/c-sharp-windows-form-countdown-timer
        private void start_btn_Click(object sender, EventArgs e)
        {
            if (start_btn.Text == "Start")
            {
                //Sets the progress bar
                progressBar.Series[0].Points[0].YValues[0] = counter;

                timer1.Start();
                start_btn.Text = "Pause";
            }
            else if (start_btn.Text == "Pause")
            {
                timer1.Stop();
                start_btn.Text = "Resume";
            }
            else if (start_btn.Text == "Resume")
            {
                timer1.Start();
                start_btn.Text = "Pause";
            }
        }

        private void TimerExpanded_Load(object sender, EventArgs e)
        {
            getIni();
            //function at bottom to reduce code clutter.
            originalRectangle();

            //Calculates how long the counter needs to be
            counter = (DayExpanded.seconds + (DayExpanded.minutes * 60));

            //Sets the timer settings
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;

            progressBar.Titles[0].Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
            //timer_lbl.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;

            // Performs one step
            progressBar.Series[0].Points[0].YValues[0] -= 1;
            progressBar.Series[0].Points[1].YValues[0] += 1;
            progressBar.Refresh();

            if (timer1.Enabled)
            {
                progressBar.Titles[0].Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
                //timer_lbl.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
            }
            if (counter == 0)
            {
                timer1.Stop();
            }
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
            this.start_btn.ForeColor = ColorTranslator.FromHtml(textColour);
            this.start_btn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
            this.start_btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);

            //Labels
            this.timer_lbl.ForeColor = ColorTranslator.FromHtml(textColour);
            this.progressBar.Titles[0].ForeColor = ColorTranslator.FromHtml(textColour);
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
            start_btnOriginalRectangle = new Rectangle(start_btn.Location.X, start_btn.Location.Y,
                start_btn.Width, start_btn.Height);


            //Progress bar
            progressBarOriginalRectangle = new Rectangle(progressBar.Location.X, progressBar.Location.Y,
                progressBar.Width, progressBar.Height);

            //Labels
            timer_lblOriginalRectangle = new Rectangle(timer_lbl.Location.X, timer_lbl.Location.Y,
                timer_lbl.Width, timer_lbl.Height);

            //Text
            timer_lblOriginalFontSize = timer_lbl.Font.Size;
            buttonlOriginalFontSize = start_btn.Font.Size;

        }
        private Rectangle originalFormSize;
        private Rectangle start_btnOriginalRectangle;

        private Rectangle progressBarOriginalRectangle;

        private Rectangle timer_lblOriginalRectangle;

        private float timer_lblOriginalFontSize;
        private float buttonlOriginalFontSize;

        private void TimerExpanded_Resize(object sender, EventArgs e)
        {
            resizeControl(start_btnOriginalRectangle, start_btn, buttonlOriginalFontSize);

            resizeControl(progressBarOriginalRectangle, progressBar, buttonlOriginalFontSize);

            //Labels
            resizeControl(timer_lblOriginalRectangle, timer_lbl, timer_lblOriginalFontSize);
            progressBar.Titles[0].Font = timer_lbl.Font;
        }
    }
}