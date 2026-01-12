using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal class MaxRevenueCutting:IWoodCuttingStrategy
    {
        //method to max revenue
        public int GetMaxRevenue(int length, int[] prices, int allowedWaste) {
            int[] dp = new int[length + 1];
            for (int i = 1; i <= length; i++)
            {
                int max = 0;
                for (int cut = 1; cut <= i; cut++)
                {
                    max = Math.Max(max, prices[cut] + dp[i - cut]);
                }
                dp[i] = max;
            }
            return dp[length];
        }
    }
}
