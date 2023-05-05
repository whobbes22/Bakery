using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount{get;set;}
    public int Cost{get;set;}
    public Bread(int amount,int cost, int discount)
    {
      Amount = amount;
      Cost = cost;
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