using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Bicycle : Vehicle, IWheel, ITransmission
    {

        double _wheelThickness;
        string _pedalKind;
        double _drivePath;
        double _driveTime;
        string _transmissionkind;
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
        public string TransmissionKind { get { return _transmissionkind; } set { _transmissionkind = StringCheck(value); } }

        public Bicycle(string pedalkind, double wheelthickness, string transmissionkind)
        {
            PedalKind = pedalkind;
            WheelThickness = wheelthickness;
            TransmissionKind = transmissionkind;
        }
        public Bicycle(string pedalkind, double wheelthickness, string transmissionkind, double drivepath, double drivetime) : this(pedalkind, wheelthickness, transmissionkind)
        {
            DrivePath = drivepath;
            DriveTime = drivetime;
        }

    }
}
