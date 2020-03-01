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
					}
					else if( userInputMainPageLower == "p")
					{
						newPastry.CalculatePastryPrice();
					}
					else if(userInputMainPageLower == "bp")
					{
						newBread.CalculateBreadPrice();
						newPastry.CalculatePastryPrice();
						int totalPrice = newBread.BreadPrice;
						Console.WriteLine(totalPrice);
					}
					else
					{
						MainMenu();
					}

				}
				public static void MainMenu()
				{
					Console.WriteLine(@"
					Welcome to Pierre's Bakery! 
						MENU:
					Item      	Price
					Bread		$5
					Pastry		$2");
					Console.WriteLine(@"
					What would you like today?
						[B] for just bread
						[P] for just pastries
						[BP] for both bread and pastries");
				}
    }
}

