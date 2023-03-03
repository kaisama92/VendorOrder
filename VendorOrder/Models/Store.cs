using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Store
  {
    private static List<Store> _instances = new List<Store> {};
    public int Id { get;}
    public string Name { get; set; }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}