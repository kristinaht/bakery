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

      if(userInputBread >=3 )
      {
        BreadPrice = userInputBread * 2/3 * BreadPrice;
      }
      
      return BreadPrice;
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

    public  int SetPastryPrice(int userInputPastry)
    {
      // PastryPrice = 2;
      if(userInputPastry == 3 )
      {
          PastryPrice = (userInputPastry * PastryPrice) - 1;
      }
      else{
        PastryPrice = PastryPrice * userInputPastry;
      }
      return PastryPrice;
    }
  }
}