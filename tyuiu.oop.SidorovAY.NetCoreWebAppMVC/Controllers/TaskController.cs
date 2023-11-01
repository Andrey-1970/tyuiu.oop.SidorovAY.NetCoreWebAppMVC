using Microsoft.AspNetCore.Mvc;
using tyuiu.oop.SidorovAY.NetCoreWebAppMVC.DataModels;

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.Controllers
{
    public class TaskController : Controller
    {
        private readonly MyDBContext context;

        public TaskController(MyDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Tasks.Where(task => task.Id == 1).OrderBy(x => x.Name));
        }
        public IActionResult Index2()
        {
            return View(context.Tasks.FirstOrDefault(task => task.Id == 1));
        }
    }
}
