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

    public void CalculateBreadPrice(int userInputCount)
    {
      if(userInputCount == 2)
      {
        Console.WriteLine(Price);
      }
    }
  }

  public class Pastry
  {
    public int Price { get; set; }
  }
}