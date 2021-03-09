using System;
using System.Linq;

namespace CSAchievementFuncties
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "Dit is een test";
			char[] ca  = input.ToArray();
			Array.Reverse(ca);
			Console.WriteLine(ca);
			Console.ReadKey();
		}
	}
}
