﻿using System;

namespace PL
{
    static class IOUtils
    {
        public static int SafeReadInteger(string message)//для безопасного чтения
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                {
                    return iValue;
                }
                Console.WriteLine("ERROR: Invalid format! Enter an integer variable...  ");
            }
        }

        private static int CheckNumber(int value)//проверка, что введена цыфра
        {
            if (!string.IsNullOrEmpty(""))
            {
                Console.Write("");
            }

            while (!int.TryParse(Console.ReadLine(), out value))//Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
            {
                Console.WriteLine("ERORR: Invalid format! Enter corret value! ");
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
                 Console.WriteLine("ERROR: Enter only a positive number! ");
             }
             return value;
         }

         public static int CheckOnlyNaturalNumber(int value)//проверка на натуральные значения
         {
              while (!int.TryParse(Console.ReadLine(), out value) || value < 1)
              {
                  Console.WriteLine("ERROR: Enter only a natural number! ");
              }
              return value;
         }
    }
}
