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
					// newBread.MainMenu();

					Console.WriteLine(@"
                          Welcome to Pierre's Bakery! 
    
                            		MENU:
                          Item      	Price
                          Bread		  $5
                          Pastry		$2
                                      ");
					Console.WriteLine(@"We have bread fresh from the oven and delicous pastries. What would you like today?
																[B] for just bread
																[P] for just pastries
																[BP] for both bread and pastries");
					string stringUserInputBread = Console.ReadLine();
					int userInputBread = int.Parse(stringUserInputBread);
					// Console.WriteLine(userInputBread);
					newBread.CalculateBreadPrice(userInputBread);
					Console.WriteLine("Do you want pastries? [Y]/[N]");
					string yesNo = Console.ReadLine();
					string yesNoLower = yesNo.ToLower();
					if (yesNoLower == "y")
					{
						Console.WriteLine("how much pastries would you like?");
						string stringUserInputPastry = Console.ReadLine();
						int userInputPastry = int.Parse(stringUserInputPastry);
						newPastry.CalculatePastryPrice(userInputPastry);
					}
					else
					{
						Console.WriteLine("Goodbye.");
					}
				}
    }
}

