using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderContructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetItem_ReturnsItem_String()
    {
      string item = "flour";
      Order newOrder = new Order(item);
      string result = newOrder.Item;
      Assert.AreEqual(item, result);
    }

    [TestMethod]
    public void SetItem_SetItem_String()
    {
      string item = "butter";
      Order newOrder = new Order(item);

      string setItem = "sugar";
      newOrder.Item = setItem;
      string result = newOrder.Item;

      Assert.AreEqual(setItem, result);
    }
  }
}