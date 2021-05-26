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
            Console.WriteLine("Calc: X % Z + sqrt(Y)");

            int X = IOUtils.SafeReadInteger("Enter X:", new IsNotCorrectInteger());
            int Z = IOUtils.SafeReadInteger("Enter Z:", new IsNotCorrectInteger(), new IsNotZero());
            int Y = IOUtils.SafeReadInteger("Enter Y:", new IsNotCorrectInteger(), new IsNotNaturalIntegerWithZero());

            double rezult = Calc(X, Z, Y);
            Console.WriteLine("{0} % {1} + sqrt({2}) = " + rezult, X, Z, Y);//.ToString("F3")
            Console.WriteLine("-------------------------\n");
        }  
        public double Calc(int X, int Z, int Y)//расчёт формулы
        {
            return Math.Round((Convert.ToDouble(X) % Convert.ToDouble(Z)) + Math.Sqrt(Convert.ToDouble(Y)), 3);
        }
    }
}
