using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        #region Public Methods

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
