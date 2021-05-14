using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // for photos:
    // [Route("/favorite_photos")]
    // public ActionResult FavoritePhotos()
    // {
    //   return View();
    // }

  }
}