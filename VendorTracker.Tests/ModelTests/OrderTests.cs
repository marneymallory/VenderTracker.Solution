using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
   public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 0, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Weekly Bread Order";
      Order newOrder = new Order(title, "test", 0, "test");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "50 loavess of sourdough bread and 100 eclairs";
      Order newOrder = new Order("Weekly Bread Order", description, 0, "test");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
      
    }
  }
}