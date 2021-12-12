namespace Assignment2.AbstractFactory
{
    public class Cat : ICat
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }
    }
}