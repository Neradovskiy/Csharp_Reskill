using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			if (num < 0)
				num = -num;
			for (int i = 1; i <= num; i++)
			{
				int result = i * i;
				if (num % result == 0 && num % result * i != 0)
					Console.WriteLine(i);
			}
		}
	}
}
