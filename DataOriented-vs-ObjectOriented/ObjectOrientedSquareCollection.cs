using System;

namespace DataOriented_vs_ObjectOriented
{
	public class ObjectOrientedSquareCollection
	{
		private readonly Square[] collection;


		public void MoveBy(int deltaX, int deltaY)
		{
			for (var i = 0; i < collection.Length; i++)
			{
				collection[i].MoveBy(deltaX, deltaY);
			}
		}

		private class Square
		{
			private int x;
			private int y;

			private int width;

			private (int, int, int) color;

			public Square(int x, int y, int width, int height, int colorR, int colorG, int colorB)
			{
				this.x = x;
				this.y = y;
				this.width = width;
				color = (colorR, colorB, colorG);
			}

			public void MoveBy(int deltaX, int deltaY)
			{
				x += deltaX;
				y += deltaY;
			}
		}

		private readonly Random rand = new Random();

		public ObjectOrientedSquareCollection(int number)
		{
			collection = new Square[number];
			for (int i = 0; i < number; i++)
			{
				collection[i] = new Square(rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10),
					rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
			}
		}
	}
}