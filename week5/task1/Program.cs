using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sizeX = 5;
			int sizeY = 2;
			int[,] arrY = new int[sizeY, sizeX];
			Console.WriteLine("Enter num: ");
			int num = int.Parse(Console.ReadLine());
			for (int y = 0; y < sizeY; y++)
			{
				for (int x = 0; x < sizeX; x++)
				{
					if (x == y && y == 0)
						arrY[y, x] = num;
					else
					{
						num *= 2;
						arrY[y, x] = num;
					}
				}
			}
			for (int y = 0; y < sizeY; y++)
			{
				for (int x = 0; x < sizeX; x++)
				{
					Console.Write("[" + arrY[y, x] + "]" + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
