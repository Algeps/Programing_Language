using PL.MenuItems;
using System;
using System.Collections.Generic;

namespace PL
{
    class Menu
    {
        private static List<MenuItem_Core> MenuItems = new List<MenuItem_Core>(); //список из пунктов меню
        
        public static void ClearItems()//метод, который всё удаляет
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(MenuItem_Core menuItem)//если мы хотим добавить какой-то пункт меню
        {
            Menu.MenuItems.Add(menuItem);  
        }
        
        public static void Execute()//все операции с меню
        {
            while (true)
            {
                ShowMenu();
                int iMenu = IOUtils.SafeReadInteger(null);
                
                switch (iMenu)
                {
                    case 0:
                        Environment.Exit(0);//Выход из консоли без ошибки
                        break;
                    case 1:
                        MenuItems.ToArray()[1].Execute();
                        break;
                    case 2:
                        MenuItems.ToArray()[2].Execute();
                        break;
                    case 3:
                        MenuItems.ToArray()[3].Execute();
                        break;
                    case 4:
                        new TwoString()._TwoString();
                        break;
                    default:
                        Console.WriteLine("ERROR! The menu item was not found! ");
                        break;
                }
            }
        }

        private static void ShowMenu()//вывод всего меню
        {
            Console.WriteLine("\n==========================");
            int iMenuItem = 0;
            foreach (MenuItem_Core menuItem in Menu.MenuItems)
            {
                Console.WriteLine("[{0}] {1}", iMenuItem++, menuItem.Title);
            }
            Console.WriteLine("==========================\n");
        }
    }
}
