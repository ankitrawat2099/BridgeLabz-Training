using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    public class StrengthWorkout : Workout
    {
        //body for track workout method
        public override void TrackWorkout()
        {
            Console.WriteLine("Strength workout selected.");
        }
        //body for calcualte calories method 
        public override int CalculateCalories()
        {
            return durationMinutes * 5; // calories per minute
        }
    }
}
