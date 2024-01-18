using System;
namespace uc3
{
    class Program
    {
        static void CalculateWages(int a)
        {
            if (a == 1)
            {
                Console.WriteLine($"Employees Wages are {20*8}");
            }
            else if (a == 2)
            {
                Console.WriteLine($"Employees Wages are {20 * 4}");
            }
            if (a == 0)
            {
                Console.WriteLine($"Employees Wages are {0}");
            }

        }
        static void Main(string[] args)
        {
            //Employee CalculateWages = new Employee();
            //CalculateWages.CalculateDailyWages(20, 8);
            //Console.WriteLine(CalculateWages.WagesPerHour * CalculateWages.FUllDayHour);
            //string input = Console.ReadLine();
            //int value = Convert.ToInt32(input);

            Random random = new Random();
            int value = random.Next(0, 3);
            CalculateWages(value);
        }
    }
}
