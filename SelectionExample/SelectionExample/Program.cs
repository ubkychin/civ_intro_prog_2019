/*
 * Created by SharpDevelop.
 * User: anguyen
 * Date: 7/03/2019
 * Time: 6:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SelectionExample
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			string input;
			int age;
			
			Console.WriteLine("Please enter your age:");
			input = Console.ReadLine();
			
			age = int.Parse(input);
			
			if(age >= 18) {
				Console.WriteLine("Welcome to pub");
			}  else {
				if(age <= 0) {
					Console.WriteLine("What the Fuck!?");
				} else {
					Console.WriteLine("Go watch a Disney movie kiddo");
				}
				
			}
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}