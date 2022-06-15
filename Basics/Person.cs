using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public double Height { get; set; }
		public double Weight { get; set; }
		public int MonthNumber { get; set; }

		public string GetFullName()
		{
			return $"{FirstName} {LastName}";
		}

		public string GetInitials()
		{
			return $"{FirstName.Substring(0,2)}{LastName.Substring(0,2)}";
		}
		public int GetAgeToday()
		{
			return DateTime.Now.Year -BirthDate.Year;
		}
		public bool IsOlderThan(int age)
		{
			if (GetAgeToday() > age)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public int GetAgeAt(DateTime date)
		{
			return date.Year -BirthDate.Year;
		}
		public double GetBmi()
		{
			double bmi = Weight / Height / Height * 10000;
			return bmi;
		}
		public string BmiDescription()
		{
			string bmiinfo = "Under 18,5 | Undervægtigt\n18,5-24,9  | Normal vægt\n25-29,9    | Præ-fedme\n30-34,9    | Fedme klasse I\n35-39,9    | Fedme klasse II\nOver 40    | Fedme klasse III";
			return bmiinfo;
		}
		public string GetMonthName()
		{
			string monthname = "";
			switch (MonthNumber)
			{
				case 1:
					monthname = "Januar";
					break;
				case 2:
					monthname = "Februar";
					break;
				case 3:
					monthname = "Marts";
					break;
				case 4:
					monthname = "April";
					break;
				case 5:
					monthname = "Maj";
					break;
				case 6:
					monthname = "Juni";
					break;
				case 7:
					monthname = "Juli";
					break;
				case 8:
					monthname = "August";
					break;
				case 9:
					monthname = "September";
					break;
				case 10:
					monthname = "Oktober";
					break;
				case 11:
					monthname = "November";
					break;
				case 12:
					monthname = "December";
					break;
				default:
					monthname = "Invalid Input";
					break;
			}
			return monthname;
		}
		public string Narrator()
		{
			
			DateTime rndyear = new DateTime(1989, 01, 02);
			return $"{GetFullName()} blev født den {BirthDate.Day}. {} {BirthDate.Year} og er i dag den {DateTime.Now.Day}. {} {DateTime.Now.Year} {GetAgeToday()} år gammel. {GetFullName()} var {GetAgeAt(rndyear)} år i {rndyear.Year} og har et BMI på {Math.Round(GetBmi(), 2)}.";
		}
	}
}
