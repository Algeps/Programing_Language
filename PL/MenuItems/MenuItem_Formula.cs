using System;

namespace PL.MenuItems
{
    public class MenuItem_Formula : MenuItem_Core
    {
        public override string Title { get { return "Calc: X % Z + sqrt(Y)"; } }

        public override void Execute()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("X % Z + sqrt(Y) = " + FormulCalc());
            Console.WriteLine("-------------------------\n");

            string FormulCalc()//расчёт формулы
            {
                int X = 0, Y = 0, Z = 0;
                Console.WriteLine("Enter X:");
                X = IOUtils.InputNumber(X);
                Console.WriteLine("Enter Y:");
                Y = IOUtils.CheckOnlyPositiveNumber(Y);
                Console.WriteLine("Enter Z:");
                Z = IOUtils.CheckOnlyNaturalNumber(Z);
                double rezult = ((X % Z) + Math.Sqrt(Y));
                return rezult.ToString("F3");//преобразует число в строку(F3 - Строка числового формата, выводит человеческий слитный вывод 3 знаков после запятой)
            }
        }
    }
}
