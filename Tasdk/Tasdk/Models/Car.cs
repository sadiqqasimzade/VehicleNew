using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Car : Vehicle, ITransmission, IEngine, IWheel
    {
        byte _doorCount;
        string _vinCode;
        double _wheelThickness;
        int _horsePower;
        double _tankSize;
        double _currentOil;
        string _fuelType;
        string _transmissionKind;
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
        public byte DoorCount { get { return _doorCount; } set { _doorCount = (byte)ZeroOrNegativeCheck(value); } }
        public string VinCode
        {
            get { return _vinCode; }
            set
            {
                if (value.Length == 17) _vinCode = StringCheck(value);
                else throw new Exception("Must be 17 symbols");
            }
        } //todo
        public double WheelThickness { get { return _wheelThickness; } set { _wheelThickness = ZeroOrNegativeCheck(value); } }
        public int HorsePower { get { return _horsePower; } set { _horsePower = (int)ZeroOrNegativeCheck(value); } }
        public double TankSize { get { return _tankSize; } set { _tankSize = ZeroOrNegativeCheck(value); } }
        public double CurrentOil
        {
            get { return _currentOil; }
            set
            {
                if (value <= TankSize) _currentOil = NegativeCheck(value);
                else throw new Exception("Cant be greater than Tank size");
            }
        }
        public string FuelType { get { return _fuelType; } set { _fuelType = StringCheck(value); } }//todo
        public string TransmissionKind { get { return _transmissionKind; } set { _transmissionKind = StringCheck(value); } } //todo


        public Car(byte doorcount, string vincode, double wheelthickness, int horsepower, double tanksize, string fueltype, string transmissionkind)
        {
            DoorCount = doorcount;
            VinCode = vincode;
            WheelThickness = wheelthickness;
            HorsePower = horsepower;
            TankSize = tanksize;
            FuelType = fueltype;
            TransmissionKind = transmissionkind;
        }

        public Car(byte doorcount, string vincode, double wheelthickness, int horsepower, double tanksize, string fueltype, string transmissionkind, double currentoil, double drivepath, double drivetime) : this(doorcount, vincode, wheelthickness, horsepower, tanksize, fueltype, transmissionkind)
        {
            DrivePath = drivepath;
            DriveTime = drivetime;
            CurrentOil = currentoil;
        }

        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }

        public static string VinCodeInput()
        {
            string code;
            do
            {
                Console.Write("Vin code (17 chars):");
                code = Console.ReadLine();
                code.Trim().ToUpper();
            } while (code.Length != 17);
            return code;
        }
    }
}
