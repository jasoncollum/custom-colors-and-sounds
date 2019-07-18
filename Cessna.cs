using System;

namespace custom_colors_and_sounds
{
    public class Cessna : GasPowered
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Refueling tank...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flys overhead.  Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna is banking {direction}...");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna has landed...");
        }
    }
}