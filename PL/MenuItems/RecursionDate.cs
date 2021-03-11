using System;
using System.Globalization;


namespace PL
{
    class RecursionDate//(Вывести на экран всем простые множители числа в порядке не убывания.)
    {
        private DateTime date1;
        private DateTime date2;
        private DateTime date3;
        private DateTime date4;

        public void Recursion_Date()// вызывает поледовательно методы
        {
            Information();
            EnterDate();


            string list = PrimeFactorsNumber();
        }

        private void Information()// информация перед вводам дат
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("The second date must not be less than the first date!");
            Console.WriteLine("The fourth date must not be less than the second date!");
            Console.WriteLine("Dates are entered in the format \"DD.MM.YYYY\".");    
            Console.WriteLine("-------------------------\n");
        }

        private void EnterDate()//присваивание переменным дат
        {
            Console.WriteLine("\n-------------------------");
            date1 = GetDate("Enter the first date:");
            date2 = GetDate("Enter the second date:");
            date3 = GetDate("Enter the third date:");
            date4 = GetDate("Enter the fourth date:");
            Console.WriteLine("-------------------------\n");
        }

        private DateTime GetDate(string message)
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
                    ErorrEnterDate();
                }
            }
        }

        private int GetN()// возвращает разность дней
        {
            int n;

            if (date1 >= date4 && date2 >= date3 && date4 >= date1)
            {
                n = Convert.ToInt32((date4 - date1).TotalDays) + 1;
            }
            else if (date2 >= date4 && date3 >= date1)
            {
                n = Convert.ToInt32((date4 - date3).TotalDays) + 1;
            }
            else if (date4 >= date2 && date3 >= date1 && date2 >= date3)
            {
                n = Convert.ToInt32((date2 - date3).TotalDays) + 1;
            }
            else if (date4 >= date2 && date1 >= date3)
            {
                n = Convert.ToInt32((date2 - date1).TotalDays) + 1;
            }
            else
            {
                n = 0;
            }
            return n;

        }

        private void ErorrEnterDate()//вызывается, если дата введена неверно
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Error: Incorrect format! ");
            Console.Write("Please, enter the date \"DD.MM.YYYY\": ");
        }

        private string PrimeFactorsNumber()//находит все простые множители числа в порядке не убывания
        {
            string list = "";
            int N = GetN();
            Console.WriteLine("{0}", N);
            do
            {
                /*if (N mod 2)
                {

                }*/
            } while (N >= 1);

            return list;
        }
    }
}
