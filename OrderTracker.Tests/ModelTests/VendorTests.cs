using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests 
  // : IDisposable
  {
    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }
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
    public void GetNumber_ReturnsVendorId_Int()
    {
      string name1 = "Suzie's Flours";
      string description1 = "Suzie McBee's artisan flours";
      string location1 = "Portland, OR";
      Vendor newVendor1 = new Vendor(name1, description1, location1);
      string name2 = "Bill's Honey";
      string description2 = "Bill's Honey Products";
      string location2 = "Camas, WA";
      Vendor newVendor2 = new Vendor(name2, description2, location2);
      string name3 = "Bill's Honey";
      string description3 = "Bill's Honey Products";
      string location3 = "Camas, WA";
      Vendor newVendor3 = new Vendor(name3, description3, location3);
      int result = newVendor3.Id;
      Assert.AreEqual(3, result);
    }
  }
}