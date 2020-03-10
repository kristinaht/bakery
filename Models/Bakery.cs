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

      if(userInputBread >=2 )
      {
        BreadPrice = (userInputBread - (userInputBread/3))* BreadPrice;
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
      // if(userInputPastry == 3 )
      // {
      //     PastryPrice = (userInputPastry * PastryPrice) - 1;
      // }
      // else{
      //   PastryPrice = PastryPrice * userInputPastry;
      // }
      PastryPrice = (userInputPastry / 3) * 5 + userInputPastry % 3 * 2;
      return PastryPrice;
    }
  }
}