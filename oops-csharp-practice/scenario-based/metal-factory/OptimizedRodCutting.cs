using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory
{
     class OptimizedRodCutting:IRodCuttinngStrategy
    {
        public int GetMaxRevenue(int length, int[] prices)
        {
            int[]dp=new int[length+1];
            for (int i = 1; i < length; i++)
            {
                int max = 0;
                for(int cut = 1; cut <= i; cut++)
                {
                    max=Math.Max(max,prices[cut]+ dp[i-cut]);
                }
                dp[i] = max;
            }
            return dp[length];
        }
    }
}
