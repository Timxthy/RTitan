using System;

namespace Q3
{
    class Program
    {
        public static void Drive(IDriveable drive, int speed)
        {
            drive.EngineOn();
            drive.MoveForwardAtKMPH(speed);
            drive.EngineOff();
        }

        static void Main(string[] args)
        {
            // Create my car, it has 4 wheels, powered by petrol, and is not a hatchback.
            Car myCar = new Car(4, "PETROL", false);

            // Create my lorry, it has 6 wheels and is powered by diesel.
            Lorry myLorry = new Lorry(6, "DIESEL");

            int speed = 0; // Initialize speed to 0.
            bool engineOn = false; // Initialize engine status.

            while (true)
            {
                Console.Clear(); // Clear the console for a clean menu display.

                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Drive Car");
                Console.WriteLine("2. Drive Lorry");

                if (engineOn)
                {
                    Console.WriteLine("3. Turn Engine Off");
                    Console.WriteLine("4. Accelerate");
                    Console.WriteLine("5. Decelerate");
                }
                else
                {
                    Console.WriteLine("3. Turn Engine On");
                }

                Console.WriteLine("6. Exit");

                // Get user input.
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (!engineOn)
                        {
                            engineOn = true;
                            Console.WriteLine("Engine turned ON.");
                        }

                        Console.Write("Enter speed (KMPH): ");
                        if (int.TryParse(Console.ReadLine(), out speed))
                        {
                            Console.Clear(); // Clear the console for clean output.
                            Drive(myCar, speed); // Drive the car at the specified speed.
                        }
                        else
                        {
                            Console.WriteLine("Invalid speed. Please enter a valid number.");
                        }
                        break;

                    case "2":
                        if (!engineOn)
                        {
                            engineOn = true;
                            Console.WriteLine("Engine turned ON.");
                        }

                        Console.Write("Enter speed (KMPH): ");
                        if (int.TryParse(Console.ReadLine(), out speed))
                        {
                            Console.Clear(); // Clear the console for clean output.
                            Drive(myLorry, speed); // Drive the lorry at the specified speed.
                        }
                        else
                        {
                            Console.WriteLine("Invalid speed. Please enter a valid number.");
                        }
                        break;

                    case "3":
                        if (engineOn)
                        {
                            engineOn = false;
                            Console.WriteLine("Engine turned OFF.");
                        }
                        else
                        {
                            engineOn = true;
                            Console.WriteLine("Engine turned ON.");
                        }
                        break;

                    case "4":
                        if (engineOn)
                        {
                            if (speed > 0)
                            {
                                speed += 10; // Accelerate by 10 KMPH.
                                Console.WriteLine($"Speed increased to {speed} KMPH.");
                            }
                            else
                            {
                                Console.WriteLine("Vehicle must be moving to accelerate.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Engine must be ON to accelerate.");
                        }
                        break;

                    case "5":
                        if (engineOn)
                        {
                            if (speed > 0)
                            {
                                speed -= 10; // Decelerate by 10 KMPH.
                                Console.WriteLine($"Speed decreased to {speed} KMPH.");
                            }
                            else
                            {
                                Console.WriteLine("Vehicle must be moving to decelerate.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Engine must be ON to decelerate.");
                        }
                        break;

                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
