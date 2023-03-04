using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/create")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> Orders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", Orders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorid}/orders")]
    public ActionResult Create(int id, string orderTitle, string products)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(id);
      Order newOrder = new Order(orderTitle, products);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("Vendor", foundVendor);
      model.Add("Orders", vendorOrders);
      return View("Show", model);
    }
  }
}