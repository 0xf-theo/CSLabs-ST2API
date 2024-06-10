using Lab3_Ex2;
using System;

namespace Lab3_Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/*-------EXERCISE 2-------*/");
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Lion("Simba"));
            zoo.AddAnimal(new Cow("Bessie"));
            zoo.AddAnimal(new Snake("Slither"));
            zoo.AddAnimal(new Lizard("Lizzy"));
            zoo.AddAnimal(new Platypus("Perry"));

            Console.WriteLine("Making all animals walk:");
            zoo.MakeAllAnimalsWalk();
            Console.WriteLine();

            Console.WriteLine("Making all animals eat:");
            zoo.MakeAllAnimalsEat();
            Console.WriteLine();
            // Serialize the animals
            string filename = "zoo_data.json";
            zoo.Serialize(filename);
            Console.WriteLine("Animals have been serialized.");
            Console.WriteLine();

            // Clear the zoo and deserialize the animals
            zoo = new Zoo();
            zoo.Deserialize(filename);
            Console.WriteLine("Animals have been deserialized.");
            Console.WriteLine();

            // Display all animals
            Console.WriteLine("Displaying all animals:");
            zoo.DisplayAllAnimals();
            Console.WriteLine("/*-------------------------*/");
        }
    }
}
