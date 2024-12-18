using Emulator.Constants;
using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class SpeedSensor : Sensor
    {
        public override string Unit => "m/s";
        public override SensorType Type => SensorType.Speed;

        public SpeedSensor(string name, string description)
            : base (name, description){}

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * SystemConstants.MaxSpeed;
            Console.WriteLine($"{Name} Speed: {Value} {Unit}");
        }
    }
}