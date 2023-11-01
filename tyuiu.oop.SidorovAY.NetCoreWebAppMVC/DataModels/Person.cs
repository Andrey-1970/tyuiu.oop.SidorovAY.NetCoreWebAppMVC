namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.DataModels
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Person? Parent { get; set; }
        public IList<Person> Children { get; set; } = new List<Person>();
    }
}
