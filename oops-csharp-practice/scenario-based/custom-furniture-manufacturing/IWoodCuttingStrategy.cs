using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal interface IWoodCuttingStrategy
    {
        int GetMaxRevenue(int length, int[] prices, int allowedWaste);
    }
}
