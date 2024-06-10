using System;
using System.Threading;

namespace Lab4.Ex1_3
{
    public class Exercise1_3
    {
        public static int sharedValue = 5;
        public static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);  // Sémaphore initialisé avec une capacité de 1

        public static void IncrementValue()
        {
            semaphore.Wait();
            try
            {
                int reg = sharedValue;
                Thread.Sleep(10);
                reg++;
                sharedValue = reg;
                Console.WriteLine($"Incremented to: {sharedValue}");
            }
            finally
            {
                semaphore.Release();
            }
        }

        public static void DecrementValue()
        {
            semaphore.Wait();
            try
            {
                int reg = sharedValue;
                Thread.Sleep(10);
                reg--;
                sharedValue = reg;
                Console.WriteLine($"Decremented to: {sharedValue}");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}

