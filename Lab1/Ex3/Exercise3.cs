using System;
namespace Lab1.Ex3
{
    using System;

    public abstract class Instrument
    {
        public Instrument()
        {
            Console.WriteLine("Instrument constructor called");
        }

        public abstract void Play();
    }

    public class Brass : Instrument
    {
        public Brass()
        {
            Console.WriteLine("Brass constructor called");
        }

        public virtual void Blow()
        {
            Console.WriteLine("Brass Blow called");
        }

        public override void Play()
        {
            Blow(); // Typically, playing a brass instrument involves blowing into it.
            Console.WriteLine("Brass Play called");
        }
    }

    public class Trumpet : Brass
    {
        public Trumpet()
        {
            Console.WriteLine("Trumpet constructor called");
        }

        public override void Play()
        {
            base.Play(); // Calls Brass's Play method, which includes Blow
            Console.WriteLine("Trumpet sound!");
        }

        private new void Blow()
        {
            // Redefined Blow method specific to Trumpet, but not accessible outside
            Console.WriteLine("Trumpet Blow called");
        }
    }
}

