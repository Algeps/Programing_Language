using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    class IOUtils
    {
        
            public static void Value_Error()//вывод ошибки
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("ERORR: Please enter correct value!");
                Console.WriteLine("-------------------------\n");
            }

            private static int CheckNumber(int value)//проверка, что введена цыфра
            {
                while (!int.TryParse(Console.ReadLine(), out value))//Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
                {
                    Value_Error();
                }
                return value;
            }

            public static int InputNumber(int value)//ввод цыфры
            {
                value = CheckNumber(value);
                return value;
            }

            public static int CheckOnlyPositiveNumber(int value)//проверка на положительное значения
            {
                while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("ERORR: Please enter ONLY POSITIVE number! ");
                    Console.WriteLine("-------------------------\n");
                }
                return value;
            }

            public static int CheckOnlyNaturalNumber(int value)//проверка на натуральные значения
            {
                while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
                {
                    Console.WriteLine("\n-------------------------");
                    Console.WriteLine("ERORR: Please enter ONLY NATURAL number! ");
                    Console.WriteLine("-------------------------\n");
                }
                return value;
            }
        
    }
}
