using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		struct ComplexNum
		{
			public double whole;
			public double imaginary;

			public ComplexNum(double whole, double imaginary)
			{
				this.whole = whole;
				this.imaginary = imaginary;
			}

			static ComplexNum Sum(ComplexNum a, ComplexNum b)
			{

				return new ComplexNum(a.whole + b.whole, a.imaginary + b.imaginary);
			}

			static ComplexNum Subtraction(ComplexNum a, ComplexNum b)
			{
				return new ComplexNum(a.whole - b.whole, a.imaginary - b.imaginary);
			}

			static ComplexNum Multiply(ComplexNum a, ComplexNum b)
			{
				return new ComplexNum(a.whole * b.whole, a.imaginary * b.imaginary);
			}

			static ComplexNum Div(ComplexNum a, ComplexNum b)
			{
				return new ComplexNum(a.whole / b.whole, a.imaginary / b.imaginary);
			}

			public override string ToString()
			{
				return "[" + whole.ToString() + " + " + imaginary.ToString() + "i]";
			}

			public static ComplexNum operator +(ComplexNum a, ComplexNum b)
			{
				return ComplexNum.Sum(a, b);
			}

			public static ComplexNum operator -(ComplexNum a, ComplexNum b)
			{
				return ComplexNum.Subtraction(a, b);
			}

			public static ComplexNum operator *(ComplexNum a, ComplexNum b)
			{
				return ComplexNum.Multiply(a, b);
			}

			public static ComplexNum operator /(ComplexNum a, ComplexNum b)
			{
				return ComplexNum.Div(a, b);
			}
		}
		static void Main(string[] args)
		{
			ComplexNum num = new ComplexNum(1.5, 3);
			ComplexNum otherNum = new ComplexNum(2, 3);
			Console.WriteLine("Num = " + num.ToString());
			Console.WriteLine("Num = " + otherNum.ToString());
			Console.WriteLine(num + " + " + otherNum + " = " + (num + otherNum));
			Console.WriteLine(num + " - " + otherNum + " = " + (num - otherNum));
			Console.WriteLine(num + " * " + otherNum + " = " + (num * otherNum));
			Console.WriteLine(num + " / " + otherNum + " = " + (num / otherNum));

		}
	}
}
