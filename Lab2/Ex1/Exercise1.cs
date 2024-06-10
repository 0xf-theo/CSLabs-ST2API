using System;
namespace Lab2.Ex1
{
	public class Exercise1
	{
        // PrimeEventArgs class inheriting from EventArgs
        public class PrimeEventArgs : EventArgs
        {
            private long _prime;

            public long Prime
            {
                get { return _prime; }
            }

            public PrimeEventArgs(long p) : base()
            {
                _prime = p;
            }
        }

        // PrimeSender class raising a PrimeEventArgs event
        public class PrimeSender
        {
            // Define the delegate for the event
            public delegate void PrimeEventHandler(object sender, PrimeEventArgs e);

            // Define the event based on the delegate
            public event PrimeEventHandler PrimeEvent;

            // Method to raise the event
            protected virtual void OnPrimeFound(long prime)
            {
                PrimeEvent?.Invoke(this, new PrimeEventArgs(prime));
            }

            // Method to calculate prime numbers
            public void CalculatePrimes(long limit)
            {
                for (long number = 2; number <= limit; number++)
                {
                    if (IsPrime(number))
                    {
                        OnPrimeFound(number);
                    }
                }
            }

            // Helper method to check if a number is prime
            private bool IsPrime(long number)
            {
                if (number < 2) return false;
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }
        }

        // PrimeReceiver class with a public action method
        public class PrimeReceiver
        {
            // Method to handle the event
            public void Action(object sender, PrimeEventArgs e)
            {
                Console.WriteLine($"Prime number found: {e.Prime}");
            }
        }
    }
}

