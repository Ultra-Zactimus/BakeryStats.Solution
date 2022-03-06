using System;
using System.Collections.Generic;

namespace BakeryStatistics.Models
{
  public class Order
  {
    public string OrderDetails { get; set; }
    public int Price { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order(string orderDetails, int price, int month, int day, int year)
    {
      OrderDetails = orderDetails;
      Price = price;
      Month = month;
      Day = day;
      Year = year;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}