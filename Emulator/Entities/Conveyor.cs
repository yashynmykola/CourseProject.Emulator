using Emulator.Entities.Sensors;
using Emulator.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities
{
    public class Conveyor
    {
        public List<Sensor> Sensors { get; set; }
        public ConveyorControlSystem ControlSystem { get; set; }

        public Conveyor()
        {
            Sensors = new List<Sensor>();
            ControlSystem = new ConveyorControlSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors) 
            { 
                sensor.ReadValue(); 
            }
        }
    }
}