using PL.Validation;
using System;

namespace PL.MenuItems
{
    public class MenuItem_RecursionDate : Task
    {
        public override string Title
        {
            get
            {
                return "Recursion date";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("\n------------------------------------------------------");
            EnterDate(out DateTime Date1, out DateTime Date2, out DateTime Date3, out DateTime Date4);
            int N = GetN(Date1, Date2, Date3, Date4);
            Console.WriteLine("Difference of days:\n{0}", N);
            if (N > 0)
            {
                Console.Write("{0} ", PrimeFactorsNumber(N)); 
            }
            else
            {
                Console.WriteLine("Cannot be calculated for N = 0.");
            }
            Console.WriteLine("\n------------------------------------------------------\n");
        }

        public void EnterDate(out DateTime date1, out DateTime date2, out DateTime date3, out DateTime date4)//присваивание переменным дат
        {
            do//чтобы первая дата не была больше второй
            {
                date1 = IOUtils.SafeReadDate("d1st", "\nEnter the first date:", new IsNotCorrectDate());
                date2 = IOUtils.SafeReadDate("d1end", "Enter the second date:", new IsNotCorrectDate());
                if (date1 > date2)
                {
                    IOUtils.Date1MoreDate2("d1st", "d1end");
                    Console.WriteLine("ERROR! The end date is less than the start date. Repeat the input! ");
                }
            } while (date1 > date2);
            do
            {
                date3 = IOUtils.SafeReadDate("d2st", "Enter the third date:", new IsNotCorrectDate());
                date4 = IOUtils.SafeReadDate("d2end", "Enter the fourth date:", new IsNotCorrectDate());
                if (date3 > date4)
                {
                    IOUtils.Date1MoreDate2("d2st", "d2end");
                    Console.WriteLine("ERROR! The end date is less than the start date. Repeat the input! ");
                }
            } while (date3 > date4);
        }

        public int GetN(DateTime date1, DateTime date2, DateTime date3, DateTime date4)// возвращает разность дней
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
            else if (date2 >= date4 && date1 >= date3)
            {
                n = Convert.ToInt32((date4 - date1).TotalDays) + 1;
            }
            else
            {
                n = 0;
            }
            return n;
        }

        public string PrimeFactorsNumber(int N)//находит все простые множители числа N в порядке не убывания
        {
            string primeFactorsNumber = "";
            Console.WriteLine("Prime factors in non-decreasing order: ");
            //Простые множители в неубывающем порядке:
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
                        primeFactorsNumber += i.ToString() + " ";
                    }
                }
            }
            return primeFactorsNumber;
        }
    }
}

