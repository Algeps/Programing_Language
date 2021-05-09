using System;

namespace PL.MenuItems
{
    public class MenuItem_Exit : Task
    {
        public override string Title { get { return "Exit";  } } //если мы обращаемся к Title, затем чтобы его получить, мы обращаемся к "Выход"

        public override void Execute()// реализация самого метода
        {
            Console.WriteLine("Exit... ");
            Environment.Exit(0);//Выход из консоли без ошибки
        }
    }
}
