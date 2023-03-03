using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor : Store
  {
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name)
    {
      Name = name;
    }

  }
}