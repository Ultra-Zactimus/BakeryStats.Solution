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
      Vendor pierre = new Vendor("string");

      Assert.AreEqual(typeof(Vendor), pierre.GetType());
    }

    [TestMethod]
    public void Vendor_ShouldCreateInstanceWithValues_String()
    {
      string name = "Lily";
      Vendor pierre = new Vendor(name);
      string getInfo = pierre.Customer;

      Assert.AreEqual(name, getInfo);
    }

    [TestMethod]
    public void GetThatID_ShouldBeAbleToGrabIdOfOrder_Int()
    {
      string newCustomer = "Michael";
      Vendor pierre = new Vendor(newCustomer);
      int didItWork = pierre.Id;

      Assert.AreEqual(1, didItWork);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAllCustomersInList_VendorList()
    {
      string example1 = "Yetzirah";
      string example2 = "Raziel";
      Vendor container1 = new Vendor(example1);
      Vendor containter2 = new Vendor(example2);
      List<Vendor> _instances = new List<Vendor> { container1, containter2 };
      List<Vendor> info = Vendor.GetAll();

      CollectionAssert.AreEqual(info, _instances);
    }
    
    [TestMethod]
    public void Find_ShouldReturnTheCorrectObject_Int()
    {
      string amigo1 = "Jenna";
      string amigo2 = "Joshua";
      Vendor first = new Vendor(amigo1);
      Vendor second = new Vendor(amigo2);
      Vendor getThat = Vendor.Find(2);

      Assert.AreEqual(second, getThat);
    }

    [TestMethod]
    public void AddOrder_VendorShouldBeAbleToPullFromOrderList_OrderList()
    {
      string orderDetails = "5 pastries";
      Order order = new Order("string", orderDetails, 0, 0);
      List<Order> ordersList = new List<Order>{ order };
      string custName = "Josh Maoa";
      Vendor pierre = new Vendor(custName);
      pierre.AddOrder(order);
      List<Order> list = pierre.Orders;

      CollectionAssert.AreEqual(ordersList, list);
    }
  }
}