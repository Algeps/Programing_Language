using System;
using System.Globalization;

namespace PL
{
    static class IOUtils
    {
        public static int SafeReadInteger(string message)//для безопасного чтения меню
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
                //ОШИБКА: Неверный формат! Введите целочисленную переменную...
            }
        }

         public static int SafeReadPositiveInteger(string message)//проверка на положительное значения
         {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue) && iValue >= 0)
                {
                    return iValue;
                }
                Console.WriteLine("ERROR: Enter only a positive number! ");
                //ОШИБКА: Введите только положительное число!
            }
        }

         public static int SafeReadNaturalInteger(string message)//проверка на натуральные значения
         {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue) && iValue >= 1)
                {
                    return iValue;
                }
                Console.WriteLine("ERROR: Enter only a natural number! ");
                //ОШИБКА: Введите только натуральное число!
            }
         }

        public static DateTime SafeReadDate(string message)//функция для заполнения дат
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParseExact(sValue, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("Error: Incorrect format! Please, enter the date \"DD.MM.YYYY\": ");
                }
            }
        }

        public static string ReadString(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                return sValue;
            }
        }
    }
}
