using System;
using System.Collections.Generic;

namespace BakeryStatistics.Models
{
  public class Order
  {
    public string Customer { get; set; }
    public string OrderDetails { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    private static List<Order> _instances = new List<Order>{};

    public Order(string customer, string orderDetails, int price, int date)
    {
      Customer = customer;
      OrderDetails = orderDetails;
      Price = price;
      Date = date;
      _instances.Add(this);
    }
  }
}