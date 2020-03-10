using System;
using Bakery.Models;

namespace Bakery
{
	class Program
	{
		static void Main()
		{
			Bread newBread = new Bread(5);
			Pastry newPastry = new Pastry(2, "croissant");
			WelcomeMessage();
			MainMenu();
			string userInputMainPage = Console.ReadLine();
			string userInputMainPageLower = userInputMainPage.ToLower();
			if(userInputMainPageLower == "b")
			{
			Console.WriteLine("How many loaves of bread would you like?");
			string stringUserInputBread = Console.ReadLine();
			int userInputBread = int.Parse(stringUserInputBread);
	
			newBread.SetBreadPrice(userInputBread);
			Console.WriteLine("Your cost for the bread is $" + newBread.BreadPrice + ".");
				AnythingElse();
			}
			else if( userInputMainPageLower == "p")
			{
				int outputPastryPrice = newPastry.PastryPrice;
				Console.WriteLine("How many pieces of Pastry would you like?");
				string stringUserInputPastry = Console.ReadLine();
				int userInputPastry = int.Parse(stringUserInputPastry);
				int totalPastryPrice = newPastry.SetPastryPrice(userInputPastry);
				Console.WriteLine("That will be $" + totalPastryPrice + ".");
				AnythingElse();
			}
			else if(userInputMainPageLower == "bp")
			{
				Console.WriteLine("How many loaves of bread would you like?");
				string stringUserInputBread = Console.ReadLine();
				int userInputBread = int.Parse(stringUserInputBread);
				Console.WriteLine("How many pieces of Pastry would you like?");
				string stringUserInputPastry = Console.ReadLine();
				int userInputPastry = int.Parse(stringUserInputPastry);
				int totalPastryPrice = newPastry.SetPastryPrice(userInputPastry);

				newPastry.SetPastryPrice(userInputPastry);
				newBread.SetBreadPrice(userInputBread);
				int totalPrice = newBread.BreadPrice + newPastry.PastryPrice;
				Console.WriteLine("Your total price for bread and pastry is $" + totalPrice);
				AnythingElse();
			}
			else
			{
				MainMenu();
			}

		}
		public static void WelcomeMessage()
		{
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(@"
			WELCOME TO PIERRE'S BAKERY
				MENU:
			Item      	Price
			Bread		$5
			Pastry		$2");
		}

		public static void MainMenu()
		{
			// Console.ResetColor();
			Console.WriteLine(@"
			What would you like today?
				[B] for just bread
				[P] for just pastries
				[BP] for both bread and pastries");
		}

		public static void AnythingElse()
		{
			Console.WriteLine("Would that be all for you today? [Y]/[N]");
			string yesNo = Console.ReadLine();
			string yesNoLower = yesNo.ToLower();
			if(yesNoLower == "y")
			{
				Console.WriteLine("Thanks for stopping by! Bye now.");
			}
			else
			{
				Main();
			}
		}
	}
}

