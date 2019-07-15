using System;

namespace custom_colors_and_sounds
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging battery...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero races by.  Vroooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero is turning {direction}...");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero is stopping...");
        }
    }
}