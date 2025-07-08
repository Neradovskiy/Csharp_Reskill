using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter num1: ");
			int num1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter num2: ");
			int num2 = int.Parse(Console.ReadLine());
			if (num1 > num2)
				(num1, num2) = (num2, num1);
			int result = 0;
			for (int i = num1; i <= num2; i++)
				result += i;
			Console.WriteLine(result);
		}
	}
}
