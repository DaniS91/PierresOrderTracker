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
      Order newOrder = new Order("test", "test2", "test3", 2.000);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}