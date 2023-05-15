using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
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
  }
  
}