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
			string input = "";
			bool quit = false;
			while (input != "quit" && quit == false)
			{
				Console.WriteLine("Welcome to the Fortune Teller. Type \"quit\" to quit.");

				Console.WriteLine("Enter your first name");
				input = Console.ReadLine();
				if (input == "quit")
				{
					break;
				}
				string firstName = input;

				Console.WriteLine("Enter your last name");
				input = Console.ReadLine();
				if (input == "quit")
				{
					break;
				}
				string lastName = Console.ReadLine();

				Console.WriteLine("Enter your age");
				input = Console.ReadLine();
				if (input == "quit")
				{
					break;
				}
				int age = int.Parse(input);

				Console.WriteLine("Enter your birthmonth as a digit (1-12)");
				input = Console.ReadLine();
				if (input == "quit")
				{
					break;
				}
				int birthMonth = int.Parse(input);

				Console.WriteLine("Enter your favorite ROYGBIV color (type 'help' if you do not know what this is)");
				input = Console.ReadLine();
				string color = input;
				while (color.ToLower() == "help")
				{
					Console.WriteLine(	"ROYGBIV is the color spectrum. It consists of:\n\n" +
										"Red\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n\n" +
										"Type your favorite one of these colors."	);

					color = Console.ReadLine();
				};
				input = color;

				Console.WriteLine("Enter how many siblings you have.");
				input = Console.ReadLine();
				int siblings = int.Parse(input);

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
					retire = 40;
				}
				else
				{
					retire = 30;
				}

				string vacationHome;
				if (siblings == 0)
				{
					vacationHome = "Las Vegas";
				}
				else if (siblings == 1)
				{
					vacationHome = "Cancun";
				}
				else if (siblings == 2)
				{
					vacationHome = "Australia";
				}
				else if (siblings == 3)
				{
					vacationHome = "France";
				}
				else
				{
					vacationHome = "Antarctica";
				}

				string favoriteVehicle;
				switch (color.ToLower())
				{
					case "red":
						favoriteVehicle = "Abrams tank with live ammunition";
						break;
					case "orange":
						favoriteVehicle = "steam train retrofitted with car tires";
						break;
					case "yellow":
						favoriteVehicle = "very small and improprietously painted submarine";
						break;
					case "green":
						favoriteVehicle = "blimp emblazoned with the logo for the short-lived 1939 comedy troupe \"Axison Allies\"";
						break;
					case "blue":
						favoriteVehicle = "pirate ship loaded with stolen Spanish silver. Avast";
						break;
					case "indigo":
						favoriteVehicle = "featureless chrome orb that hovers ominiously over the road";
						break;
					case "violet":
						favoriteVehicle = "purple Mini Cooper with wood siding";
						break;
					default:
						favoriteVehicle = "circus tent that blew away in the wind and wrapped around a hot dog truck";
						break;
				}

				float bankCash;
				if (birthMonth > 0 && birthMonth < 13)
				{
					if (birthMonth > 8)
					{
						bankCash = 100000.00f;
					}
					else if (birthMonth > 4)
					{
						bankCash = 80000.00f;
					}
					else
					{
						bankCash = 60000.00f;
					}
				}
				else
				{
					bankCash = 0.00f;
				}

				/*
				 The user’s fortune should be written as such:

				 [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, 
				 a vacation home in [Location] and a [Mode of Transportation].

				 Program should be able to handle whether or not a user inputs capital or lowercase letters.
				 */

				Console.WriteLine(firstName + ' ' + lastName + "will retire in " + retire + " with " + bankCash + " in the bank, "
									+ "a vacation home in " + vacationHome + " and a " + favoriteVehicle + '.');
				quit = true;
			}
			if (input == "quit")
			{
				Console.WriteLine("Nobody likes a quitter...");
			}
		}
		
	}
}
