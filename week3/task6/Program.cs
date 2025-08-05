using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter num: ");
			int num = int.Parse(Console.ReadLine());
			int i = 1;
			while (i <= num)
			{
				if (num % i == 0)
					Console.WriteLine(i);
				++i;
			}
		}
	}
}
