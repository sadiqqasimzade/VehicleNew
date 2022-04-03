using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

        public double RemainOilAmount();

    }
}
