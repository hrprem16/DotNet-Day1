using System;
//using project2;

namespace uc1
{
    class Program
    {
        static void checkAttendance(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("Employess is Present");
            }
            else if(a==0)
            {
                Console.WriteLine("Employess is Absent");
            }
            else
            {
                Console.WriteLine("Invalid Input for Attendance");
            }
        }


        static void Main(string[] args)
        {
            //string inputAttnd = Console.ReadLine();
            //int input = Convert.ToInt32(inputAttnd);
            //checkAttendance(input);

            Random random = new Random();
            int value = random.Next(0, 2);
            checkAttendance(value);

        }





    }


}
