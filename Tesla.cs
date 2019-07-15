using System;

namespace custom_colors_and_sounds
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging battery...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla doesn't make a sound ... ");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla is veering {direction}...");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla has come to a stop...");
        }
    }
}