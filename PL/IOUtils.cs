using PL.Validation;
using System;
using System.Globalization;

namespace PL
{
    static class IOUtils
    {
        public static int SafeReadInteger(string message, ISpecification<string> specification1 = null, ISpecification<int> specification2 = null)
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
                    try
                    {
                        if (specification1 != null)
                        {
                            specification1.Validate(sValue);
                        }
                    }
                    catch(ValidationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                    
                    try
                    {
                        if (specification2 != null)
                        {
                            specification2.Validate(iValue);
                        }
                        return iValue;
                    }
                    catch (ValidationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                }
            }
        }

        public static DateTime SafeReadDate(string message, ISpecification<string> specification = null)//функция для заполнения дат
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                DateTime date;
                try
                {
                    if (specification != null)
                    {
                        specification.Validate(sValue);
                    }
                    return date = DateTime.ParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None); ;
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
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
