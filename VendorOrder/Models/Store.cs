using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Store
  {
    private static List<Store> _storeInstances = new List<Store> {};
    public int Id { get;}
    public string Name { get; set; }

    public Store(string name)
    {
      Name = name;
      _storeInstances.Add(this);
      Id = _storeInstances.Count;
    }

    public static void ClearAll()
    {
      _storeInstances.Clear();
    }
  }
}