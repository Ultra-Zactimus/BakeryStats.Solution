using System;
using System.Collections.Generic;

namespace BakeryStatistics.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string OrderDetails { get; set; }
    public int Price { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order(string name, string orderDetails, int price, int day, int year)
    {
      Name = name;
      OrderDetails = orderDetails;
      Price = price;
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