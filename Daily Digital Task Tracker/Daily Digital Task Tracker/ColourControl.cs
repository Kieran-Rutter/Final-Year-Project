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

        public static void callColours(Form myForm)
        {
            UpdateBackColour(myForm);

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
            if (myControl is Button btn)
            {
                btn.BackColor = ColorTranslator.FromHtml(buttonBackColour);
                btn.ForeColor = ColorTranslator.FromHtml(textColour);
                btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(buttonBorderColour);
            }
            if (myControl is Label)
            {
                myControl.ForeColor = ColorTranslator.FromHtml(textColour);
            }
            if (myControl is TextBox txtBx)
            {
                txtBx.BackColor = ColorTranslator.FromHtml(buttonBackColour);
                txtBx.ForeColor = ColorTranslator.FromHtml(textColour);
            }
            if (myControl is DataGridView dgv)
            {
                dgv.BackgroundColor = ColorTranslator.FromHtml(buttonBackColour);
                dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(buttonBackColour);
                dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(textColour);
                dgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15);

            }
        }
        public static void UpdateBackColour(Form myForm)
        {
            readIni();
            myForm.BackColor = ColorTranslator.FromHtml(backColour);
        }
        public static void UpdateControlBackColour(UserControl myControl)
        {
            readIni();
            myControl.BackColor = ColorTranslator.FromHtml(buttonBackColour);
        }
    }
}
