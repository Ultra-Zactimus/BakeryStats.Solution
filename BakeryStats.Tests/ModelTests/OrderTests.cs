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
      Order.ClearAllOrders();
    }

    [TestMethod]
    public void Order_ItShouldCreateInstanceOfObject_NewOrder()
    {
      Order order = new Order("blah", "blahblah", 0, 2022);

      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void Order_NewObjectShouldContainItsValues_String()
    {
      string customer = "John";
      Order order = new Order(customer, "string", 0, 0);
      string newOrder = order.Name;

      Assert.AreEqual(customer, newOrder);
    }

    [TestMethod]
    public void Order_NewObjectShouldContainItsValues_Int()
    {
      int price = 6;
      Order order = new Order("string", "string", price, 0);
      int objNum = order.Price;

      Assert.AreEqual(price, objNum);
    }

    [TestMethod]
    public void GetAllOrders_ShouldReturnEmptyList_OrderList()
    {
      List<Order> order = new List<Order>{};
      List<Order> empty = Order.GetAllOrders();

      CollectionAssert.AreEqual(order, empty);
    }

    [TestMethod]
    public void GetAllOrders_ShouldReturnOrdersInList_OrderList()
    {
      string name = "Bob";
      string decription = "2 loafs of bread";
      Order firstOrder = new Order(name, "string", 0, 0);
      Order secondOrder = new Order("string", decription, 0, 0);
      List<Order> list = new List<Order> { firstOrder, secondOrder };
      List<Order> details = Order.GetAllOrders();
      
      CollectionAssert.AreEqual(list, details);
    }
  }
}