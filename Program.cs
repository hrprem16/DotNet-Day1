using System;
namespace uc4
{
    class Program
    {
      

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);

            switch(value){
                case 1:
                    Console.WriteLine("Employee Wages are" + (20 * 8));
                    break;
                case 2:
                    Console.WriteLine("Employee Wages are " + (20 * 4));
                    break;
                default:
                    Console.WriteLine("Employee Wages are" + 0);
                    break;

            }
        }
    }
}