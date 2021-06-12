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

        public static int SafeReadInteger(string paramName, string message, ISpecification<string> specification1 = null, ISpecification<int> specification2 = null)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = GetValue(paramName, message);
                try
                {
                    int iValue = Int32.Parse(sValue);
                    if (specification1 != null)
                    {
                        specification1.Validate(sValue);
                    }
                    if (specification2 != null)
                    {
                        specification2.Validate(iValue);
                    }
                    return iValue;
                }
                catch (Exception ex)
                {
                    if ((ex is ValidationException) ||
                        (ex is OverflowException) ||
                        (ex is FormatException))
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                        if (ExternalValues != null)
                        {
                            throw new InvalidOperationException(ex.Message, ex);
                        }
                    }
                    throw ex;
                }
            }
        }

        private static string GetValue(string paramName, string message)
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
                string sValue = GetValue(paramName, message);
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
                    Console.WriteLine("ERROR: " + ex.Message);
                    if (ExternalValues != null)
                    {
                        throw new InvalidOperationException(ex.Message, ex);
                    }
                }
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
                string sValue = Console.ReadLine();
                return sValue;
            }
        }
    }
}
