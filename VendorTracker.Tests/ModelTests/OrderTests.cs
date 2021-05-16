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
      string title = "Coho Cafe Order";
      Order newOrder = new Order(title, "test", 0, "test");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "200 loaves of sourdough bread and 200 eclairs due by 8am";
      Order newOrder = new Order("Coho Cafe Order", description, 0, "test");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      int price = 600;
      Order newOrder = new Order("Coho Cafe Order", "200 loaves of sourdough bread and 200 eclairs due by 8am", 600, "test");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
  }
}
