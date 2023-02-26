using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Suzie's Flours";
      string description = "Suzie McBee's artisan flours";
      string location = "Portland, OR";
      Vendor newVendor = new Vendor(name, description, location);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetProperty_UpdatesLocation_String()
    {
      string name = "Suzie's Flours";
      string description = "Suzie McBee's artisan flours";
      string location = "Portland, OR";
      Vendor newVendor = new Vendor(name, description, location);
      string newLocation = "Seattle, WA";
      newVendor.Location = newLocation;
      string result = newVendor.Location;
      Assert.AreEqual(newLocation, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name1 = "Suzie's Flours";
      string description1 = "Suzie McBee's artisan flours";
      string location1 = "Portland, OR";
      Vendor newVendor1 = new Vendor(name1, description1, location1);
      string name2 = "Bill's Honey";
      string description2 = "Bill's Honey Products";
      string location2 = "Camas, WA";
      Vendor newVendor2 = new Vendor(name2, description2, location2);
      int result = newVendor2.Id;
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorInstancesInList_VendorList()
    {
      string name1 = "Suzie's Flours";
      string description1 = "Suzie McBee's artisan flours";
      string location1 = "Portland, OR";
      Vendor newVendor1 = new Vendor(name1, description1, location1);
      string name2 = "Bill's Honey";
      string description2 = "Bill's Honey Products";
      string location2 = "Camas, WA";
      Vendor newVendor2 = new Vendor(name2, description2, location2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendorWithId_Vendor()
    {
      string name1 = "Suzie's Flours";
      string description1 = "Suzie McBee's artisan flours";
      string location1 = "Portland, OR";
      Vendor newVendor1 = new Vendor(name1, description1, location1);
      string name2 = "Bill's Honey";
      string description2 = "Bill's Honey Products";
      string location2 = "Camas, WA";
      Vendor newVendor2 = new Vendor(name2, description2, location2);

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToAssociatedVendor_OrderList()
    {
      string orderTitle = "Flour Order";
      string orderDescription = "1lb of flour";
      string orderDate = "02/25/23";
      string orderPrice = "$4.00";
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Suzie's Flours";
      string vendorDescription = "Suzie McBee's artisan flours";
      string vendorLocation = "Portland, OR";
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorLocation);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}