using tyuiu.oop.SidorovAY.NetCoreWebAppMVC.DataModels;

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.Models
{
    public class PersonMix
    {
        public string? Name { get; set; }
        public string? OtherName { get; set; }
        public IList<Person> Children { get; set; }
    }
}
