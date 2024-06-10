using System;

namespace Lab3_Ex1
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
}
