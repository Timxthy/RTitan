using System;
namespace Q3
{

    public class Lorry : IDriveable
    {
        public int NumberOfWheels { get; private set; }
        public string FuelType { get; private set; }

        public Lorry(int numberOfWheels, string fuelType)
        {
            NumberOfWheels = numberOfWheels;
            FuelType = fuelType;
        }

        public void EngineOn()
        {
            Console.WriteLine("Lorry engine is now ON.");
        }

        public void MoveForwardAtKMPH(int speed)
        {
            Console.WriteLine($"Lorry is moving forward at {speed} KMPH.");
        }

        public void EngineOff()
        {
            Console.WriteLine("Lorry engine is now OFF.");
        }
    }
}

