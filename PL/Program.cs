using PL.MenuItems;
using System;
using System.Collections.Generic;

namespace PL
{
    class Program
    {
        static void Main(string[] args)//главный метод программы
        {
            IDictionary<string, string> argsDic = CmdArgsParser.Parse(args);
            IOUtils.SetExtValues(CmdArgsParser.Parse(args));

            Menu.ClearItems();
            Menu.AddItem(new MenuItem_Exit());//сюда добавлять новые пункты меню
            Menu.AddItem(new MenuItem_HelloWorld());
            Menu.AddItem(new MenuItem_Calc());
            Menu.AddItem(new MenuItem_RecursionDate());
            Menu.AddItem(new MenuItem_TwoStrings());

            if (argsDic != null)
            {
                try
                {
                    Menu.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("ERROR! " + ex.Message);
                }
            }
            else
            {
                while (true)
                {
                    Menu.ShowMenu();
                    Menu.Execute();
                }
            }
        }
    }    
}
