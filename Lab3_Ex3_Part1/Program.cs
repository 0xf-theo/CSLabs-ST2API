using System;
using System.Xml.Linq;

namespace Lab3_Ex3_Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/*------EXERCISE 3.1------*/");
            Animal[] animals = {
                new Lion("Simba"),
                new Cow("Bessie"),
                new Snake("Slither"),
                new Lizard("Lizzy"),
                new Platypus("Perry")
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Testing {animal.Name}:");
                animal.Move();
                animal.Eat();

                if (animal is Mammal mammal)
                {
                    mammal.Nurse();
                }

                if (animal is Reptile reptile)
                {
                    reptile.ShedSkin();
                }

                Console.WriteLine();
            }
            Console.WriteLine("/*-------------------------*/");
        }
    }
}
