using System;

namespace Les2Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] Array1 = { 10, 20, 30, 40, 50, 60 };
			int[] Array2 = { };

			for (int i = 0; i < Array2.Length; i++)
			{
				int s = Array2[i];
				Console.WriteLine(s);
			}

			for (int i = Array1.Length - 1; i >= 0; i--)
			{
				int s = Array1[i];
				Console.WriteLine(s);
			}
		}
	}
}
