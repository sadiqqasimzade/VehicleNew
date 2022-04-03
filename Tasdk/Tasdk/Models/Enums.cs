using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    internal class Enums
    {
        public enum CarTransmissionTypes
        {Manual=1, Automatic, ContinuouslyVariable, DualClutch, SequentialManual, SemiAutomatic } //src:https://lemonbin.com/types-of-car-transmission/
        public enum BicycleTransmissionTypes
        {
            External=1, Crossover, MultiRange, Alpine, HalfStep, Internal, InternalAndExternalCombined
        }
        public enum PedalTypes
        {Flat=1, Quill, Clipless, Magnet, Folding }//src:https://en.wikipedia.org/wiki/Bicycle_pedal

        public enum CarFuelTypes
        {
            Petrol=1, Diesel,NaturalGas, BioDiesel, LiquidPetroleumGas, EthanolMethanol, Electric
        }//src:https://www.godigit.com/fuel/articles/types-of-fuels

        public enum PlaneFuelTypes
        {
            Jetfuel=1, avgas, Biokerosene
        }

    }
}
