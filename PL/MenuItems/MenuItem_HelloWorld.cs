using System;

namespace PL.MenuItems
{
    public class MenuItem_HelloWorld : Task
    {
        public override string Title
        {
            get
            {
                return "Hello World!";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Hello World!");
            Console.WriteLine("-------------------------\n");
        }
    }
}
