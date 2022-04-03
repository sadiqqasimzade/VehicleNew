using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Bicycle : Vehicle, IWheel
    {

        double _wheelThickness;
        string _pedalKind;
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
        public string PedalKind { get { return _pedalKind; } set { _pedalKind = StringCheck(value); } } //auto manual
        public double WheelThickness { get { return _wheelThickness; } set { _wheelThickness = ZeroOrNegativeCheck(value); } }

        public Bicycle(string pedalkind, double wheelthickness)
        {
            PedalKind = pedalkind;
            WheelThickness = wheelthickness;
        }
        public Bicycle(string pedalkind, double wheelthickness, double drivepath, double drivetime) : this(pedalkind, wheelthickness)
        {
            DrivePath = drivepath;
            DriveTime = drivetime;
        }

    }
}
