using System;
using PL.Validation;
using System.Text.RegularExpressions;

namespace PL.MenuItems
{
    class TwoString
    {
        string string1;
        string string2;

        public void _TwoString()
        {
            Console.WriteLine("\n-------------------------");
            EnterString();
            PrintResults();
            Console.WriteLine("-------------------------\n");
        }
        
        private void EnterString()
        {
            Console.WriteLine("Enter the first string: ");
            string1 = Console.ReadLine();
            Console.WriteLine("Enter the second string: ");
            string2 = Console.ReadLine();
        }

        private void PrintResults()
        {
            try
            {
                StringValidation.IsEquals(string1, string2);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string1 = string1.Trim().ToLower();
            string1 = Regex.Replace(string1, @"\s+", " ");

            string2 = string2.Trim().ToLower();
            string2 = Regex.Replace(string2, @"\s+", " ");

            Console.WriteLine("The strings are reduced to the same case, the spaces at the beginning and end are removed, and the duplication of spaces is also removed.");
            //Строки приведены к одному регистру, удалены пробелы в начале в конце, а также убрано дублирование пробелов.

            try
            {
                StringValidation.IsEquals(string1, string2);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsPalindrome(string1, string2);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsEmail(string1, 1);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsEmail(string2, 2);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsPhoneNumber(string1, 1);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsPhoneNumber(string2, 2);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsIP(string1, 1);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                StringValidation.IsIP(string2, 2);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
