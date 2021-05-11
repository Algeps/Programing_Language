using PL.Validation;
using System;
using System.Text.RegularExpressions;

namespace PL.MenuItems
{
    class MenuItem_TwoStrings : Task
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

                try//сравнение после обработки
                {
                    StringValidation.IsEquals(string1, string2);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//полиндром
                {
                    StringValidation.IsPalindrome(string1, string2);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли емайлом первая строка
                {
                    StringValidation.IsEmail(string1, 1);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли емайлом вторая строка
                {
                    StringValidation.IsEmail(string2, 2);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не явялется ли номером первая строка
                {
                    StringValidation.IsPhoneNumber(string1, 1);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не явялется ли номером вторая строка
                {
                    StringValidation.IsPhoneNumber(string2, 2);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли ip-адресом первая строка
                {
                    StringValidation.IsIP(string1, 1);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try//не является ли ip-адресом вторая строка
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
}
