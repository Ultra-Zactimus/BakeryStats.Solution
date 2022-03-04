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
      Vendor.ClearAllCustomers();
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
    public void GetAllCustomers_ShouldReturnAllCustomersInList_VendorList()
    {
      string example1 = "Yetzirah";
      string example2 = "Raziel";
      Vendor container1 = new Vendor(example1);
      Vendor containter2 = new Vendor(example2);
      List<Vendor> _instances = new List<Vendor> { container1, containter2 };
      List<Vendor> info = Vendor.GetAllCustomers();

      CollectionAssert.AreEqual(info, _instances);
    }
    
  }
}