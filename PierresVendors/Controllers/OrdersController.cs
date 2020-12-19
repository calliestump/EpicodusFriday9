using Microsoft.AspNetCore.Mvc;
using PierresVendor.Models;
using System.Collections.Generic;

namespace PierresVendor.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId}/orders{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order vendorOrder = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", vendorOrder);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}