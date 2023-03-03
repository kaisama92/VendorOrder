using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class StoreTests : IDisposable
  {
    public void Dispose()
    {
      Store.ClearAll();
    }

    [TestMethod]
    public void StoreConstructor_CreatesInstanceOfStore_Store()
    {
      Store newStore = new Store();
      Assert.AreEqual(typeof(Store), newStore.GetType());
    }
  }
}