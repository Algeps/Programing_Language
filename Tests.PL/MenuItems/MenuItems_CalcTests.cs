using NUnit.Framework;
using PL.MenuItems;

namespace Tests.PL.MenuItems
{
    [TestFixture]
    public class MenuItems_CalcTests
    {
        [TestCase(8, 3, 5, ExpectedResult = 4.236d)]
        [TestCase(15, 0, 4, ExpectedResult = double.NaN)]//деление на ноль
        [TestCase(3, 1, -1, ExpectedResult = double.NaN)]//отрицательный корень
        public double MenuItems_Calc_Execute(int x, int z, int y)
        {
            return new MenuItem_Calc().Calc(x, z, y);
        }
    }
}
