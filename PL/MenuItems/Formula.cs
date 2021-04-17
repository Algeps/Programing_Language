using System;

namespace PL.MenuItems
{
    class Formula
    {
        public static void _Formula()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("X % Z + sqrt(Y) = " + Formula.FormulCalc());
            Console.WriteLine("-------------------------\n");
        }

        private static string FormulCalc()//расчёт формулы
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
