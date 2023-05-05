using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Bread
  {
    
    public static Dictionary<string,int[]> Dict = new Dictionary<string, int[]>();

    public Pastry(int cost, int discount) : base(cost,discount)
    {
      Cost = cost;
      DiscountAmount = discount;
    }
  }
}

/*

dictionary to hold information

Dictonary -> key and value
key will be the item
value will be amount, cost and discount in an array
ui will force bread and pastry keys
store owner will have to add others.


*/


/*

Solution from Bread.cs seems to work well

pastry count * 2 - ([count / 4] rounded down * 2)
could make it work for both by calling similar inputs
*/