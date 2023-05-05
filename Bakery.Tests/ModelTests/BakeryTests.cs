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
      Bread bread = new Bread(2,5,3);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnAmount_int()
    {
      int amount = 2;
      Bread bread = new Bread(amount,5,3);
      int breadAmount = bread.Amount;
      Assert.AreEqual(amount,breadAmount);
    }

  }
}