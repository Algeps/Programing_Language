using System;
using PL.MenuItems;

namespace PL
{
    class Menu
    {
        public static void _Menu()
        {
            bool programIsWorking = true;
            int sel_menu = 0;

            while (programIsWorking)
            {
                Console.WriteLine("\n==========================");
                Console.WriteLine("[0] Exit\n[1] Hello World!\n[2] Calc: X % Z + sqrt(Y)\n[3] Recursion date ");
                Console.WriteLine("==========================\n");
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
                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine("X % Z + sqrt(Y) = " + Formula.FormulCalc());
                        Console.WriteLine("-------------------------\n");
                        break;
                    case 3:
                        //Console.WriteLine("\n-------------------------");
                        new RecursionDate().Recursion_Date();
                        Console.WriteLine("-------------------------\n");
                        break;
                    default:
                        IOUtils.Value_Error();
                        break;
                }
            }
        }
    }
}
