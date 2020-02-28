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
  }

  public class Pastry
  {
    public int Price { get; set; }
  }
}