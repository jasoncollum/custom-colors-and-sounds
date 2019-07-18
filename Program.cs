using System;
using System.Collections.Generic;

namespace custom_colors_and_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zero fxs = new Zero()
            // {
            //     MainColor = "blue"
            // };
            // Tesla modelS = new Tesla()
            // {
            //     MainColor = "red"
            // };
            // Cessna mx410 = new Cessna()
            // {
            //     MainColor = "white"
            // };
            // Ram truck = new Ram()
            // {
            //     MainColor = "grey"
            // };

            // fxs.Turn("left");
            // fxs.Turn("right");
            // fxs.Stop();
            // modelS.Turn("left");
            // modelS.Turn("right");
            // modelS.Stop();
            // mx410.Turn("left");
            // mx410.Turn("right");
            // mx410.Stop();
            // truck.Turn("left");
            // truck.Turn("right");
            // truck.Stop();

            // Refueling Generics Exercises

            var electricVehicles = new List<ElectricPowered>(){
                new Zero(){Name = "Zero"},
                new Tesla(){Name = "Tesla"}
            };

            var gasVehicles = new List<GasPowered>(){
                new Ram(){Name = "Ram"},
                new Cessna(){Name = "Cessna"}
            };

            var shell = new GasStation();
            var bricks = new BatteryStation();

            shell.Refuel(gasVehicles);
            bricks.Refuel(electricVehicles);
        }
    }
}
