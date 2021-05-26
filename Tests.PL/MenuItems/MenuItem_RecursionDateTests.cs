using NUnit.Framework;
using PL.MenuItems;
using System;

namespace Tests.PL.MenuItems
{
    [TestFixture]
    public class MenuItem_RecursionDateTests
    {
        [TestCase("08.12.2020", "12.12.2020", "10.12.2020", "15.12.2020", ExpectedResult = 3)]
        [TestCase("01.01.2020", "05.01.2020", "07.01.2020", "10.01.2020", ExpectedResult = 0)]
        [TestCase("10.12.2020", "15.12.2020", "12.12.2020", "17.12.2020", ExpectedResult = 4)]
        [TestCase("12.12.2020", "17.12.2020", "10.12.2020", "15.12.2020", ExpectedResult = 4)]
        public int MenuItemRecursionDate_SegmentCount(string first, string second, string third, string fourth)
        {
            DateTime.TryParseExact(first, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date1);
            DateTime.TryParseExact(second, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date2);
            DateTime.TryParseExact(third, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date3);
            DateTime.TryParseExact(fourth, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date4);

            return new MenuItem_RecursionDate().GetN(date1, date2, date3, date4);
        }

        [TestCase(0, ExpectedResult = "")]//пустая строчка
        [TestCase(6, ExpectedResult = "1 2 3 ")]
        [TestCase(990, ExpectedResult = "1 2 3 5 11 ")]
        [TestCase(95, ExpectedResult = "1 5 19 ")]
        public string MenuItemRecursionDate_PrimeFactorsNumber(int x)
        {
            return new MenuItem_RecursionDate().PrimeFactorsNumber(x);
        }
    }
}
