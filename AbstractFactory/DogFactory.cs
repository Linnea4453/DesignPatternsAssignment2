namespace Assignment2.AbstractFactory
{
    public class DogFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Dog(name);
        }
    }
}