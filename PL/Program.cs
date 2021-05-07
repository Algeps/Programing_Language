using PL.MenuItems;
using System;

namespace PL
{
    class Program
    {
        static void Main(string[] args)//главный метод программы
        {
            Menu.ClearItems();
            Menu.AddItem(new MenuItem_Exit());//сюда добавлять новые пункты меню
            Menu.AddItem(new MenuItem_HelloWorld());
            Menu.AddItem(new MenuItem_Formula());
            Menu.AddItem(new MenuItem_RecursionDate());
            Menu.AddItem(new MenuItem_TwoStrings());

            while (true)
            {
                Menu.Execute();
            }
        }
    }    
}
