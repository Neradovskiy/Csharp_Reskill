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
			Console.WriteLine("Enter max num: ");
			int maxNum = int.Parse(Console.ReadLine());
			for (int i = 0; i <= maxNum; i++) 
				Console.WriteLine(i);
		}
	}
}
