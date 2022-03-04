using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryStatistics.Models;

namespace BakeryStatistics.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Vendor_ShouldCreateInstanceOfObject_NewVendor()
    {
      Vendor pierre = new Vendor("string");
      Assert.AreEqual(typeof(Vendor), pierre.GetType());
    }
  }
}