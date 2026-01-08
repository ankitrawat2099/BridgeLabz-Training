using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    class Fan : IControllable
    {
        //method for turn on fan
        public void TurnOn()
        {
            Console.WriteLine("Fan turned ON at medium speed.");
        }
        //method for turn off fan
        public void TurnOff()
        {
            Console.WriteLine("Fan turned OFF.");
        }
    }
}
