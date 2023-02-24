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
    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      string title1 = "flour order";
      string description1 = "1lb of flour";
      string date1 = "today";
      string price1 = "2.000";
      Order newOrder1 = new Order(title1, description1, date1, price1);
      string title2 = "butter order";
      string description2 = "handful of butter";
      string date2 = "yesterday";
      string price2 = "10.00";
      Order newOrder2 = new Order(title2, description2, date2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrderCreatedWithIdAndReturns_Int()
    {
      string title1 = "flour order";
      string description1 = "1lb of flour";
      string date1 = "today";
      string price1 = "2.000";
      Order newOrder1 = new Order(title1, description1, date1, price1);
      int result = newOrder1.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrderFromId_Order()
    {
      string title1 = "flour order";
      string description1 = "1lb of flour";
      string date1 = "today";
      string price1 = "2.000";
      Order newOrder1 = new Order(title1, description1, date1, price1);
      string title2 = "butter order";
      string description2 = "handful of butter";
      string date2 = "yesterday";
      string price2 = "10.00";
      Order newOrder2 = new Order(title2, description2, date2, price2);
      Order result = Order.Find(1);
      Assert.AreEqual(newOrder1, result);
    }
  }
}