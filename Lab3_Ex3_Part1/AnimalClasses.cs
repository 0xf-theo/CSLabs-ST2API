using System;

namespace Lab3_Ex3_Part1
{
    // Base Animal class
    public class Animal
    {
        private string _name;

        public string Name => _name;

        public Animal(string name)
        {
            _name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Mammal class derived from Animal
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }

        public virtual void Nurse()
        {
            Console.WriteLine($"{Name} is nursing.");
        }
    }

    // Reptile class derived from Animal
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name) { }

        public virtual void ShedSkin()
        {
            Console.WriteLine($"{Name} is shedding its skin.");
        }
    }

    // Specific animal classes
    public class Lion : Mammal
    {
        public Lion(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} the lion moves gracefully.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the lion eats meat.");
        }

        public override void Nurse()
        {
            Console.WriteLine($"{Name} the lion nurses its cubs.");
        }
    }

    public class Cow : Mammal
    {
        public Cow(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} the cow walks slowly.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the cow eats grass.");
        }

        public override void Nurse()
        {
            Console.WriteLine($"{Name} the cow nurses its calves.");
        }
    }

    public class Snake : Reptile
    {
        public Snake(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} the snake slithers.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the snake eats mice.");
        }

        public override void ShedSkin()
        {
            Console.WriteLine($"{Name} the snake sheds its skin.");
        }
    }

    public class Lizard : Reptile
    {
        public Lizard(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} the lizard scurries.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the lizard eats insects.");
        }

        public override void ShedSkin()
        {
            Console.WriteLine($"{Name} the lizard sheds its skin.");
        }
    }

    public class Platypus : Mammal
    {
        public Platypus(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine($"{Name} the platypus swims.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the platypus eats worms and insects.");
        }

        public override void Nurse()
        {
            Console.WriteLine($"{Name} the platypus nurses its young.");
        }

        public void ShedSkin()
        {
            Console.WriteLine($"{Name} the platypus sheds its skin.");
        }
    }
}
