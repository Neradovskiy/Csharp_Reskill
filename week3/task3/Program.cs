using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter num: ");
			string numStr = Console.ReadLine();
			string result = numStr.Replace("3", "").Replace("6", "");

			Console.WriteLine(result);
		}
	}
}
