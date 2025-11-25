using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int side = 10;

			Console.WriteLine("A:");

			for (int y = 0; y <= side; y++)		//А
			{
				for (int x = 0; x <= side; x++)   
					if (x >= y)
						Console.Write("*");
					else
						Console.Write(" ");
				Console.WriteLine();
			}
			Console.WriteLine("Б:");
			//for (int y = side; y >= 0; y--) // Б
			//{
			//	for (int x = y; x <= side; x++)
			//		Console.Write("*");
			//	Console.WriteLine();
			//}

			for (int y = 0; y < side; y++) //Б
			{
				for (int x = 0; x <= y; x++)
					Console.Write("*");
				Console.WriteLine();
			}

			Console.WriteLine("В:");

			for (int y = side; y >= 0; y--)
			{
				for (int x = 0; x <= side; x++)   //B
					if (x >= y || x <= side - y)
						Console.Write(" ");
					else
						Console.Write("*");
				Console.WriteLine();
			}

			Console.WriteLine("Г:");

			for (int y = 0; y <= side; y++)
			{
				for (int x = 0; x <= side; x++)   //Г
					if (x >= y || x <= side - y)
						Console.Write(" ");
					else
						Console.Write("*");
				Console.WriteLine();
			}

			Console.WriteLine("Д:");
			int hight = 0;                          //Д
			int buff = side / 2;
			for (; hight <= buff; hight++)
			{
				for (int x = 0; x <= side - hight; x++)
					if (x >= hight)
						Console.Write("*");
					else
						Console.Write(" ");
				Console.WriteLine();
			}
			for (; hight <= side; hight++)
			{
				for (int x = 0; x <= side; x++)
					if (x > hight || x <= side - hight)
						Console.Write(" ");
					else
						Console.Write("*");
				Console.WriteLine();
			}

			Console.WriteLine("Е");         //Е
			hight = 0;
			for (; hight <= buff; hight++)
			{
				for (int x = 0; x <= side; x++)
					if (x <= hight || x >= side - hight)
						Console.Write("*");
					else
						Console.Write(" ");
				Console.WriteLine();
			}
			for (; hight <= side; hight++)
			{
				for (int x = 0; x <= side; x++)
					if (x > hight || x < side - hight)
						Console.Write("*");
					else
						Console.Write(" ");
				Console.WriteLine();
			}

			Console.WriteLine("Ж:");

			for (int y = 0; y <= side; y++)
			{
				for (int x = 0; x <= side; x++)   //Ж
					if (x >= y || x >= side - y)
						Console.Write(" ");
					else
						Console.Write("*");
				Console.WriteLine();
			}

			Console.WriteLine("З:");

			for (int y = 0; y <= side; y++)     //З
			{
				for (int x = 0; x <= side; x++)
					if (x >= y && x >= side - y)
						Console.Write("*");
					else
						Console.Write(" ");
				Console.WriteLine();
			}

			Console.WriteLine("И:");
			for (int y = 0; y <= side; y++) //И
			{
				for (int x = y; x <= side; x++)
					Console.Write("*");
				Console.WriteLine();
			}

			Console.WriteLine("K:");
			for (int y = 0; y <= side; y++) //K
			{
				for (int x = side; x >= 0; x--)
					if (x <= y)
						Console.Write("*");
					else Console.Write(" ");
				Console.WriteLine();
			}


		}
	}
}
