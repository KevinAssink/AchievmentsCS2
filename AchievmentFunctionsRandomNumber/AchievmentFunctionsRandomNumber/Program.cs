using System;

namespace AchievmentFunctionsRandomNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int randomNumber;

			Random randm = new Random();
			randomNumber = randm.Next(1, 20);

			Console.WriteLine("RandomNumber is " + randomNumber);
		}
	}
}
