using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
