using System;
using System.Xml.Linq;

namespace Lab3_Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/*-------EXERCISE 1-------*/");
            IAnimal[] animals = {
                new Lion("Simba"),
                new Cow("Bessie"),
                new Snake("Slither"),
                new Lizard("Lizzy"),
                new Platypus("Perry")
            };

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine($"Testing {animal.Name}:");
                animal.Move();
                animal.Eat();

                if (animal is IMammal mammal)
                {
                    mammal.Nurse();
                }

                if (animal is IReptile reptile)
                {
                    reptile.ShedSkin();
                }

                Console.WriteLine();
            }
            Console.WriteLine("/*-------------------------*/");
        }
    }
}
