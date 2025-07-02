using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static int[] MultiplicationTable(int a)
		{
			int[] result = new int[11];
			for (int i = 0; i <= 10; ++i) 
			 result[i] = a * i;
			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter factor");
			int factor = int.Parse(Console.ReadLine());
			int[] table = MultiplicationTable(factor);
			for (int i = 0; i < table.Length; ++i) 
				Console.WriteLine(factor + " x " + i + " = " + table[i]);
		}
	}
}
