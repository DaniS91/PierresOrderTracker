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
      Order newOrder = new Order("test", "test2", "test3", "2.000");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetProperty_ReturnsTitle_String()
    {
      string title = "test";
      string description = "test2";
      string date = "test3";
      string price = "2.000";
      Order newOrder = new Order(title, description, date, price);
      string result = title;
      Assert.AreEqual(newOrder.Title, result);
    }

    [TestMethod]
    public void SetProperty_UpdatesTitle_String()
    {
      string title = "test";
      string description = "test2";
      string date = "test3";
      string price = "2.000";
      Order newOrder = new Order(title, description, date, price);
      string newTitle = "Flour Order";
      newOrder.Title = newTitle;
      string result = newOrder.Title;
      Assert.AreEqual(newTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ListOfOrders()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}