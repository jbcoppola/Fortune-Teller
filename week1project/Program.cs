using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1project
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 	 Ask the user for the user’s first name
				 Ask the user for the user’s last name
				 Ask the user for the user’s age
				 Ask the user for the user’s birth month (as an 'int')
				 Ask the user for the user’s favorite ROYGBIV color
				 If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
				 Ask the user for the number of siblings the user has
				 */
			
			Console.WriteLine("Enter your first name;");
			string firstName = Console.ReadLine();

			Console.WriteLine("Enter your last name");
			string lastName = Console.ReadLine();

			Console.WriteLine("Enter your age");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter your birthmonth as a digit (1-12)");
			int birthMonth = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter your favorite ROYGBIV color (type 'help' if you do not know what this is)");
			string color = Console.ReadLine();
			while (color.ToLower() == "help")
			{
				Console.WriteLine(	"ROYGBIV is the color spectrum. It consists of:\n\n" +
									"Red\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n\n" +
									"Type your favorite one of these colors."	);

				color = Console.ReadLine();
			};

			Console.WriteLine("How many siblings do you have?");
			int siblings = int.Parse(Console.ReadLine());

			/*
			If the user’s age is an odd number, then they will retire in ____ years, 
			or ___ years if their age is an even number.
			 
			If the user’s number of siblings is 0, then they will have a vacation home in __(location), 
			or 1 then they will have a vacation home in __(location), or 2 then they will have a vacation 
			home in ___ (location), or 3 then they will have a vacation home in ___ (location), or more 
			than 3 then they will have a vacation home in ____ (location). If the user enters anything 
			other than a number greater than or equal to 0, they should get a bad vacation home!

			Depending on which ROYGBIV color is the user’s favorite, they will have a specific 
			mode of transportation (i.e. car, boat, plane, etc.)

			If the user’s birth month is 1-4, they will have $____ in the bank; 
			if the user's birth month is 5-8, they will have $____ in the bank; 
			and if it is 9-12, then they will have $____ in the bank. 
			If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.
			*/

			int retire;
			if (age % 2 == 0)
			{
				retire = 25;
			}
			else
			{
				retire = 50;
			}


			if (siblings == 0)
			{
				;
			}
			else if (siblings == 1)
			{
				;
			}
			else if (siblings == 2)
			{
				;
			}
			else if (siblings == 3)
			{
				;
			}
			else
			{
				;
			}

			switch (color.ToLower())
			{
				case "red":
					break;
				case "orange":
					break;
				case "yellow":
					break;
				case "green":
					break;
				case "blue":
					break;
				case "indigo":
					break;
				case "violet":
					break;
				default:
					break;
			}

			if (birthMonth > 0 && birthMonth < 13)
			{
				if (birthMonth > 8)
				{
					;
				}
				else if (birthMonth > 4)
				{
					;
				}
				else
				{
					;
				}
			}

			/*
			 The user’s fortune should be written as such:

			 [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, 
			 a vacation home in [Location] and a [Mode of Transportation].

			 Program should be able to handle whether or not a user inputs capital or lowercase letters.
			 */
		}
	}
}
