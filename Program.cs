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
						newPastry.CalculatePastryPrice();
						AnythingElse();
					}
					else if(userInputMainPageLower == "bp")
					{
						// newBread.CalculateBreadPrice();
						newPastry.CalculatePastryPrice();
						int totalPrice = newBread.BreadPrice + newPastry.PastryPrice;
						Console.WriteLine("Your total price for bread and pastry is $" + totalPrice);
						AnythingElse();
					}
					else
					{
						MainMenu();
					}

				}
				public static void MainMenu()
				{
					Console.BackgroundColor = ConsoleColor.DarkGray;
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(@"
					WELCOME TO PIERRE'S BAKERY
						MENU:
					Item      	Price
					Bread		$5
					Pastry		$2");
					// Console.ResetColor();
					Console.WriteLine(@"
					What would you like today?
						[B] for just bread
						[P] for just pastries
						[BP] for both bread and pastries");
				}

				public static void AnythingElse()
				{
					Console.WriteLine("Would that be all for you today?");
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

