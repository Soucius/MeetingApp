using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers {
    public class HomeController: Controller {
        public IActionResult Index() {
            int saat = DateTime.Now.Hour;

            // ViewBag.Selamlama = saat > 12 ? "Iyi Gunler" : "Gunaydin";
            // ViewBag.Username = "Soucius";

            ViewData["Selamlama"] = saat > 12 ? "Iyi Gunler" : "Gunaydin";
            ViewData["Username"] = "Soucius";

            return View();
        }
    }
}