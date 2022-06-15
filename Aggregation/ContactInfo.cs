using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
	public class ContactInfo
	{
		#region Fields
		private int id;
		private string mail;
		private string phoneNumber;
		#endregion


		#region Constructors
		public ContactInfo(int id, string mail, string phoneNumber)
		{
			Id = id;
			Mail = mail;
			PhoneNumber = phoneNumber;
		}
		#endregion


		#region Properties
		public int Id
		{
			get => id;
			private set
			{
				//validate id
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				id = value;
			}
		}
		public string Mail
		{
			get => mail; 
			set
			{
				mail = value;
			}
		}
		public string PhoneNumber
		{
			get => phoneNumber;
			set
			{
				if (!value.Any(d => char.IsDigit(d)))
				{
					throw new ArgumentOutOfRangeException("ERROR. Not a viable phone number. please try again");
				}
				phoneNumber = value;
			}
		}
		#endregion


		#region Methods
		public override string ToString()
		{
			return $"Id: {id}\tMail: {mail}\n\tPhone No. {phoneNumber}\n";
		}
		#endregion
	}
}
