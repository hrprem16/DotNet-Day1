using System;

namespace uc4
{
    class Program
    {

        static void calculateWages()
        {
            int totalHours = 0;
            int Days = 0;

            while (totalHours <= 100 && Days <= 20)
            {
                Random random = new Random();
                int input = random.Next(0, 3);
                if (input == 1) 
                {
                    totalHours += 8;
                    Days++;
                }
                else if (input==2)
                {
                    totalHours += 4;
                    Days++;
                }
                else
                {
                    totalHours += 0;
                    Days += 0;
                }

                Console.WriteLine($"Employee Wages at the end of the days {Days} or totalHour {totalHours} = {totalHours*20} ");
               


            }

        }

        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int value = Convert.ToInt32(input);
            calculateWages();

           

        }
    }
}
