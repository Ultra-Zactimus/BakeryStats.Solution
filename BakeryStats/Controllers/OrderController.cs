using Microsoft.AspNetCore.Mvc;
using BakeryStatistics.Models;
using System.Collections.Generic;

namespace BakeryStatistics.Controllers
{
  public class OrderControllers : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.FindId(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders/delete")]
    public ActionResult Delete()
    {
      Order.ClearAllOrders();
      return View();
    }

    [HttpGet("/vendors/{vendorsId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindIt(orderId);
      Vendor vendor = Vendor.FindId(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}