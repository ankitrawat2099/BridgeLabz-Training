using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    
    public interface ITrackable
    {
        //track workout method declaration
        void TrackWorkout();
        //method declaration for calculate calories
        int CalculateCalories();
    }
}
