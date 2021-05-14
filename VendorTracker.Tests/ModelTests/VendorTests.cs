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
      string description = "24-hour comfort food";
      Vendor newVendor = new Vendor("Sally's Diner", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Sally's Diner";
      string description = "24-hour comfort food";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void FindId_FindVendorBasedOnId_Int()
    {
      string name01= "Sally's Diner";
      string description01 = "24-hour Comfort Food";
      string name02 = "The Coho Cafe";
      string description02 = "An Old Time Alaskan Restaurant";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);

    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
    string name01 = "Sally's Diner";
    string description01 = "24-hour Comfort Food";
    string name02 = "The Coho Cafe";
    string description02 = "An Old Time Alaskan Restaurant";
    Vendor newVendor1 = new Vendor(name01, description01);
    Vendor newVendor2 = new Vendor(name02, description02);
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    List<Vendor> result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }
  }
}

// name, description, list of orders