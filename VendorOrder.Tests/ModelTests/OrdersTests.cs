using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "february";
      string products = "apples";
      Order newOrder = new Order(title, products);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "february";
      string products = "apples";
      Order newOrder = new Order(title, products);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetsOrderTitle_String()
    {
      string title = "february";
      string products = "apples";
      Order newOrder = new Order(title, products);
      string newTitle = "march";
      newOrder.Title = newTitle;
      string result = newOrder.Title;
      Assert.AreEqual(newTitle, result);
    }

    [TestMethod]
    public void GetProducts_ReturnsOrderProduct_String()
    {
      string title = "february";
      string products = "apples";
      Order newOrder = new Order(title, products);
      string result = newOrder.Products;
      Assert.AreEqual(products, result);
    }

    [TestMethod]
    public void SetProducts_SetsOrderProducts_String()
    {
      string title = "february";
      string products = "apples";
      Order newOrder = new Order(title, products);
      string newProduct = "oranges";
      newOrder.Products = newProduct;
      string result = newOrder.Products;
      Assert.AreEqual(newProduct, result);
    }
  }
}