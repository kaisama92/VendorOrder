using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public int Id { get;}
    public string Products { get; set; }
    public Order(string orderTitle, string products)
    {
      Title = orderTitle;
      Products = products;
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