using PL.Validation;
using System;

namespace PL.MenuItems
{
    public class MenuItem_Calc : Task
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

            int X = IOUtils.SafeReadInteger("x", "Enter X:", null);
            int Z = IOUtils.SafeReadInteger("z", "Enter Z:", new IsNotZero());
            int Y = IOUtils.SafeReadInteger("y", "Enter Y:", new IsNotNaturalIntegerWithZero());

            double rezult = Calc(X, Z, Y);
            Console.WriteLine("{0} % {1} + sqrt({2}) = " + rezult, X, Z, Y);
            Console.WriteLine("-------------------------\n");
        }  
        public double Calc(int X, int Z, int Y)//расчёт формулы
        {
            return Math.Round((Convert.ToDouble(X) % Convert.ToDouble(Z)) + Math.Sqrt(Convert.ToDouble(Y)), 3);
        }
    }
}
