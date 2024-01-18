using System;
namespace uc2
{
	public class Employee
	{
		public int WagesPerHour;
		public int FUllDayHour;

		public void CalculateDailyWages(int a, int b)
		{
			WagesPerHour = a;
			FUllDayHour = b;
		}
	}
}

