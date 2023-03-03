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
      string name = "Pierre's";
      Store newStore = new Store(name);
      Assert.AreEqual(typeof(Store), newStore.GetType());
    }

    [TestMethod]
    public void GetStoreName_ReturnsStoreName_String()
    {
      string name = "Pierre's";
      Store pierre = new Store(name);
      string result = pierre.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetStoreName_SetsStoreName_String()
    {
      string name = "Pierre's";
      string updatedName = "John's";
      Store pierre = new Store(name);
      pierre.Name = updatedName;
      string result = pierre.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetId_ReturnsStoreId_Int()
    {
      string name = "Pierre's";
      Store pierre = new Store(name);
      int result = pierre.Id;
      Assert.AreEqual(1, result);
    }

  }
}