using Microsoft.AspNetCore.Mvc;

namespace PierresVendor.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    } 
  }
}