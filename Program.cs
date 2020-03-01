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
						newBread.CalculateBreadPrice();
						AnythingElse();
					}
					else if( userInputMainPageLower == "p")
					{
						newPastry.CalculatePastryPrice();
						AnythingElse();
					}
					else if(userInputMainPageLower == "bp")
					{
						newBread.CalculateBreadPrice();
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
					| |  | |    | |                          | |        | ___ (_)                  ( )     | ___ \     | |                  
| |  | | ___| | ___ ___  _ __ ___   ___  | |_ ___   | |_/ /_  ___ _ __ _ __ ___|/ ___  | |_/ / __ _| | _____ _ __ _   _ 
| |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  |  __/| |/ _ \ '__| '__/ _ \ / __| | ___ \/ _` | |/ / _ \ '__| | | |
\  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |   | |  __/ |  | | |  __/ \__ \ | |_/ / (_| |   <  __/ |  | |_| |
 \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  \_|   |_|\___|_|  |_|  \___| |___/ \____/ \__,_|_|\_\___|_|   \__, |
                                                                                                                   __/ |
                                                                                                                  |___/ 

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

