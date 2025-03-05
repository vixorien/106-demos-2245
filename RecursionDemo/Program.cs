// Chris Cascioli
// 3/5/25
// Demo of recursion vs. iterative solutions to a simple problem

namespace RecursionDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Iterative factorial:");
            Console.WriteLine(IterativeFactorial(-5));
			Console.WriteLine(IterativeFactorial(0));
			Console.WriteLine(IterativeFactorial(1));
			Console.WriteLine(IterativeFactorial(3));
			Console.WriteLine(IterativeFactorial(5));

            Console.WriteLine();
			Console.WriteLine("Recursive factorial:");
			Console.WriteLine(RecursiveFactorial(-5));
			Console.WriteLine(RecursiveFactorial(0));
			Console.WriteLine(RecursiveFactorial(1));
			Console.WriteLine(RecursiveFactorial(3));
			Console.WriteLine(RecursiveFactorial(5));
		}

		/// <summary>
		/// Calculates the factorial of a non-negative number
		/// iteratively (with a loop)
		/// </summary>
		/// <param name="num">Number to factorialize</param>
		/// <returns>The factorial of num</returns>
		static int IterativeFactorial(int num)
		{
			// Check for simple known cases first
			if (num < 0) return -1; // Problem
			if (num == 0) return 1; // 0! is always 1

			// Track the final answer
			int result = 1;
			while (num > 0)
			{
				// Multiply, then adjust the number
				result *= num;
				num--;
			}

			return result;
		}

		/// <summary>
		/// Calculates the factorial of a non-negative number
		/// recursively (by calling itself)
		/// </summary>
		/// <param name="num">Number to factorialize</param>
		/// <returns>The factorial of num</returns>
		static int RecursiveFactorial(int num)
		{
			// Check for simple known cases first
			if (num < 0) return -1; // Problem
			if (num == 0) return 1; // 0! is always 1 - This is our BASE CASE

			return num * RecursiveFactorial(num - 1);
		}

	}
}
