using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			Looper();
			_ = Console.ReadLine();
		}

		private static void Looper()
		{
			int total = 0;

			for ( int i = 1; i <= 100; i++ )
			{
				total += i;
				if ( i == 73 )
				{
					throw new Exception();
				}
			}
		}
	}
}
