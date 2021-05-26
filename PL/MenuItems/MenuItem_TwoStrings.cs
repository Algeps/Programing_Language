using PL.Validation;
using System;

namespace PL.MenuItems
{
    public class MenuItem_TwoStrings : Task
    {
        public override string Title
        {
            get
            {
                return "Strings";
            }
        }

        public override void Execute() 
        {
            Console.WriteLine("\n-------------------------");
            EnterString(out string string1, out string string2);
            PrintResults(string1, string2);
            Console.WriteLine("-------------------------\n");
        }

        void EnterString(out string _string1, out string _string2)
        {
            _string1 = IOUtils.ReadString("Enter the first string: ");
            _string2 = IOUtils.ReadString("Enter the second string: ");
        }

        void PrintResults(string _string1, string _string2)
        {
            try//сравнение до обработки
            {
                new StringValidation().IsEquals(_string1, _string2);
                Console.WriteLine("\nThe strings are equal. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                new StringValidation().NormalizedStringsAndIsEquals(_string1, _string2);
                Console.WriteLine("\nThe strings are equal. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//полиндром
            {
                new StringValidation().IsPalindrome(_string1, _string2);
                Console.WriteLine("These are strings shifters(palindrome). ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//не является ли емайлом первая строка
            {
                new StringValidation().IsEmail(_string1, 1);
                Console.WriteLine("The string 1 does not contain email. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//не является ли емайлом вторая строка
            {
                new StringValidation().IsEmail(_string2, 2);
                Console.WriteLine("The string 2 does not contain email. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//не явялется ли номером первая строка
            {
                new StringValidation().IsPhoneNumber(_string1, 1);
                Console.WriteLine("The string 1 does contain phone number. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//не явялется ли номером вторая строка
            {
                new StringValidation().IsPhoneNumber(_string2, 2);
                Console.WriteLine("The string 2 does contain phone number. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//не является ли ip-адресом первая строка
            {
                new StringValidation().IsIP(_string1, 1);
                Console.WriteLine("The string 1 does contain IP-adress. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try//не является ли ip-адресом вторая строка
            {
                new StringValidation().IsIP(_string2, 2);
                Console.WriteLine("The string 2 does contain IP-adress. ");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
