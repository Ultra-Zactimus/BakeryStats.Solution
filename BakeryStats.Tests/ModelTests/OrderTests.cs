using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryStatistics.Models;

namespace BakeryStatistics.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_ItShouldCreateInstanceOfObject_NewOrder()
    {
      Order order = new Order("blah", "blahblah", 0, 0);
      Assert.AreEqual(typeof(Order), order.GetType());
    }
  }
}