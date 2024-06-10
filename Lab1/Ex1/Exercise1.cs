using System;
namespace Lab1.Ex1
{
    public class Exercise1
    {
        private static int count = 0;
        private int instanceNumber;

        public Exercise1()
        {
            count++;
            instanceNumber = count;
        }

        public override string ToString()
        {
            return $"Object from class X (number {instanceNumber})";
        }
    }
}
