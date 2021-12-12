namespace Assignment2.AbstractFactory
{
    internal class Dog : IDog
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }
    }
}