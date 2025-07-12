using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter num: ");
			int buff = 0;
			int result = 0;
			do
			{
				Console.WriteLine("Please enter 0 to get the result");
				Console.WriteLine("Enter num: ");
				buff = int.Parse(Console.ReadLine());
				result += buff;
			} while (buff != 0);
			Console.WriteLine("Result is: " + "[" + result + "]");
		}
	}
}
