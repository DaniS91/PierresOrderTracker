using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class CategoryTests
  {
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
  }
}