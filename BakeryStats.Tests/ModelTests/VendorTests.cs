using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryStatistics.Models;

namespace BakeryStatistics.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Vendor_ShouldCreateInstanceOfObject_NewVendor()
    {
      Vendor name = new Vendor("John");

      Assert.AreEqual(typeof(Vendor), name.GetType());
    }

    [TestMethod]
    public void Vendor_ShouldCreateInstanceWithValues_String()
    {
      string name = "April";
      Vendor vendor = new Vendor(name);
      string getInfo = vendor.Name;

      Assert.AreEqual(name, getInfo);
    }

    [TestMethod]
    public void GetThatID_ShouldBeAbleToGrabIdOfOrder_Int()
    {
      string newName = "Michael";
      Vendor vendor = new Vendor(newName);
      int didItWork = vendor.Id;

      Assert.AreEqual(1, didItWork);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAllCustomersInList_VendorList()
    {
      string example1 = "Cloud";
      string example2 = "Tifa";
      Vendor container1 = new Vendor(example1);
      Vendor containter2 = new Vendor(example2);
      List<Vendor> _instances = new List<Vendor> { container1, containter2 };
      List<Vendor> info = Vendor.GetAll();

      CollectionAssert.AreEqual(info, _instances);
    }

    [TestMethod]
    public void Find_ShouldReturnTheCorrectObject_Int()
    {
      string name1 = "Billy";
      string name2 = "Fatima";
      Vendor first = new Vendor(name1);
      Vendor second = new Vendor(name2);
      Vendor getThat = Vendor.Find(2);

      Assert.AreEqual(second, getThat);
    }

    [TestMethod]
    public void AddOrder_VendorShouldBeAbleToPullFromOrderList_OrderList()
    {
      DateTime date = new DateTime(1986,03,10);
      string orderDetails = "5 pastries";
      Order order = new Order(orderDetails, 0, date);
      List<Order> ordersList = new List<Order> { order };
      string name = "Claire";
      Vendor vendor = new Vendor(name);
      vendor.AddOrder(order);
      List<Order> list = vendor.Orders;

      CollectionAssert.AreEqual(ordersList, list);
    }
  }
}