using System;

namespace DataOriented_vs_ObjectOriented
{
	public class ObjectOrientedEquationCollection
	{
		private readonly Equation[] collection;

		private class Equation
		{
			private readonly int x;
			private readonly int y;

			public Equation(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			public int GetSolution()
			{
				return x + y;
			}
		}

		private readonly Random rand = new Random();

		public ObjectOrientedEquationCollection(int number)
		{
			collection = new Equation[number];
			for (int i = 0; i < number; i++)
			{
				collection[i] = new Equation(rand.Next(1, 10), rand.Next(1, 10));
			}
		}

		public int[] GetSolutions()
		{
			var solutions = new int[collection.Length];

			for (var i = 0; i < collection.Length; i++)
			{
				solutions[i] = collection[i].GetSolution();
			}

			return solutions;
		}
	}
}