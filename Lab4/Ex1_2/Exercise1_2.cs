using System;
using System.Threading;

namespace Lab4.Ex1_2
{
	public class Exercise1_2
    {
            public static int sharedValue = 5;

            public static void IncrementValue()
            {

                int reg = sharedValue;
                Thread.Sleep(40);
                reg++;
                sharedValue = reg;
                Console.WriteLine($"Incremented to: {sharedValue}");

            }

            public static void DecrementValue()
            {

                int reg = sharedValue;
                Thread.Sleep(10);  // If we increase time hear and this time is upper than the time for IncreaseValue;
                // then we will obtain 4 every iteration. The inverse is true, if time of IncreaseValue is upper than time of DecreaseValue.
                reg--;
                sharedValue = reg;
                Console.WriteLine($"Decremented to: {sharedValue}");

            }
}
}

