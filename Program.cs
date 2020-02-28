using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
					Bread newBread = new Bread(5);
					// Pastry newPastry = new Pastry(2);
					newBread.MainMenu();
					Console.WriteLine("Do you want pastries? [Y]/[N]");
					string yesNo = Console.ReadLine();
					string yesNoLower = yesNo.ToLower();
					if (yesNoLower == "y")
					{
						Console.WriteLine("how much pastries would you like?");
						string stringUserInputPastry = Console.ReadLine();
						int userInputPastry = int.Parse(stringUserInputPastry);
						// newPastry.CalculatePastryPrice(userInputPastry);
					}
					else
					{
						Console.WriteLine("Goodbye.");
					}
				}
    }
}

