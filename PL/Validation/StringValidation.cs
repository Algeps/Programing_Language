using System;
using System.Text.RegularExpressions;

namespace PL.Validation
{
    public class StringValidation
    {
        public void IsEquals(string string1, string string2)//сравнивает сроки
        {
            if (!string1.Equals(string2))
            {
                throw new ValidationException("The strings are not equal. ");
            }
        }

        public void NormalizedStringsAndIsEquals(string string1, string string2)
        {
            string1 = string1.Trim().ToLower();
            string1 = string1?.Replace(" ", "");

            string2 = string2.ToLower().Trim();
            string2 = string2?.Replace(" ", "");

            Console.WriteLine("The strings are reduced to the same case, the spaces at the beginning and end are removed, and the duplication of spaces is also removed.");
            //Строки приведены к одному регистру, удалены пробелы в начале в конце, а также убрано дублирование пробелов.

            if (!string1.Equals(string2))
            {
                throw new ValidationException("The strings are not equal. ");
            }
        }

        public void IsPalindrome(string str1, string str2)//проверяет, являются ли они палиндромами
        {
            char[] charArr = str1.ToCharArray();
            Array.Reverse(charArr);//создаётся и заносится в массив, элементы с обратным расположением
            if (!str2.Equals(new string(charArr)))
            {
               throw new ValidationException("These strings are not shifters(palindrome). ");
            }
        }

        public void IsEmail(string str, int number)//проверяет, содержит ли строчка email
        {
            if (!Regex.IsMatch(str, "[^@ \t\r\n]+@[^@ \t\r\n]+\\.[^@ \t\r\n]+"))
            {
                string message = "The string " + number + " does not contain email. ";
                throw new ValidationException(message);
            }
        }

        public void IsPhoneNumber(string str, int number)//проверяет, содержит ли строчка телефонный номер
        {
            if (!Regex.IsMatch(str, "[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}"))
            {
               string message = "The string " + number + " does not contain phone number. ";
               throw new ValidationException(message);
            }
        }

        public void IsIP(string str, int number)//проверяет, содержит ли строка IP-адрес
        {
            if (!Regex.IsMatch(str, "(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}"))
            {
               string message = "The string " + number + " does not contain IP-adress. ";
               throw new ValidationException(message);
            }
        }
    }
}
