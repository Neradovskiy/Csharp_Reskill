using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter x :");
				double x = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter y :");
				double y = double.Parse(Console.ReadLine());
				Console.WriteLine("Result: [" + Math.Pow(x, y) + "]");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}

