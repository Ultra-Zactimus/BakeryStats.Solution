using System.Collections.Generic;

namespace BakeryStatistics.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Customer { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string customerName)
    {
      Customer = customerName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static void ClearAllCustomers()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAllCustomers()
    {
      return _instances;
    }
    public static Vendor FindId(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrders(Order order)
    {
      Orders.Add(order);
    }
  }
}