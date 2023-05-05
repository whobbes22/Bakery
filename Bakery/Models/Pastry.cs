using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Bread
  {
    
    public Pastry(int cost, int discount) : base(cost,discount)
    {
      Cost = cost;
      DiscountAmount = discount;
    }
  }
}



/*

Solution from Bread.cs seems to work well

pastry count * 2 - ([count / 4] rounded down * 2)
could make it work for both by calling similar inputs
*/