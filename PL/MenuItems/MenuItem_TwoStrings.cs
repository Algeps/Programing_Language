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
            EnterString();
            PrintResults();
            Console.WriteLine("-------------------------\n");

            string string1;
            string string2;
            
            void EnterString()
            {
                string1 = IOUtils.ReadString("Enter the first string: ");
                string2 = IOUtils.ReadString("Enter the second string: ");
            }

            void PrintResults()
            {
                try//сравнение до обработки
                {
                    new StringValidation().IsEquals(string1, string2);
                    Console.WriteLine("\nThe strings are equal. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    new StringValidation().NormalizedStringsAndIsEquals(string1, string2);
                    Console.WriteLine("\nThe strings are equal. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//полиндром
                {
                    new StringValidation().IsPalindrome(string1, string2);
                    Console.WriteLine("These are strings shifters(palindrome). ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли емайлом первая строка
                {
                    new StringValidation().IsEmail(string1, 1);
                    Console.WriteLine("The string 1 does not contain email. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли емайлом вторая строка
                {
                    new StringValidation().IsEmail(string2, 2);
                    Console.WriteLine("The string 2 does not contain email. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не явялется ли номером первая строка
                {
                    new StringValidation().IsPhoneNumber(string1, 1);
                    Console.WriteLine("The string 1 does contain phone number. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не явялется ли номером вторая строка
                {
                    new StringValidation().IsPhoneNumber(string2, 2);
                    Console.WriteLine("The string 2 does contain phone number. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли ip-адресом первая строка
                {
                    new StringValidation().IsIP(string1, 1);
                    Console.WriteLine("The string 1 does contain IP-adress. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли ip-адресом вторая строка
                {
                    new StringValidation().IsIP(string2, 2);
                    Console.WriteLine("The string 2 does contain IP-adress. ");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
