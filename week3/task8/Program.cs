using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
	internal class Program
	{
		static void printMenu()
		{
			Console.WriteLine("Enter options:");
			Console.WriteLine("1: Count of zero");
			Console.WriteLine("2: Digit count");
			Console.WriteLine("3: Summ digits of a number");
			Console.WriteLine("4: Arithmetic mean");
			Console.WriteLine("0: Exit");
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter num: ");
			string numStr = Console.ReadLine();
			int digitCount = numStr.Length;
			int summ = 0;
			int zeroCount = 0;
			foreach (char c in numStr)
			{
				if (char.IsLetterOrDigit(c))
				{
					if (c == '0')
						zeroCount++;
					summ += c - '0';
				}
			}
			int choice;
			do
			{
				printMenu();
				choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("Zero count is:" + zeroCount);
						break;
					case 2:
						Console.WriteLine("Digit count is:" + digitCount);
						break;
					case 3:
						Console.WriteLine("Summ is: " + summ);
						break;
					case 4:
						Console.WriteLine("Arithmetic mean is: " + summ / digitCount);
						break;

				}
			} while (choice != 0);







		}
	}
}

