using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string item1 = "salt";
      string item2 = "cream cheese";
      Order newOrder1 = new Order(item1);
      Order newOrder2 = new Order(item2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}