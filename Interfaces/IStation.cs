using System;
using System.Collections.Generic;

namespace custom_colors_and_sounds
{
    interface IStation<T>
    {
        int Capacity { get; set; }
        void Refuel(List<T> vehicles);
    }
}