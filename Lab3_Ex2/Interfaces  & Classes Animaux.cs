using System;

namespace Lab3_Ex2
{
    // Step 1: Define the IAnimal interface
    public interface IAnimal
    {
        string Name { get; }
        void Move();
        void Eat();
    }

    // Step 2: Define the IMammal and IReptile interfaces
    public interface IMammal : IAnimal
    {
        void Nurse();
    }

    public interface IReptile : IAnimal
    {
        void ShedSkin();
    }

    // Step 3: Define several animal classes
    public class Lion : IMammal
    {
        public string Name { get; private set; }

        public Lion(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} the lion moves gracefully.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} the lion eats meat.");
        }

        public void Nurse()
        {
            Console.WriteLine($"{Name} the lion nurses its cubs.");
        }
    }

    public class Cow : IMammal
    {
        public string Name { get; private set; }

        public Cow(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} the cow walks slowly.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} the cow eats grass.");
        }

        public void Nurse()
        {
            Console.WriteLine($"{Name} the cow nurses its calves.");
        }
    }

    public class Snake : IReptile
    {
        public string Name { get; private set; }

        public Snake(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} the snake slithers.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} the snake eats mice.");
        }

        public void ShedSkin()
        {
            Console.WriteLine($"{Name} the snake sheds its skin.");
        }
    }

    public class Lizard : IReptile
    {
        public string Name { get; private set; }

        public Lizard(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} the lizard scurries.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} the lizard eats insects.");
        }

        public void ShedSkin()
        {
            Console.WriteLine($"{Name} the lizard sheds its skin.");
        }
    }

    public class Platypus : IMammal, IReptile
    {
        public string Name { get; private set; }

        public Platypus(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} the platypus swims.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} the platypus eats worms and insects.");
        }

        public void Nurse()
        {
            Console.WriteLine($"{Name} the platypus nurses its young.");
        }

        public void ShedSkin()
        {
            Console.WriteLine($"{Name} the platypus sheds its skin.");
        }
    }
}
