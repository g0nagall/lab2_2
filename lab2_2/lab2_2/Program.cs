using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Type x");
			double x = double.Parse(Console.ReadLine());
			double a = 3, c = 5, b = 4, d = 6;
			double result1 = Math.Tan(x / 7 * +a) - Math.Log(Math.Abs(b * 7 + 7));
			double result = c * (Math.Pow(((x * x) + Math.Pow(7, 1.2) * d), 1 / 7));
			if (Math.Abs(x) >= 10) Console.WriteLine("y = " + result);
			else Console.WriteLine("y = " + result1);
		}
	}
}

