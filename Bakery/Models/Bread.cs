using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Cost{get;set;}
    public int DiscountAmount{get;set;}
    public Bread(int cost, int discount)
    {
      Cost = cost;
      DiscountAmount = discount;
    }

    public int FindDiscountedPrice(int amount)
    {
      // integers should round down automaticall with division
      // count * cost - ([count / discount] rounded down * cost)
      int discount = 0;
      if(DiscountAmount > 0){
        discount = amount / DiscountAmount * Cost;
      }
      return  amount * Cost - discount;
    }
  }
}

/*

bread costs 5$
every 2 get third free

bread count * 5 = total
find discount

total / 3 rounded down * 5 -> seems to work

ex
2 = 10
3 = 15

2/3 = .6 round down = no discount
3/3 = 1 round down = 1 discount -> 5$ discount

8*5 = 40
8/3 = 2.66 round down = 2 => 10$ discount
9/3 = 3 round down = 3

*/