using System;

namespace Basics
{
	class BasicsMain
	{
		static void Main(string[] args)
		{
			Person p = new();
			p.FirstName = "Karl";
			p.LastName = "Hansen";
			p.BirthDate = new DateTime(1946, 01, 02);
			p.Height = 184;
			p.Weight = 72;

			string output = p.GetFullName();
			Console.WriteLine(output);

			string initials = p.GetInitials();
			Console.WriteLine(initials.ToUpper());

			int age = p.GetAgeToday();
			Console.WriteLine(age);

			bool TrueFalse = p.IsOlderThan(32);
			Console.WriteLine(TrueFalse);

			DateTime date = new DateTime(1989, 01 ,02);
			int ageACT = p.GetAgeAt(date);
			Console.WriteLine(ageACT);

			double bmi = Math.Round(p.GetBmi(), 2);
			Console.WriteLine(bmi);

			string bmiinfo = p.BmiDescription();
			Console.WriteLine(bmiinfo);

			string narrator = p.Narrator();
			Console.WriteLine(narrator);
		}
	}
}
