using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
	public class Product
	{
		#region Fields
		private int id;
		private string name;
		private decimal price;
		#endregion


		#region Constructors
		public Product(int id, string name, decimal price)
		{
			Id = id;
			Name = name;
			Price = price;
		}
		#endregion


		#region Properties
		public int Id
		{
			get => id; 
			private set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				id = value;
			}
		}
		public string Name
		{
			get => name; 
			set
			{
				if (value.Any(c => char.IsDigit(c)))
				{
					throw new ArgumentOutOfRangeException();
				}
				name = value;
			}
		}
		public decimal Price
		{
			get => price; 
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				price = value;
			}
		}
		#endregion


		#region Methods
		public override string ToString()
		{
			return $"Id: {id}\tName: {name}\n\tPrice: {price}\n";
		}
		#endregion
	}
}
