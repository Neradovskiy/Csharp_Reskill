using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Enter num1: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter num2: ");
			int num2 = int.Parse(Console.ReadLine());
			int i = 1;
			int temp = num1 > num2 ? num2 : num1;
			while (i <= temp)
			{
				if (num1 % i == 0 && num2 % i == 0)
					Console.WriteLine(i);
				++i;
			}
		}
	}
}
