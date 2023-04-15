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
        public static String themeColour;

        public static Color fColour;
        public static Color bColour;
        public static Color tColour;
        public static Color borderColour;
        public static Color baseColour;

        public static bool testMode = false;

        public static void callColours(Form myForm)
        {
            UpdateBackColour(myForm);

            if (myForm.Text == "Themes")
            {
                testMode = true;
            }
            else
            {
                testMode = false;
            }

            //Loads the colour controll class for each controll in the form.
            foreach (Control c in myForm.Controls)
            {
                UpdateColorControls(c);
            }
        }
        public static void callControlColours(UserControl myUserControl)
        {
            ColourControl.UpdateControlBackColour(myUserControl);

            //Loads the colour control class for each controll in the form.
            foreach (Control c in myUserControl.Controls)
            {
                ColourControl.UpdateColorControls(c);
            }
        }

        public static void readIni()
        {
            Settings settings = new Settings();
            settings.readIni();

            if(testMode)
            {
                themeColour = settings.testTheme;
            }
            else
            {
                themeColour = settings.themeColour;
            }
            baseColour = ColorTranslator.FromHtml(themeColour);

            fColour = ControlPaint.Dark(baseColour);
            borderColour = ControlPaint.DarkDark(baseColour);
            bColour = ControlPaint.Light(baseColour);

            tColour = Color.FromArgb(fColour.ToArgb() ^ 0xfffff);
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
            if (myControl is Button btn)
            {
                btn.BackColor = bColour;
                btn.ForeColor = tColour;
                btn.FlatAppearance.BorderColor = borderColour;
            }
            if (myControl is Label)
            {
                myControl.ForeColor = tColour;
            }
            if (myControl is TextBox txtBx)
            {
                txtBx.BackColor = bColour;
                txtBx.ForeColor = tColour;
            }
            if (myControl is DataGridView dgv)
            {
                dgv.BackgroundColor = bColour;
                dgv.DefaultCellStyle.BackColor = bColour;
                dgv.DefaultCellStyle.ForeColor = tColour;
                dgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15);
            }
        }
        public static void UpdateBackColour(Form myForm)
        {
            readIni();
            myForm.BackColor = fColour;
        }
        public static void UpdateControlBackColour(UserControl myControl)
        {
            readIni();
            myControl.BackColor = bColour;
        }
    }
}
