using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter strNum:");
			string strNum = Console.ReadLine();
			int num = int.Parse(strNum);
			int sum = 0;
			foreach (char i in strNum)
			{
				sum += int.Parse(i.ToString());
			}

			Console.WriteLine("Num pow is: [" + Math.Pow(sum, 3) + "]");
			Console.WriteLine("cube of the sum of the digits of this number is num * num  ? [" + Math.Pow(sum, 3) == Math.Pow(num, 2) + "]");
		}
	}
}
