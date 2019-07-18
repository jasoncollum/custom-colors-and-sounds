using System;
using System.Collections.Generic;

namespace custom_colors_and_sounds
{
    public class GasStation : IStation<GasPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<GasPowered> vehicles)
        {
            vehicles.ForEach(vehicle =>
            {
                Console.WriteLine($"{vehicle.Name} is refueling...");
            });
        }
    }
}