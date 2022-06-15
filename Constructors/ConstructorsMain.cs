using System;

namespace Constructors
{
	class ConstructorsMain
	{
		static void Main(string[] args)
		{
			(DateTime start, DateTime end) interval = (new(2022,4,1), new(2022,4,30));
			double tp = 0.37;
			decimal wh = 160.33m;
			decimal hr = 140m;

			try
			{
				PayCheck p = new(interval: interval, taxProcentage: tp, hoursWorked: wh, hourlyRate: hr);
				Console.WriteLine(p);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
