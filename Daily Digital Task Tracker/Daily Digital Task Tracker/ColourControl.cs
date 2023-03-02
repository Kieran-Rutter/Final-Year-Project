﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    class ColourControl
    {
        public static String backColour;
        public static String textColour;
        public static String buttonBackColour;
        public static String buttonBorderColour;

        public static void readIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            backColour = settings.backColour;
            textColour = settings.textColour;
            buttonBackColour = settings.buttonBackColour;
            buttonBorderColour = settings.buttonBorderColour;
        }
        public static void UpdateColorControls(Control myControl)
        {
            readIni();
            if (myControl is TableLayoutPanel)
            {
                foreach (Control c in myControl.Controls)
                {
                    UpdateColorControls(c);
                }
            }
            if (myControl is Button)
            {
                myControl.BackColor = ColorTranslator.FromHtml(buttonBackColour);
                myControl.ForeColor = ColorTranslator.FromHtml(textColour);
            }
            if (myControl is Label)
            {
                myControl.ForeColor = ColorTranslator.FromHtml(textColour);
            }
        }
        public static void UpdateBackColour(Form myForm)
        {
            readIni();
            myForm.BackColor = ColorTranslator.FromHtml(backColour);
        }
    }
}