using System;
namespace uc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CalculateWages = new Employee();
            CalculateWages.CalculateDailyWages(20,8);
            Console.WriteLine(CalculateWages.WagesPerHour * CalculateWages.FUllDayHour);
        }
    }
}