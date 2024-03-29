﻿using PL.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PL
{
    public class Menu
    {
        private static List<Task> MenuItems = new List<Task>(); //список из пунктов меню

        public static int ItemsCount
        {
            get
            {
                return MenuItems.Count();
            }
        }

        public static List<string> MenuItemsTitle = new List<string>();

        public static void ClearItems()//метод, который всё удаляет
        {
            Menu.MenuItems.Clear();
            Menu.MenuItemsTitle.Clear();
        }

        public static void AddItem(Task menuItem)//если мы хотим добавить какой-то пункт меню
        {
            Menu.MenuItems.Add(menuItem);
            Menu.MenuItemsTitle.Add(menuItem.Title);
        }
        
        public static void Execute()//все операции с меню
        {
            
                int iMenu = IOUtils.SafeReadInteger("mi", null);
                //Console.Clear();
                switch (iMenu)
                {
                    case 0:
                        MenuItems.ToArray()[0].Execute();
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
                        MenuItems.ToArray()[4].Execute();
                        break;
                    default:
                        Console.WriteLine("ERROR! The menu item was not found! ");

                        break;
                }
            
        }

        public static void ShowMenu()//вывод всего меню
        {
            Console.WriteLine("\n==========================");
            int iMenuItem = 0;
            foreach (Task menuItem in Menu.MenuItems)
            {
                Console.WriteLine("[{0}] {1}", iMenuItem++, menuItem.Title);
            }
            Console.WriteLine("==========================\n");
        }
    }
}
