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
      if(userInputBread %2 != 0 )
      {
        BreadPrice = BreadPrice * userInputBread; 
      }
      else{
        BreadPrice = (BreadPrice * userInputBread)/2;
      }
      return BreadPrice;
    }
    // public void CalculateBreadPrice()
    // {
    //   Console.WriteLine("How many loaves of bread would you like?");
    //   string stringUserInputBread = Console.ReadLine();
    //   int userInputBread = int.Parse(stringUserInputBread);
  
    //   SetBreadPrice(userInputBread);
    //   Console.WriteLine("Your cost for the bread is $" + BreadPrice + ".");
    // }
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

    public  int SetPastryPrice(int userInputPastry)
    {
      if(userInputPastry %3 !=0)
      {
          PastryPrice = PastryPrice * userInputPastry; 
      }
      else
      {
        PastryPrice = (int)(Math.Round(1.67f * userInputPastry));
      }
      return PastryPrice;
    }
    // public void CalculatePastryPrice()
    // {
    //   int outputPastryPrice = PastryPrice;
    //   Console.WriteLine("How many pieces of Pastry would you like?");
    //   string stringUserInputPastry = Console.ReadLine();
    //   int userInputPastry = int.Parse(stringUserInputPastry);
    //   int totalPastryPrice = SetPastryPrice(userInputPastry);
    //   Console.WriteLine("That will be $" + totalPastryPrice + ".");
    // }
  }
  }