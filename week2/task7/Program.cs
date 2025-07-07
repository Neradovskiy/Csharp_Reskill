using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
	internal class Program
	{
		static List<int> getRange(int start, int end)
		{
			List<int> result = new List<int>();
			if (start > end)
				(start, end) = (end, start);
			for (int i = start; i <= end; i++)
				result.Add(i);
			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Enter num1: ");
			int num1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter num2: ");
			int num2 = int.Parse(Console.ReadLine());

			List<int> result = getRange(num1, num2);
			List<int> evenNums = new List<int>();
			List<int> oddNums = new List<int>();
			List<int> multiplesOfSeven = new List<int>();
			
			evenNums = result.FindAll(i => i % 2 == 0);
			Console.WriteLine("Even nums is:");
			evenNums.ForEach(i => Console.WriteLine(i));

			oddNums = result.FindAll(i => i % 2 != 0);
			Console.WriteLine("odd nums is:");
			oddNums.ForEach(i => Console.WriteLine(i));
			
			multiplesOfSeven = result.FindAll(i => i % 7 == 0);
			Console.WriteLine("multiples of seven is:");
			multiplesOfSeven.ForEach(i => Console.WriteLine(i));


		}
	}
}
