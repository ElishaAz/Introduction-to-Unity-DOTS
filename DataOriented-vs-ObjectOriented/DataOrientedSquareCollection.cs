using System;

namespace DataOriented_vs_ObjectOriented
{
	public class DataOrientedSquareCollection
	{
		private readonly int[] allXs;
		private readonly int[] allYs;
		private readonly int[] allWidths;
		private readonly int[] allHeights;

		private readonly (int, int, int)[] allColors;


		private readonly Random rand = new Random();

		public DataOrientedSquareCollection(int number)
		{
			allXs = new int[number];
			allYs = new int[number];
			allWidths = new int[number];
			allHeights = new int[number];
			allColors = new (int, int, int)[number];

			for (int i = 0; i < number; i++)
			{
				allXs[i] = rand.Next(1, 10);
				allYs[i] = rand.Next(1, 10);
				allWidths[i] = rand.Next(1, 10);
				allHeights[i] = rand.Next(1, 10);

				allColors[i] = (rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
			}
		}

		public void MoveBy(int deltaX, int deltaY)
		{
			for (int i = 0; i < allXs.Length; i++)
			{
				allXs[i] += deltaX;
				allYs[i] += deltaY;
			}
		}
	}
}