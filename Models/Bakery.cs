using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }

    public Bread(int price)
    {
      Price = price;
    }

    public void MainMenu()
    {
      Console.WriteLine(Price);
      Console.WriteLine(@"
                          Welcome to Pierre's Bakery! 
    
                            MENU:
                          Item      	Price
                          Bread		$5
                          Pastry	$2
                                      ");
      Console.WriteLine("How many loaves of bread for you?");
      string stringUserInputBread = Console.ReadLine();
      int userInputBread = int.Parse(stringUserInputBread);
      Console.WriteLine(userInputBread);
      

    }
    public void CalculateBreadPrice(int userInputCount)
    {
      int outputPrice = Price;
      if(userInputCount != 2)
      {
        outputPrice = Price * userInputCount;
      }
      Console.WriteLine(outputPrice);
    }
    }

    public class Pastry
    {
      public int Price { get; set; }

      public Pastry(int price){
        Price=price;
      }
    }
  }