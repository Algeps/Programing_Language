using System;

namespace PL.MenuItems
{
    public class MenuItem_Formula : Task
    {
        public override string Title
        {
            get
            {
                return "Calc: X % Z + sqrt(Y)";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Calc: X % Z + sqrt(Y)"); 
            Console.WriteLine("X % Z + sqrt(Y) = " + FormulCalc());
            Console.WriteLine("-------------------------\n");

            string FormulCalc()//расчёт формулы
            {
                int X = IOUtils.SafeReadInteger("Enter X:");
                int Z = IOUtils.SafeReadNaturalInteger("Enter Z:");
                int Y = IOUtils.SafeReadPositiveInteger("Enter Y:");
                double rezult = ((X % Z) + Math.Sqrt(Y));
                return rezult.ToString("F3");//преобразует число в строку(F3 - Строка числового формата, выводит человеческий слитный вывод 3 знаков после запятой)
            }
        }
    }
}
