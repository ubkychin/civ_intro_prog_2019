/*
 * Created by SharpDevelop.
 * User: anguyen
 * Date: 21/03/2019
 * Time: 4:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Arrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			int count = 0;
			int[] scoreArray = new int[10];
			
			// Gather input into the array
			while(count < scoreArray.Length) {
				int score = int.Parse(Console.ReadLine());
				scoreArray[count] = score;
				count++;
			}
			
			// work out total from the array
			int total = 0;
			count = 0;
			while(count < scoreArray.Length) {
				total = total + scoreArray[count];
				count++;
			}
			
			Console.WriteLine("Total is " + total);

			
			Console.ReadLine();
			
		}
	}
}