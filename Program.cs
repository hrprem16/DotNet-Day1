using System;
namespace uc4
{
    class Program
    {
        void CalculateWages()
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Employes work {i+1} days ans his wages are {20*8*(i+1)}");
            }
        }

        static void Main(string[] args)
        {
            Program wages = new Program();
           wages.CalculateWages();

            
        }
    }
}