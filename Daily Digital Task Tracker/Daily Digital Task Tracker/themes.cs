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
    public partial class themes : Form
    {
        public int i = 0;
        public themes()
        {
            InitializeComponent();
        }
        //https://stackoverflow.com/questions/38185178/how-to-get-the-hex-color-code-from-a-color-dialog-in-visual-studio
        //Loads the current theme.
        private void themes_Load(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.readIni();

            hex_lbl.Text = set.testTheme.Replace("#", "");
            coin_lbl.Text = "Coins: " + set.coinCount;

            ColourControl.callColours(this);
        }
        //Adds or takes one from the index.
        private void next_btn_Click(object sender, EventArgs e)
        {
            i++;
            changeHex();
        }
        private void prev_btn_Click(object sender, EventArgs e)
        {
            i--;
            changeHex();
        }
        //Uses the index to get a hex from the themes CSV.
        private void changeHex()
        {
            using (StreamReader tempRead = new StreamReader("Theme.csv"))
            {
                try
                {
                    String line;
                    line = tempRead.ReadLine();
                    string[] parts = line.Split(',');

                    if (i > (parts.Length - 1))
                    {
                        i = 0;
                    }
                    else if(i < 0)
                    {
                        i = (parts.Length - 1);
                    }

                    hex_lbl.Text = parts[i];

                    write_Theme("testTheme", parts[i]);
                }
                catch(NullReferenceException)
                {

                }
            }
        }
        //Calls colours when the form is loaded
        private void themes_Activated(object sender, EventArgs e)
        {
            ColourControl.callColours(this);
        }
        // Button will display a color diolog box and chenge the theme when a colour is selected.
        private void try_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                string search = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");

                write_Theme("testTheme", search);
                hex_lbl.Text = search ;

                File.WriteAllLines("Temp.csv", File.ReadAllLines("Theme.csv").Where(line => search.Equals(line.Split(',')[0])));

                using (StreamReader tempRead = new StreamReader("Temp.csv"))
                {
                    //Checks to see if the theme is owned and will promt the user to unlcock if not.
                    if ((tempRead.ReadLine()) == null)
                    {
                        save_btn.Text = "Buy Colour \n" +
                                        "-1 Coin";
                    }
                    else
                    {
                        save_btn.Text = "Apply Colour";
                    }
                }
            }
        }

        //Saves selected hex to a csv file.
        private void save_btn_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            int coinCount = Int32.Parse(coinControl.readCoins());

            string newHex = hex_lbl.Text;

            if (save_btn.Text == "Apply Colour")
            {
                write_Theme("themeColour", newHex);
            }
            else
            {
                //Checks if the user has enough coins.
                if (coinCount <= 0)
                {
                    MessageBox.Show("Not enough coins \n" +
                                    "Complete more tasks to earn coins");
                }
                else
                {
                    save_btn.Text = "Apply Colour";
                    csvControl.Append("Theme.csv", ("," + newHex));
                    coinControl.takeCoins();

                }
            }
            coin_lbl.Text = "Coins: " + Int32.Parse(coinControl.readCoins());
        }
        // resets to default theme.
        private void reset_btn_Click(object sender, EventArgs e)
        {
            write_Theme("themeColour", "1C1C21");
            write_Theme("testTheme", "1C1C21");
        }

        private void themes_Leave(object sender, EventArgs e)
        {
            write_Theme("testTheme", "1C1C21");
        }
        private void write_Theme(string key, string hex)
        {
            Settings set = new Settings();
            set.readIni();
            set.writeini("SECTION", key, hex);
            //https://stackoverflow.com/questions/22935285/change-color-of-all-controls-inside-the-form-in-c-sharp
            ColourControl.callColours(this);
        }
    }
}
