using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
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
