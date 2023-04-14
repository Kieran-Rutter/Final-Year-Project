using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Digital_Task_Tracker
{
    class coinControl
    {
        //Returns how many coins the user has
        public static string readCoins()
        {
            Settings settings = new Settings();
            settings.readIni();

            string coins = settings.coinCount;

            return coins;
        }
        public static void addCoins()
        {
            Settings settings = new Settings();
            settings.readIni();

            int coinCount = Int32.Parse(readCoins());

            string newCount = (coinCount + 1).ToString();

            settings.writeini("SECTION", "coinCount", newCount);
            string coins = settings.coinCount;
        }

        public static void takeCoins()
        {
            Settings settings = new Settings();
            settings.readIni();

            int coinCount = Int32.Parse(readCoins());

            string newCount = (coinCount - 1).ToString();

            settings.writeini("SECTION", "coinCount", newCount);
            string coins = settings.coinCount;
        }
    }
}
