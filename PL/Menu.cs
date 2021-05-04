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
            ShowMenu();

            int iMenu = IOUtils.SafeReadInteger(null) - 1;
            if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                MenuItems.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("ERROR! Пункт меню не найден! ");
            }
            /*switch (ShowMenu())
            {
                case 0:
                    Environment.Exit(0);//Выход из консоли без ошибки
                    break;
                case 1:
                    HelloWorld._HelloWorld();
                    break;
                case 2:
                    Formula._Formula();
                    break;
                case 3:
                    new RecursionDate()._RecursionDate();
                    break;
                case 4:
                    new TwoString()._TwoString();
                    break;
                default:
                    Console.WriteLine("ERROR! Пункт меню не найден! ");
                    break;
            }*/

        }

        private static void ShowMenu()//вывод всего меню
        {
            Console.WriteLine("\n==========================");

            int iMenuItem = 1;
            foreach (MenuItem_Core menuItem in Menu.MenuItems)
            {
                Console.WriteLine("{0}: {1}", iMenuItem++, menuItem.Title);
            }
            
            //Console.WriteLine("[0] Выход\n[1] Hello World!\n[2] Вычислить: X % Z + sqrt(Y)\n[3] Рекурсивная дат\n[4] Операция со строками");
            Console.WriteLine("==========================\n");
        }
    }
}
