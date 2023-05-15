using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread bread = new Bread(5,3);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetCost_ReturnCost_int()
    {
      int cost = 6;
      Bread bread = new Bread(cost,3);
      int breadCost = bread.Cost;
      Assert.AreEqual(cost,breadCost);
    }
    [TestMethod]
    public void GetDiscount_ReturnDiscount_int()
    {
      int discount = 3;
      Bread bread = new Bread(2,discount);
      int breadDiscount = bread.DiscountAmount;
      Assert.AreEqual(discount,breadDiscount);
    }

    [TestMethod]
    public void FindDiscountedCost_ReturnActualCost_int()
    {
      int amount = 3;
      Bread bread = new Bread(5,2);
      int discountedPrice = bread.FindDiscountedPrice(amount,5,2);
      Assert.AreEqual(discountedPrice,10);
    }

    //tests for Pastry

    [TestMethod]
    public void FindDiscountedCostPastry_ReturnActualCost_int()
    {
      int amount = 4;
      Pastry pastry = new Pastry(2,3,"pat");
      int dP = pastry.FindDiscountedPrice(amount,2,3);
      Assert.AreEqual(dP,6);

    }

    [TestMethod]
    public void GetAll_ReturnDictionary_Dictionary()
    {
      Pastry pastry = new Pastry(2,4,"Pastry");
      Dictionary<string,int[]> Dict = new Dictionary<string, int[]>() 
        {
          {
          "Pastry", new int[] {0,2,4}
          }
        };
      Dictionary<string,int[]> ActualDict = Pastry.GetAll();
      Assert.AreEqual(ActualDict["Pastry"][0],Dict["Pastry"][0]);
      
    }    
  }
  
}