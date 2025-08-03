using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Overview()
        {
            var item = new Item() { Name = "Keyboard" };
            return View(item);
        }
    }
}
