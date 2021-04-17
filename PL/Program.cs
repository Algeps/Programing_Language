using PL.MenuItems;
using System;

namespace PL
{
    class Program
    {
        private static void MenuItems()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("[0] Exit\n[1] Hello World!\n[2] Calc: X % Z + sqrt(Y)\n[3] Recursion date\n[4] Strings");
            Console.WriteLine("==========================\n");
        }

        static void Main(string[] args)//метод Main
        {
            
            bool programIsWorking = true;//execute это что передаётся, откуда вызвано
            int sel_menu = 0;

            while (programIsWorking)
            {
                MenuItems();
                sel_menu = IOUtils.InputNumber(sel_menu);
                switch (sel_menu)
            {
                case 0:
                    programIsWorking = false;
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
                    Console.WriteLine("Erorr! Please, enter item menu! ");
                    break;
                    }
                }
        }
    }
}
