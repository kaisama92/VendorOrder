using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "vendor name";
      Vendor newVendor = new Vendor(name);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}