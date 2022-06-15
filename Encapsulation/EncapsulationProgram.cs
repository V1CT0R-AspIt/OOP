using System;

namespace Encapsulation
{
	class EncapsulationProgram
	{
		static void Main(string[] args)
		{
			Subject S = new();
			try
			{
				S.Name = "s22345";
				S.Code = "EAS-420";
				S.Teacher = "Mads Mikkelsen";
				S.ECTS = 5;
				S.StartDate = new(2021, 05, 12);
				S.EndDate = new(2021, 06, 12);
				S.ExamDate = new(2021, 05, 24);
			}
			catch(ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}

			Console.WriteLine(S.Name);
			Console.WriteLine(S.Code);
			Console.WriteLine(S.Teacher);
			Console.WriteLine(S.ECTS);
			Console.WriteLine(S.StartDate);
			Console.WriteLine(S.EndDate);
			Console.WriteLine(S.ExamDate);
		}
	}
}
