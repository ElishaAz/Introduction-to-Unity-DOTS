using System;
using System.Diagnostics;

namespace DataOriented_vs_ObjectOriented
{
    class Program
    {
		private static readonly int[] equationNumbers = new[]
			{10, 100, 1000, 100 * 1000, 1000 * 1000, 10 * 1000 * 1000};

		private static readonly int[] squareNumbers = new[]
			{10, 100, 1000, 100 * 1000, 1000 * 1000, 10 * 1000 * 1000};

		private const int timesToRun = 1;

		static void Main(string[] args)
		{
			foreach (var number in equationNumbers)
			{
				var objectOriented = new ObjectOrientedEquationCollection(number);
				var dataOriented = new DataOrientedEquationCollection(number);

				var objectOrientedStopwatch = Stopwatch.StartNew();
				for (int i = 0; i < timesToRun; i++)
				{
					objectOriented.GetSolutions();
				}

				objectOrientedStopwatch.Stop();

				var dataOrientedStopwatch = Stopwatch.StartNew();
				for (int i = 0; i < timesToRun; i++)
				{
					dataOriented.GetSolutions();
				}

				objectOrientedStopwatch.Stop();

				Console.WriteLine(
					$"{number} equations, {timesToRun} times. Elapsed ticks: object oriented: {objectOrientedStopwatch.ElapsedTicks} " +
					$"{(objectOrientedStopwatch.ElapsedTicks > dataOrientedStopwatch.ElapsedTicks ? '>' : '<')} " +
					$"{dataOrientedStopwatch.ElapsedTicks}: data oriented");
			}

			Console.WriteLine();

			foreach (var number in squareNumbers)
			{
				var objectOriented = new ObjectOrientedSquareCollection(number);
				var dataOriented = new DataOrientedSquareCollection(number);

				var objectOrientedStopwatch = Stopwatch.StartNew();
				for (int i = 0; i < timesToRun; i++)
				{
					objectOriented.MoveBy(10, 10);
				}

				objectOrientedStopwatch.Stop();

				var dataOrientedStopwatch = Stopwatch.StartNew();
				for (int i = 0; i < timesToRun; i++)
				{
					dataOriented.MoveBy(10, 10);
				}

				objectOrientedStopwatch.Stop();

				Console.WriteLine(
					$"{number} squares, {timesToRun} times. Elapsed ticks: object oriented: {objectOrientedStopwatch.ElapsedTicks} " +
					$"{(objectOrientedStopwatch.ElapsedTicks > dataOrientedStopwatch.ElapsedTicks ? '>' : '<')} " +
					$"{dataOrientedStopwatch.ElapsedTicks}: data oriented");
			}
		}
	}
}
