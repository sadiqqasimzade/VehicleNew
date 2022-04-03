using System;
using System.Collections.Generic;
using System.Text;
using Tasdk.Exceptions;
namespace Tasdk.Models
{
    class Plane : Vehicle, IEngine, IWheel
    {
        double _wingLength;
        int _horsePower;
        double _tankSize;
        double _currentOil;
        string _fuelType;
        double _wheelThickness;
        double _drivePath;
        double _driveTime;
        public override double DriveTime
        {
            get { return _driveTime; }
            set
            {
                _driveTime = NegativeCheck(value);
                AvarangeSpeed();
            }
        }
        public override double DrivePath { get { return _drivePath; } set { _drivePath = NegativeCheck(value); } }
        public double WingLength { get { return _wingLength; } set { _wingLength = ZeroOrNegativeCheck(value); } }
        public int HorsePower { get { return _horsePower; } set { _horsePower = (int)ZeroOrNegativeCheck(value); } }
        public double TankSize { get { return _tankSize; } set { _tankSize = ZeroOrNegativeCheck(value); } }
        public double CurrentOil
        {
            get { return _currentOil; }
            set
            {
                if (value < TankSize) _currentOil = NegativeCheck(value);
                else throw new Exception("Cant be greater than Tank size");
            }
        }
        public string FuelType { get { return _fuelType; } set { _fuelType = StringCheck(value); } }
        public double WheelThickness { get { return _wheelThickness; } set { _wheelThickness = ZeroOrNegativeCheck(value); } }


        public Plane(double winglength, int hoursepower, double tanksize, string fueltype, double wheelthickness)
        {
            WingLength = winglength;
            HorsePower = hoursepower;
            TankSize = tanksize;
            FuelType = fueltype;
            WheelThickness = wheelthickness;
        }
        public Plane(double winglength, int hoursepower, double tanksize, string fueltype, double wheelthickness, double currentoil, double drivetime, double drivepath) : this(winglength, hoursepower, tanksize, fueltype, wheelthickness)
        {
            CurrentOil = currentoil;
            DrivePath = drivepath;
            DriveTime = drivetime;
        }

        //RemainOilAmount
        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }


    }
}

