using Microsoft.AspNetCore.Mvc;

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
