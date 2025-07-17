using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static bool isIdenticalNum(int num)
		{
			string buff = num.ToString();
			int index = 0;
			do
			{
				for (int i = index + 1; i < buff.Length; ++i)
				{
					if (buff[index] == buff[i])
						return true;
				}
				index++;
			}
			while (index < buff.Length);
			return false;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter start num");
			int startNum = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter end num");
			int endNum = int.Parse(Console.ReadLine());

			int result = 0;
			for (int i = startNum; i <= endNum; ++i)
			{
				if (!isIdenticalNum(i))
				{
					++result;
				}
			}
			Console.WriteLine(result);
		}
	}
}
