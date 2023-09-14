using System;
namespace Q3
{
    public class Car : IDriveable
    {
        public int NumberOfWheels { get; private set; }
        public string FuelType { get; private set; }
        public bool IsHatchback { get; private set; }

        public Car(int numberOfWheels, string fuelType, bool isHatchback)
        {
            NumberOfWheels = numberOfWheels;
            FuelType = fuelType;
            IsHatchback = isHatchback;
        }

        public void EngineOn()
        {
            Console.WriteLine("Car engine is now ON.");
        }

        public void MoveForwardAtKMPH(int speed)
        {
            Console.WriteLine($"Car is moving forward at {speed} KMPH.");
        }

        public void EngineOff()
        {
            Console.WriteLine("Car engine is now OFF.");
        }
    }


}

