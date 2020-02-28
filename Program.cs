using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
					Bread newBread = new Bread(5);
					Console.WriteLine(newBread.Price);
					Console.WriteLine(@"
															Welcome to Pierre's Bakery! 
				
																MENU:
															Item      	Price
															Bread		$5
															Pastry		$2");

        }
    }
}
