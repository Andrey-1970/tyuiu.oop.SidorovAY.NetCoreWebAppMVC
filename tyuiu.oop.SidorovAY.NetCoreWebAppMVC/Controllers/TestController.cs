using Microsoft.AspNetCore.Mvc;
using tyuiu.oop.SidorovAY.NetCoreWebAppMVC.DataModels;
using tyuiu.oop.SidorovAY.NetCoreWebAppMVC.Models;

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.Controllers
{
    public class TestController : Controller
    {
        private readonly MyDBContext _context;

        public TestController(MyDBContext _context)
        {
            this._context = _context;
        }
        public IActionResult Index()
        {
            var persons = from person in _context.Persons
                          from otherperson in _context.Persons
                          where person.Id == otherperson.Id
                             && person.Parent == null
                          select new PersonMix
                          {
                              Name = person.Name,
                              OtherName = otherperson.Name,
                              Children = person.Children
                          };
            return View(persons);
        }
    }
}
