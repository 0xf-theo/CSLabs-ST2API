using Lab3_Ex2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab3_Ex2
{
    public class Zoo
    {
        private List<IAnimal> animals;

        public Zoo()
        {
            animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
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
            var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new AnimalConverter() } };
            var jsonString = JsonSerializer.Serialize(animals, options);
            File.WriteAllText(filename, jsonString);
        }

        public void Deserialize(string filename)
        {
            var jsonString = File.ReadAllText(filename);
            animals = JsonSerializer.Deserialize<List<IAnimal>>(jsonString, new JsonSerializerOptions { Converters = { new AnimalConverter() } });
        }

        public void DisplayAllAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
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
            }
        }
    }

    public class AnimalConverter : JsonConverter<IAnimal>
    {
        public override IAnimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                var root = jsonDoc.RootElement;
                var type = root.GetProperty("Type").GetString();
                var json = root.GetProperty("Data").GetRawText();
                switch (type)
                {
                    case nameof(Lion): return JsonSerializer.Deserialize<Lion>(json, options);
                    case nameof(Cow): return JsonSerializer.Deserialize<Cow>(json, options);
                    case nameof(Snake): return JsonSerializer.Deserialize<Snake>(json, options);
                    case nameof(Lizard): return JsonSerializer.Deserialize<Lizard>(json, options);
                    case nameof(Platypus): return JsonSerializer.Deserialize<Platypus>(json, options);
                    default: throw new NotSupportedException($"Type {type} is not supported.");
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, IAnimal value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Type", value.GetType().Name);
            writer.WritePropertyName("Data");
            JsonSerializer.Serialize(writer, (object)value, options);
            writer.WriteEndObject();
        }
    }
}
