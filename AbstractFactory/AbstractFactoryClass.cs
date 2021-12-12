using System;

namespace Assignment2.AbstractFactory
{
    public class AbstractFactoryClass
    {
        public IFactory GetFactory()
        {
            Console.WriteLine("create new factory?");
            Console.WriteLine("Type dog for dogfactory");
            Console.WriteLine("Type cat for catfactory");

            var animal = Console.ReadLine();

            if (animal.ToLower() == "dog")
            {
                Console.WriteLine($"creating {animal} factory");
                return new DogFactory();
            }
            else if (animal.ToLower() == "cat")
            {
                Console.WriteLine($"creating {animal} factory");
                return new CatFactory();
            }
            else
            {
                Console.WriteLine($"No {animal} factory found");
                return null;
            }
        }
    }
}