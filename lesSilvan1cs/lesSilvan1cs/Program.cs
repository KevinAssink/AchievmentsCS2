using System;

namespace lesSilvan1cs
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = Multiply(2, 3);
			Console.WriteLine(i);
		}

		static int Multiply(int a, int b)
		{
			int c = a * b;
			return c;
		}
	}
}
