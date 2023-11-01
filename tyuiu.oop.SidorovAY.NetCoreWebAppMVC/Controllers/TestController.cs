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
            //var persons = from r in (
            //                  from person in _context.Persons
            //                  where person.Parent == null
            //                  join otherperson in _context.Persons on person.Id equals otherperson.Id into aa
            //                  from a in aa.DefaultIfEmpty()
            //                  select new PersonMix
            //                  {
            //                      Name = person.Name,
            //                      OtherName = "otherperson.Name",
            //                      Children = person.Children
            //                  })
            //              select r;
            //var persons = from r in (
            //                  from person in _context.Persons
            //                  from otherperson in _context.Persons
            //                 where person.Id == otherperson.Id
            //                    && person.Parent == null
            //                select new PersonMix
            //                {
            //                    Name = person.Name,
            //                    OtherName = otherperson.Name,
            //                    Children = person.Children
            //                })
            //                where r.Name == "Иванов"
            //select r;
            
            var person = new Person() { Name = "Сидоров"};
            _context.Persons.Add(person);
            _context.SaveChanges();
            
            var persons = from x in _context.Persons
                          where x.Parent == null
                          select new PersonMix
                            {
                                Name = x.Name,
                                OtherName = "",
                                Children = x.Children
                            };
            return View(persons);
        }
    }
}
