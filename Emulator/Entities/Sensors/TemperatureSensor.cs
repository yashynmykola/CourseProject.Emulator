using Emulator.Constants;
using Emulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Sensors
{
    public class TemperatureSensor : Sensor
    {
        public override string Unit => "°C";

        public override SensorType Type => SensorType.Temperature;
        public TemperatureSensor(string name, string description)
            : base(name, description) { }
        
        public override void ReadValue()
        {
            Value = new Random().NextDouble() * SystemConstants.MaxTemperature;
            Console.WriteLine($"{Name} Temperature: {Value} {Unit}");
        }
    }
}