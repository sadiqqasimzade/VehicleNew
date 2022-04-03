using System;
using System.Collections.Generic;
using System.Text;
using Tasdk.Exceptions;
namespace Tasdk.Models
{
    abstract class Vehicle
    {

        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }

        public double AvarangeSpeed()
        {
            try
            {
                return Math.Round(DrivePath / DriveTime, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        static public double NegativeCheck(double value)
        {
            if (value >= 0)
                return value;
            else throw new NegativeException("Cant be Negative");
        }
        static public double ZeroOrNegativeCheck(double value)
        {
            if (value > 0)
                return value;
            else throw new ZeroOrNegativeException("Cant be Zero or Negative");
        }
        static public string StringCheck(string str)
        {
            if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str)) throw new NullReferenceException("Must contain value");
            else return str;
        }
    }
}
