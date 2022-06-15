using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	class PayCheck
	{
		#region Fields
		private (DateTime start, DateTime end) interval;
		private double taxProcentage;
		private decimal hoursWorked;
		private decimal hourlyRate;
		#endregion


		#region Constants
		private readonly DateTime minimumIntervalDate = new(2000, 1, 1);
		private readonly DateTime maximumIntervalDate = new(2050, 1, 1); 
		#endregion


		#region Constructors
		public PayCheck((DateTime start, DateTime end) interval, double taxProcentage, decimal hoursWorked, decimal hourlyRate)
		{
			Interval = interval;
			TaxProcentage = taxProcentage;
			HoursWorked = hoursWorked;
			HourlyRate = hourlyRate;
		} 
		#endregion


		#region Properties
		public (DateTime start, DateTime end) Interval
		{
			get => interval;
			set
			{
				//extract tuple elements:
				DateTime start = value.start;
				DateTime end = value.end;
				//validate min and max:
				if(start < minimumIntervalDate)
				{
					throw new ArgumentOutOfRangeException("Start date is too early");
				}
				else if (end > maximumIntervalDate)
				{
					throw new ArgumentOutOfRangeException("End date is too late");
				}
				else if (end < start)
				{
					throw new ArgumentOutOfRangeException("End is earlier than you think");
				}
				//validate business rules:
				if(start.Date.AddDays(13) == end.Date) // 14 days salary
				{
					if(start.DayOfWeek == DayOfWeek.Monday)
					{
						interval = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException("14 Day interval does not start on a monday");
					}
				}
				else //monthly
				{
					if (start.Day != 1)
					{
						throw new ArgumentOutOfRangeException("First day of provided monthly interval is not day 1 of that month");
					}
					else
					{
						int daysinmonth = DateTime.DaysInMonth(start.Year, start.Month);
						if(start.AddDays(daysinmonth-1) != end.Date)
						{
							throw new ArgumentOutOfRangeException("End date must be the last date in the month of the start date");
						}
						else
						{
							interval = value;
						}
					}
				}
			}
		}

		public double TaxProcentage
		{
			get => taxProcentage;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("Pay your fucking taxes.");
				}
				taxProcentage = value;
			}
		}

		public decimal HoursWorked
		{
			get => hoursWorked;
			set
			{
				if (value < 1)
				{
					throw new ArgumentOutOfRangeException("Get off your lazy ass.");
				}
				hoursWorked = value;
			}
		}

		public decimal HourlyRate
		{
			get => hourlyRate;
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("Get a job.");
				}
				hourlyRate = value;
			}
		}
		#endregion


		#region Methods
		public decimal GetGrossSalary()
		{
			return HoursWorked * HourlyRate;
		}

		public decimal GetNetSalary()
		{
			return GetGrossSalary() - GetTaxAmount();
		}

		public decimal GetTaxAmount()
		{
			return GetGrossSalary() * (decimal)TaxProcentage;
		}
		public override string ToString()
		{
			return $"Gross:\t{GetGrossSalary():c2}\nNet:\t{GetNetSalary():c2}\nTax:\t{GetTaxAmount():c2}";
		}
		#endregion
	}
}
