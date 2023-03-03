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
      string vendorDescription = "Restaurant";
      Vendor newVendor = new Vendor(name, vendorDescription);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorsName_String()
    {
      string name = "vendor name";
      string vendorDescription = "Restaurant";
      Vendor newVendor = new Vendor(name, vendorDescription);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetVendorName_SetsVendorName_String()
    {
      string name = "vendor name";
      string vendorDescription = "Restaurant";
      Vendor newVendor = new Vendor(name, vendorDescription);
      string updatedName = "updated name";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      string name = "vendor name";
      string vendorDescription = "Restaurant";
      Vendor newVendor = new Vendor(name, vendorDescription);
      string result = newVendor.Description;
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void SetDescription_SetsVendorDescription_String()
    {
      string name = "vendor name";
      string vendorDescription = "Restaurant";
      Vendor newVendor = new Vendor(name, vendorDescription);
      string newDescription = "Caterer";
      newVendor.Description = newDescription;
      string result = newVendor.Description;
      Assert.AreEqual(newDescription, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorID_Int()
    {
      string name = "vendor name";
      string vendorDescription = "Restaurant";
      Vendor newVendor = new Vendor(name, vendorDescription);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendor_Vendor()
    {
      string name1 = "vendor1";
      string name2 = "vendor2";
      string description1 = "restaurant";
      string description2 = "caterer";
      Vendor vendor1 = new Vendor(name1, description1);
      Vendor vendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> {vendor1, vendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "vendor1";
      string name2 = "vendor2";
      string description1 = "restaurant";
      string description2 = "caterer";
      Vendor vendor1 = new Vendor(name1, description1);
      Vendor vendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(vendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "february";
      string products = "apples";
      Order newOrder = new Order(title, products);
      List<Order> orderList = new List<Order> {newOrder};
      string name = "vendor";
      string description = "restaurant";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(orderList, result); 
      
    }
  }
}