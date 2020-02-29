using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }

    public Bread(int price)
    {
      BreadPrice = price;
    }

    public void CalculateBreadPrice()
    {
      int outputBreadPrice = BreadPrice;
      Console.WriteLine("How many loaves of bread would you like?");
      string stringUserInputBread = Console.ReadLine();
      int userInputBread = int.Parse(stringUserInputBread);
  
      if(userInputBread != 2 )
      {
        outputBreadPrice = outputBreadPrice * userInputBread; 
      }
      Console.WriteLine(outputBreadPrice);
    }

    }

    public class Pastry
    {
      public int PastryPrice { get; set; }
       public string PastryType { get; set; }
      public Pastry(int pastryPrice, string pastryType)
      {
        PastryPrice = pastryPrice;
        PastryType = pastryType;
      }

      public void CalculatePastryPrice()
      {
        int outputPastryPrice = PastryPrice;
        Console.WriteLine("How many loaves of Pastry would you like?");
        string stringUserInputPastry = Console.ReadLine();
        int userInputPastry = int.Parse(stringUserInputPastry);
    
        if(userInputPastry != 2 )
        {
          outputPastryPrice = outputPastryPrice * userInputPastry; 
        }
        Console.WriteLine(outputPastryPrice);
      }
  
    }
  }