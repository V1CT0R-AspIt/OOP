using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	class Subject
	{
		#region Fields
		private string name;
		private string code;
		private string teacher;
		private int ects;
		private DateTime startdate;
		private DateTime enddate;
		private DateTime examdate;
		private readonly DateTime MINIMUM = new(1900, 01, 01);
		#endregion



		#region Properties
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("ERROR. Please Enter A Name.");
				}
				else if (value.Length < 4)
				{
					throw new ArgumentException("ERROR Your Name Is To Short. Please Try Again.");
				}
				name = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("ERROR. Please Enter A ColorCode.");
				}
				else if (char.IsLower(value[0]) ||
					char.IsLower(value[1]) ||
					char.IsLower(value[2])
					)
				{
					throw new ArgumentException("ERROR. 1 Or More Of The First 3 Letters Is Small. Please Try Again.");
				}
				else if (char.IsLetter(value[4]) ||
					char.IsLetter(value[5]) ||
					char.IsLetter(value[6])
					)
				{
					throw new ArgumentException("ERROR. 1 Or More Of The Last 3 Digits Is Not A Digit. Please Try Again.");
				}
				else if (value[4] == '0' || value[4] == 0)
				{
					throw new ArgumentException("ERROR. The First Digit Cannot Be 0. Please Try Again.");
				}
				code = value;
			}
		}

		public string Teacher
		{
			get
			{
				return teacher;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("ERROR.Please Enter A Name.");
				}
				else if (value.Any(c => Char.IsDigit(c)))
				{
					throw new ArgumentException("ERROR. Letters Only. Please Try Again.");
				}
				teacher = value;
			}
		}

		public int ECTS
		{
			get
			{
				return ects;
			}
			set
			{
				if (value < 0 || value > 10)
				{
					throw new ArgumentException("ERROR. How The F#@k Did You Manage This?. Please Try Again.");
				}
				ects = value;
			}
		}

		public DateTime StartDate
		{
			get
			{
				return startdate;
			}
			set
			{
				if (value > DateTime.Today)
				{
					throw new ArgumentException("ERROR. Are You From The Future?. Please Try Again.");
				}
				else if (value < MINIMUM)
				{
					throw new ArgumentException("ERROR. Are You Even Born Yet?. Please Try Again.");
				}
				startdate = value;
			}
		}

		public DateTime EndDate
		{
			get
			{
				return enddate;
			}
			set
			{
				if (value > DateTime.Today)
				{
					throw new ArgumentException("ERROR. Are You From The Future?. Please Try Again.");
				}
				else if (value < startdate)
				{
					throw new ArgumentException("ERROR. Are You Even Born Yet?. Please Try Again.");
				}
				enddate = value;
			}
		}

		public DateTime ExamDate
		{
			get
			{
				return examdate;
			}
			set
			{
				if (value > EndDate)
				{
					throw new ArgumentException("ERROR. Are You From The Future?. Please Try Again.");
				}
				else if (value < StartDate)
				{
					throw new ArgumentException("ERROR. Are You Even Born Yet?. Please Try Again.");
				}
				examdate = value;
			}
		}
		#endregion



		#region Methods
		public TimeSpan ExamDuration()
		{
			return EndDate - StartDate;
		}

		public TimeSpan DaysTilExam()
		{
			return ExamDate - DateTime.Now;
		} 
		#endregion
	}
}
