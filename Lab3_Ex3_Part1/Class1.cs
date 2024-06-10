using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Lab3_Ex3_Part1
{
    public class Zoo
    {
        private List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void MakeAllAnimalsWalk()
        {
            foreach (var animal in animals)
            {
                animal.Move();
            }
        }

        public void MakeAllAnimalsEat()
        {
            foreach (var animal in animals)
            {
                animal.Eat();
            }
        }

        public void Serialize(string filename)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(animals, options);
            File.WriteAllText(filename, jsonString);
        }

        public void Deserialize(string filename)
        {
            var jsonString = File.ReadAllText(filename);
            animals = JsonSerializer.Deserialize<List<Animal>>(jsonString);
        }

        public void DisplayAllAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
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
            }
        }
    }
}
