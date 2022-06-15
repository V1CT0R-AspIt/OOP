using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
	class AggregationMain
	{
		static void Main(string[] args)
		{
			Product p = new(12, "Mads", 32.64m);
			Product p2 = new(24, "Emil", 24.48m);
			Product p3 = new(32, "Midas", 12.8m);

			List<Product> pList = new List<Product>();
			pList.Add(p);
			pList.Add(p2);
			pList.Add(p3);

			ContactInfo C = new(69, "info@Ølbutikken.dk", "20459995");
			Supplier supplier = new(32, "Steve", C, pList);

			ContactInfo c = new(69, "info@Ølbutikken.dk", "20459995");
			ContactInfo c2 = new(96, "info@YaHoo.dk", "69696969");
			ContactInfo c3 = new(420, "info@Outlook.dk", "69420360");

			ContactInfo c4 = new(420, "info@Nintendo.dk", "69420360");
			ContactInfo c5 = new(420, "info@Steam.dk", "69420360");
			ContactInfo c6 = new(420, "info@YouTube.dk", "69420360");

			Supplier s = new(32, "ølbutikken", c);
			Supplier s2 = new(12, "YaHoo", c2);
			Supplier s3 = new(24, "Outlook", c3);

			Supplier s4 = new(24, "Gamil", null);
			Supplier s5 = new(24, "Hotmail", null);
			Supplier s6 = new(24, "AAAAAHH", null);

			s4.ContactInfo = c4;
			s5.ContactInfo = c5;
			s6.ContactInfo = c6;


			Console.WriteLine(p);
			Console.WriteLine(p2);
			Console.WriteLine(p3);
			Console.WriteLine(c);
			Console.WriteLine(c2);
			Console.WriteLine(c3);
			Console.WriteLine(c4);
			Console.WriteLine(c5);
			Console.WriteLine(c6);
			Console.WriteLine(pList[0]);
			Console.WriteLine(pList[1]);
			Console.WriteLine(pList[2]);
			Console.WriteLine(supplier.GetNumberOfProducts());
		}
	}
}
