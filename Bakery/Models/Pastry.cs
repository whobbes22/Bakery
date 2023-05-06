using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry : Bread
  {
    
    public static Dictionary<string,int[]> MenuList = new Dictionary<string, int[]>();

    public Pastry(int cost, int discount,string name) : base(cost,discount)
    {
      Cost = cost;
      DiscountAmount = discount;
      int[] value = {0,cost,discount};
      MenuList.Add(name,value);
    }

    public static Dictionary<string,int[]> GetAll()
    {
      return MenuList;
    }

    public  void AddAmountToKey(string key,int amount)
    {
      MenuList[key][1] = amount;
    }

    public void AddToMenuDictionary(string key,int cost,int dcPrice)
    {
     int[] arr = {0,cost,dcPrice};
      MenuList.Add(key,arr);

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