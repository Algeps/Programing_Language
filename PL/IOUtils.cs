using PL.Validation;
using System;
using System.Collections.Generic;

namespace PL
{
    public static class IOUtils
    {
        private static IDictionary<string, string> ExternalValues = null;

        public static void SetExtValues(IDictionary<string, string> values)
        {
            ExternalValues = values;
        }

        public static int SafeReadInteger(string paramName, string message, ISpecification<int> specification = null)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {   
                string sValue = GetValue(paramName);
                try
                {
                    int iValue = Int32.Parse(sValue);
                    if (specification != null)
                    {
                        specification.Validate(iValue);
                    }
                    return iValue;
                }
                catch (Exception ex)
                {
                    if ((ex is ValidationException) ||
                        (ex is OverflowException) ||
                        (ex is FormatException))
                    {
                        if(ExternalValues != null)
                        {
                            ErrorArg(paramName);
                            throw new InvalidOperationException(ex.Message, ex);
                        }
                        else
                        {
                            Console.WriteLine("ERROR! " + ex.Message);
                            Console.WriteLine("Enter the correct integer: ");
                        }
                    }
                }
            }
        }

        private static void ErrorArg(string integerName)//указывает какой именно аргумент набран неправильно 
        {
            Console.Write("Argument {0}: ", integerName);
        }

        private static string GetValue(string paramName)
        {
            string sValue = null;
            if (ExternalValues == null)
            {
                sValue = Console.ReadLine();
            }
            else
            {
                if (!ExternalValues.TryGetValue(paramName, out sValue))
                {
                    throw new InvalidOperationException(string.Format("Parameter -{0} not specify.", paramName));
                }
            }
            return sValue;
        }

        public static DateTime SafeReadDate(string paramName, string message, ISpecification<string> specification = null)//функция для заполнения дат
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = GetValue(paramName);
                DateTime date;
                try
                {
                    if (specification != null)
                    {
                        specification.Validate(sValue);
                    }
                    return date = DateTime.ParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None); ;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("ERROR! " + ex.Message);
                    if (ExternalValues != null)
                    {
                        throw new InvalidOperationException(ex.Message, ex);
                    }
                }
            }
        }

        public static void Date1MoreDate2(string date1, string date2)
        {
            if(ExternalValues != null)
            {
                Console.WriteLine("ERROR! {0} more {1}! ", date1, date2);
                Environment.Exit(0);
            }
        }

        public static string ReadString(string paramName, string message)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = GetValue(paramName);
                return sValue;
            }
        }
    }
}
