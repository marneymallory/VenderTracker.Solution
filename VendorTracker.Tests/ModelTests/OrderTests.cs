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
      Order.ClearAll();
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
      string description = "200 loaves of sourdough bread and 200 eclairs due by 6am";
      Order newOrder = new Order("Coho Cafe Order", description, 0, "test");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      int price = 600;
      Order newOrder = new Order("Coho Cafe Order", "200 loaves of sourdough bread and 200 eclairs due by 6am", 600, "test");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string date = "5/17/21";
      Order newOrder = new Order("Coho Cafe Order", "200 loaves of sourdough bread and 200 eclairs due by 6am", 600, "5/17/21");
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
   public void GetId_ReturnsOrderId_Int()
    {
      string title = "Coho Cafe Order";
      string description = "200 loaves of sourdough bread and 200 eclairs due by 6am";
      int price = 600;
      string date = "5/17/21";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]

    public void FindId_FindOrderBasedOnId_Int()
    {
      string title01= "Coho Cafe Order";
      string description01 = "200 loaves of sourdough bread and 200 eclairs due by 6am";
      int price01 = 600;
      string date01 = "5/17/21";
      string title02 = "Sally's Diner Order";
      string description02 = "250 loaves of french bread and 200 croissants due by 8am";
      int price02 = 750;
      string date02 = "5/18/21";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);

    }
       public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string title01= "Coho Cafe Order";
      string description01 = "200 loaves of sourdough bread and 200 eclairs due by 6am";
      int price01 = 600;
      string date01 = "5/17/21";
      string title02 = "Sally's Diner Order";
      string description02 = "250 loaves of french bread and 200 croissants due by 8am";
      int price02 = 750;
      string date02 = "5/18/21";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);

    }


  }
}
