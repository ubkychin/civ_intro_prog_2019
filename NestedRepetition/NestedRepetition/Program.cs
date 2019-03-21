/*
 * Created by SharpDevelop.
 * User: anguyen
 * Date: 21/03/2019
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NestedRepetition
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Please enter your name: ");
			string name = Console.ReadLine();
			
			int counter = 0;
			
			
			while (counter < 10) {
				int counter2 = 0;
				
				while (counter2 < 5) {
					Console.Write(name);
					counter2++;  //++counter2  //counter2 += 1;  //counter2 = counter2 + 1;
				} // end while (counter2 < 5)
				
				Console.WriteLine();
				counter++;
				
			} // end while (counter < 5)
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}