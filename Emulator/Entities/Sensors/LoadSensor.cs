using Emulator.Constants;
using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class LoadSensor : Sensor
    {
        public override string Unit => "kg";
        public override SensorType Type => SensorType.Speed;

        public LoadSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * SystemConstants.MaxLoad;
            Console.WriteLine($"{Name} Load: {Value} {Unit}");
        }
    }
}