using Emulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Entities.Systems
{
    public class ConveyorControlSystem : IControllable
    {
        public bool IsOn { get; private set; }

        public void Start()
        {
            IsOn = true;
            Console.WriteLine("Conveyor system started.");
        }
        public void Stop()
        {
            IsOn = false;
            Console.WriteLine("Conveyor system stopped.");

        }
    }
}
