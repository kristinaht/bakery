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

    public int SetBreadPrice(int userInputBread)
    {
      if(userInputBread != 2 )
      {
        BreadPrice = BreadPrice * userInputBread; 
      }
      return BreadPrice;
    }
    public void CalculateBreadPrice()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      string stringUserInputBread = Console.ReadLine();
      int userInputBread = int.Parse(stringUserInputBread);
  
      BreadPrice = SetBreadPrice(userInputBread);
      Console.WriteLine("That will be $" + BreadPrice + ".");
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

      public  int PastryMath(int userInputPastry, int outputPastryPrice)
      {
        if(userInputPastry !=2)
        {
           outputPastryPrice = outputPastryPrice * userInputPastry; 
        }
        return outputPastryPrice;
      }
      public void CalculatePastryPrice()
      {
        int outputPastryPrice = PastryPrice;
        Console.WriteLine("How many loaves of Pastry would you like?");
        string stringUserInputPastry = Console.ReadLine();
        int userInputPastry = int.Parse(stringUserInputPastry);
        int totalPastryPrice = PastryMath(userInputPastry, outputPastryPrice);
        Console.WriteLine("That will be $" + totalPastryPrice + ".");
      }
  
    }
  }