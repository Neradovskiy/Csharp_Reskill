using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		//returns the product of all integers from a to range if a < 1 return -1
		static int MultiplyRange (int a, uint range)
		{
			if (a < 1)
				return -1;
			int result = a;
			for (; a < range; a++)
			{
				result *=a;
			}
			return result;
		}
		static void Main(string[] args)
		{
			uint range = 21;
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine(MultiplyRange(a, range));
		}
	}
}
