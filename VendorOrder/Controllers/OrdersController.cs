using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorid}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderID}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("Orders", order);
      model.Add("Vendor", vendor);
      return View(model);
    }
  }
}