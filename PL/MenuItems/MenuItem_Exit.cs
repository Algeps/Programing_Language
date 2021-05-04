using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.MenuItems
{
    public class MenuItem_Exit : MenuItem_Core
    {
        public override string Title { get { return "Выход";  } } //если мы обращаемся к Title, затем чтобы его получить, мы обращаемся к "Выход"

        public override void Execute()// реализация самого метода
        {
            Console.WriteLine("Выход... ");
            Environment.Exit(0);//Выход из консоли без ошибки
        }
    }
}
