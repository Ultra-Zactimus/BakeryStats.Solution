using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryStatistics.Models;

namespace BakeryStatistics.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/customers")]
    public ActionResult Index()
    {
      List<Vendor> allCustomers = Vendor.GetAllCustomers();
      return View(allCustomers);
    }

    [HttpGet("/customers/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/customers")]
    public ActionResult Create(string customerName)
    {
      Vendor newVendor = new Vendor(customerName);
      return RedirectToAction("Index");
    }

    [HttpGet("/customers/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedCustomer = Vendor.FindId(id);
      List<Order> vendorOrders = selectedCustomer.Orders;
      model.Add("vendor", selectedCustomer);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/customers/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string name, string orderDetails, int price, int date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundCustomer = Vendor.FindId(vendorId);
      Order newClient = new Order(name, orderDetails, price, date);
      foundCustomer.AddOrders(newClient);
      List<Order> customerOrders = foundCustomer.Orders;
      model.Add("orders", customerOrders);
      model.Add("vendor", foundCustomer);
      return View("Show", model);
    }
  }
}