using System;

namespace PL
{
    class IOUtils
    {
        private static int CheckNumber(int value)//проверка, что введена цыфра
        {
            if (!string.IsNullOrEmpty(""))
            {
                Console.Write("");
            }

            while (!int.TryParse(Console.ReadLine(), out value))//Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
            {
                Console.WriteLine("ERORR: Please enter correct value! ");
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
                 Console.WriteLine("ERROR: Please enter ONLY POSITIVE number! ");
             }
             return value;
         }

         public static int CheckOnlyNaturalNumber(int value)//проверка на натуральные значения
         {
              while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
              {
                  Console.WriteLine("ERROR: Please enter ONLY NATURAL number! ");
              }
              return value;
         }
    }
}
