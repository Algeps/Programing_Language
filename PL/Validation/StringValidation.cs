using System;
using System.Text.RegularExpressions;

namespace PL.Validation
{
    public class StringValidation
    {
        public static void IsEquals(string string1, string string2)//сравнивает сроки
        {
            if (string1.Equals(string2))
            {
                Console.WriteLine("\nThe strings are equal. ");
            }
            else
            {
                throw new ValidationException("The strings are not equal. ");
            }
        }

        public static void IsPalindrome(string str1, string str2)//проверяет, являются ли они палиндромами
        {
            char[] charArr = str1.ToCharArray();
            Array.Reverse(charArr);//создаётся и заносится в массив, элементы с обратным расположением
            if (str2.Equals(new string(charArr)))
            {
                Console.WriteLine("These are strings shifters(palindrome). ");
            }
            else
            {
                throw new ValidationException("These strings are not shifters(palindrome). ");
            }
        }

        public static void IsEmail(string str, int number)//проверяет, содержит ли строчка email
        {
            if (Regex.IsMatch(str, "[^@ \t\r\n]+@[^@ \t\r\n]+\\.[^@ \t\r\n]+"))
            {
                Console.WriteLine("The string {0} does not contain email. ", number);
            }
            else
            {
                string message = "The string " + number + " does not contain email. ";
                throw new ValidationException(message);
            }
        }

        public static void IsPhoneNumber(string str, int number)//проверяет, содержит ли строчка телефонный номер
        {
            if (Regex.IsMatch(str, "[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}"))
            {
                Console.WriteLine("The string {0} does contain phone number. ", number);
            }
            else
            {
                string message = "The string " + number + " does not contain phone number. ";
                throw new ValidationException(message);
            }
        }

        public static void IsIP(string str, int number)//проверяет, содержит ли строка IP-адрес
        {
            if (Regex.IsMatch(str, "(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}"))
            {
                Console.WriteLine("The string {0} does contain IP-adress. ", number);
            }
            else
            {
                string message = "The string " + number + " does not contain IP-adress. ";
                throw new ValidationException(message);
            }
        }
    }
}
