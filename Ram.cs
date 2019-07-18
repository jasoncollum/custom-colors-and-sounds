using System;

namespace custom_colors_and_sounds
{
    public class Ram : GasPowered
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Refueling tank...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by.  Vroooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram is turning {direction}...");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram has stopped...");
        }
    }
}