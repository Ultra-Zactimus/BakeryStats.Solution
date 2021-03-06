using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryStatistics.Models;

namespace BakeryStatistics.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void Order_ItShouldCreateInstanceOfObject_NewOrder()
    {
      DateTime date = new DateTime(1986,03,10);
      Order order = new Order("details", 44, date);

      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void Order_NewObjectShouldContainItsValues_String()
    {
      DateTime date = new DateTime(1986,03,10);
      string details = "5 pastries";
      Order order = new Order(details, 0, date);
      string newOrder = order.OrderDetails;

      Assert.AreEqual(details, newOrder);
    }

    [TestMethod]
    public void Order_NewObjectShouldContainItsValues_Int()
    {
      DateTime date = new DateTime(1986,03,10);
      int price = 6;
      Order order = new Order("7 loafs", price, date);
      int objNum = order.Price;

      Assert.AreEqual(price, objNum);
    }

    [TestMethod]
    public void GetAll_ShouldReturnEmptyList_OrderList()
    {
      List<Order> order = new List<Order> { };
      List<Order> empty = Order.GetAll();

      CollectionAssert.AreEqual(order, empty);
    }

    [TestMethod]
    public void GetAll_ShouldReturnOrdersInList_OrderList()
    {
      DateTime date1 = new DateTime(2021,04,22);
      DateTime date2 = new DateTime(2002,10,10);
      string description1 = "2 pastries";
      string decription2 = "2 loafs of bread";
      Order firstOrder = new Order(description1, 0, date1);
      Order secondOrder = new Order(decription2, 0, date2);
      List<Order> list = new List<Order> { firstOrder, secondOrder };
      List<Order> details = Order.GetAll();

      CollectionAssert.AreEqual(list, details);
    }

    [TestMethod]
    public void GetOrderID_ShouldGetIdOfOrder_Int()
    {
      DateTime date = new DateTime(1986,03,10);
      string loafs = "5 loafs of bread";
      Order order = new Order(loafs, 0, date);
      int checkId = order.Id;

      Assert.AreEqual(1, checkId);
    }

    [TestMethod]
    public void Find_ShouldDistinguishOrdersById_Int()
    {
      DateTime date1 = new DateTime(1996,07,10);
      DateTime date2 = new DateTime(1997,06,28);
      string description1 = "20 pastries";
      string description2 = "1 pastry";
      Order order1 = new Order(description1, 0, date1);
      Order order2 = new Order(description2, 0, date2);
      Order gitIt = Order.Find(2);

      Assert.AreEqual(order2, gitIt);
    }
  }
}