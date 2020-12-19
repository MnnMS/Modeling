using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingMachineModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {

        }

        public decimal BearingCost { get; set; }
        public decimal DelayCost { get; set; }
        public decimal DowntimeCost { get; set; }
        public decimal RepairPersonCost { get; set; }
        public decimal TotalCost { get; set; }

        public void calcPerformance(SimulationSystem system, int repairTime)
        {
            BearingCost = SystemHelper.totalNoChangedBearings * system.BearingCost;
            DelayCost = SystemHelper.totalDelayOfBearings * system.DowntimeCost;
            DowntimeCost = SystemHelper.totalNoChangedBearings * repairTime * system.DowntimeCost;
            RepairPersonCost = SystemHelper.totalNoChangedBearings * repairTime * system.RepairPersonCost / 60;
            TotalCost = BearingCost + DelayCost + DowntimeCost + RepairPersonCost;
        }
    }
}
