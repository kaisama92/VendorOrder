using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Store
  {
    public int Id { get;}
    public string Name { get; set; }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}