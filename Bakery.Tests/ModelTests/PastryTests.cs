using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    //tests for Pastry
  
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry pat = new Pastry(5,3,"pasty");
      Assert.AreEqual(typeof(Pastry), pat.GetType());
    }


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