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
      Vendor month = new Vendor("January");

      Assert.AreEqual(typeof(Vendor), month.GetType());
    }

    [TestMethod]
    public void Vendor_ShouldCreateInstanceWithValues_String()
    {
      string month = "Febuary";
      Vendor vendor = new Vendor(month);
      string getInfo = vendor.Month;

      Assert.AreEqual(month, getInfo);
    }

    [TestMethod]
    public void GetThatID_ShouldBeAbleToGrabIdOfOrder_Int()
    {
      string newMonth = "March";
      Vendor pierre = new Vendor(newMonth);
      int didItWork = pierre.Id;

      Assert.AreEqual(1, didItWork);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAllCustomersInList_VendorList()
    {
      string example1 = "April";
      string example2 = "May";
      Vendor container1 = new Vendor(example1);
      Vendor containter2 = new Vendor(example2);
      List<Vendor> _instances = new List<Vendor> { container1, containter2 };
      List<Vendor> info = Vendor.GetAll();

      CollectionAssert.AreEqual(info, _instances);
    }
    
    [TestMethod]
    public void Find_ShouldReturnTheCorrectObject_Int()
    {
      string winter = "December";
      string fall = "September";
      Vendor first = new Vendor(winter);
      Vendor second = new Vendor(fall);
      Vendor getThat = Vendor.Find(2);

      Assert.AreEqual(second, getThat);
    }

    [TestMethod]
    public void AddOrder_VendorShouldBeAbleToPullFromOrderList_OrderList()
    {
      string orderDetails = "5 pastries";
      Order order = new Order("string", orderDetails, 0, 0, 0);
      List<Order> ordersList = new List<Order>{ order };
      string month = "July";
      Vendor vendor = new Vendor(month);
      vendor.AddOrder(order);
      List<Order> list = vendor.Orders;

      CollectionAssert.AreEqual(ordersList, list);
    }
  }
}