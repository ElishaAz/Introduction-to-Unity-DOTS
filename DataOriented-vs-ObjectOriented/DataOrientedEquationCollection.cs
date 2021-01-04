using System;

namespace DataOriented_vs_ObjectOriented
{
	public class DataOrientedEquationCollection
	{
		private readonly int[] allXs;
		private readonly int[] allYs;


		private readonly Random rand = new Random();

		public DataOrientedEquationCollection(int number)
		{
			allXs = new int[number];
			allYs = new int[number];

			for (int i = 0; i < number; i++)
			{
				allXs[i] = rand.Next(1, 10);
				allYs[i] = rand.Next(1, 10);
			}
		}

		public int[] GetSolutions()
		{
			var solutions = new int[allXs.Length];
			for (int i = 0; i < allXs.Length; i++)
			{
				solutions[i] = allXs[i] + allYs[i];
			}

			return solutions;
		}
	}
}