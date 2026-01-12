using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory
{
    internal class NonOptimizedRodCutting:IRodCuttinngStrategy
    {
        public int GetMaxRevenue(int length, int[] prices)
        {
            return prices[length];
        }
    
    }
}
