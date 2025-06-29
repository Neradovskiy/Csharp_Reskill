using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static int RangeSumm(int num, int hightRange)
		{
			int result = 0;
			for (int i = num; i < hightRange; i++)
				result += i;
			return result;
		}
		static void Main(string[] args)
		{
			int hightRange = 500;
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(RangeSumm(num, hightRange));
		}
	}
}
