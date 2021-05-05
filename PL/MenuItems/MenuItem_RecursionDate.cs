using System;
using System.Globalization;

namespace PL.MenuItems
{
    class MenuItem_RecursionDate : MenuItem_Core
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            Console.WriteLine("\n------------------------------------------------------");
            Information();
            EnterDate();
            Console.WriteLine("Разница дней: ");
            Console.WriteLine("{0}", GetN());
            PrimeFactorsNumber();
            Console.WriteLine("\n------------------------------------------------------\n");

            DateTime date1;
            DateTime date2;
            DateTime date3;
            DateTime date4;

            void Information()// информация перед вводам дат
            {
                Console.WriteLine("The second date must not be less than the first date!");
                Console.WriteLine("The fourth date must not be less than the second date!");
                Console.WriteLine("Dates are entered in the format \"DD.MM.YYYY\".");
            }

            void EnterDate()//присваивание переменным дат
            {
                date1 = GetDate("\nEnter the first date:");
                date2 = GetDate("Enter the second date:");
                date3 = GetDate("Enter the third date:");
                date4 = GetDate("Enter the fourth date:");
            }

            DateTime GetDate(string message)//функция для заполнения дат
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
                        Console.WriteLine("Error: Incorrect format! Please, enter the date \"DD.MM.YYYY\": ");
                    }
                }
            }

            int GetN()// возвращает разность дней
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

            void PrimeFactorsNumber()//находит все простые множители числа N в порядке не убывания
            {
                int N = GetN();
                
                Console.WriteLine("Простые множители в порядке не убывания: ");
                for (int i = 1; i < (N + 1); i++)
                {
                    bool isPrime = true;
                    for (int k = 2; k < (i - 1); k++)
                    {
                        if (i % k == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime == true)
                    {
                        if (N % i == 0)
                        {
                            Console.Write("{0} ", i);
                        }
                    }
                }
            }
        }
    }
}

