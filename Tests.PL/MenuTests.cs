using NUnit.Framework;
using PL;
using PL.MenuItems;

namespace Tests.PL
{
    [TestFixture]
    class MenuTests
    {
        [Test]
        public void Menu_ManageItems()
        {
            Menu.ClearItems();

            Menu.AddItem(new MenuItem_Exit());
            Assert.AreEqual(1, Menu.ItemsCount);

            Menu.ClearItems();
            Assert.AreEqual(0, Menu.ItemsCount);
        }

        [Test]
        public void Menu_ItemsTitles()//создал отдельный публичный строковый список MenuItemsTitles(другой недоступен из-за уровня защиты)
        {
            Menu.ClearItems();

            Menu.AddItem(new MenuItem_Exit());
            Assert.AreEqual("Exit", Menu.MenuItemsTitle[0]);

            Menu.AddItem(new MenuItem_HelloWorld());
            Assert.AreEqual("Hello World!", Menu.MenuItemsTitle[1]);

            Menu.AddItem(new MenuItem_Calc());
            Assert.AreEqual("Calc: X % Z + sqrt(Y)", Menu.MenuItemsTitle[2]);

            Menu.AddItem(new MenuItem_RecursionDate());
            Assert.AreEqual("Recursion date", Menu.MenuItemsTitle[3]);

            Menu.AddItem(new MenuItem_TwoStrings());
            Assert.AreEqual("Strings", Menu.MenuItemsTitle[4]);

            Menu.ClearItems();
        }

    }
}
