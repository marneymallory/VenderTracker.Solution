using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Sally's Cafe";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }
  [TestMethod]
  public void GetId_ReturnsVendorId_Int();
  {
    string name = "Vendor Name";
    Vendor newVendor = new Vendor(name);
    int result = newVendor.Id;
    Assert.AreEqual (1, result);
  }
  }
}


// name, description, list of orders