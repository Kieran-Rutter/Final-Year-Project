using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace UnitTests
{
    [TestClass]
    public class CalandarTesting
    {
        [TestMethod]
        public void OnlyMonthIntAddition()
        {
            int month = 6;
            int year = 0;
            if (month == 12)
            {
                year += 1;
                month = 1;
            }
            else
            {
                month += 1;
            }

            Assert.AreEqual(7, month);
            Assert.AreEqual(0, year);
        }
        [TestMethod]
        public void OnlyMonthIntSubtraction()
        {
            int month = 6;
            int year = 1;
            if (month == 1)
            {
                year -= 1;
                month = 12;
            }
            else
            {
                month -= 1;
            }

            Assert.AreEqual(5, month);
            Assert.AreEqual(1, year);
        }

        [TestMethod]
        public void YearIntAddition()
        {
            int month = 12;
            int year = 0;
            if (month == 12)
            {
                year += 1;
                month = 1;
            }
            else
            {
                month += 1;
            }

            Assert.AreEqual(1, month);
            Assert.AreEqual(1, year);
        }
        [TestMethod]
        public void YearIntSubtraction()
        {
            int month = 1;
            int year = 1;
            if (month == 1)
            {
                year -= 1;
                month = 12;
            }
            else
            {
                month -= 1;
            }

            Assert.AreEqual(12, month);
            Assert.AreEqual(0, year);
        }

        [TestMethod]
        public void MonthStrFunction()
        {
            //Takes an int and converts it to the month nanme.
            String monthText = DateTimeFormatInfo.CurrentInfo.GetMonthName(12);
            //Checks if monthText is December
            Assert.AreEqual("December", monthText);
        }

        [TestMethod]
        public void DaysInMonth()
        {
            //4 = April
            int days = DateTime.DaysInMonth(2023, 4);
            //Expects 30
            Assert.AreEqual(30, days);
        }

        [TestMethod]
        public void MonthWeekStart()
        {
            int month = 4;//4 = April
            int year = 2023;

            //GetScaledBounds the first day of the moth
            DateTime monthStart = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            //Converts monthstart to an ineger
            int daysInWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d"));

            //Expects 30 days in april
            Assert.AreEqual(30, days);
            //Expects the first day of the month starts after 6 days (Sunday)
            Assert.AreEqual(6, daysInWeek);
        }
    }
    [TestClass]
    public class ThemeTests
    {
        [TestMethod]
        public void ThemeIni()
        {

        }
    }
}
