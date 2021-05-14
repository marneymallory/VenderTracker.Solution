using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
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
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Sally's Diner";
      Vendor newVendor = new Vendor(name, "test");

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string description = "Sally's Diner: 24-hour comfort food";
      Vendor newVendor = new Vendor("Sally's Diner", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
  }
}

// name, description, list of orders