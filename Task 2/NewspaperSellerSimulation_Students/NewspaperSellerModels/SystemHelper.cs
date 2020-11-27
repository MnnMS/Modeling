using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public static class SystemHelper
    {
        public static List<DayTypeDistribution> Cal_DayDistribution(List<DayTypeDistribution> dayTypeDistributionTable)
        {
            dayTypeDistributionTable[0].CummProbability = dayTypeDistributionTable[0].Probability;
            dayTypeDistributionTable[0].MinRange = 1;
            dayTypeDistributionTable[0].MaxRange = (int)(dayTypeDistributionTable[0].CummProbability * 100);

            for (int i = 1; i < dayTypeDistributionTable.Count; i++)
            {
                dayTypeDistributionTable[i].CummProbability = dayTypeDistributionTable[i].Probability + dayTypeDistributionTable[i - 1].CummProbability;
                dayTypeDistributionTable[i].MinRange = (dayTypeDistributionTable[i - 1].MaxRange) + 1;
                dayTypeDistributionTable[i].MaxRange = (int)(dayTypeDistributionTable[i].CummProbability * 100);
            }
            return dayTypeDistributionTable;
        }
        public static List<DemandDistribution> Cal_DemandDistribution(List<DemandDistribution> demandDistributionTable)
        {
            demandDistributionTable[0].DayTypeDistributions[0].CummProbability = demandDistributionTable[0].DayTypeDistributions[0].Probability;
            demandDistributionTable[0].DayTypeDistributions[0].MinRange = 1;
            demandDistributionTable[0].DayTypeDistributions[0].MaxRange = (int)(demandDistributionTable[0].DayTypeDistributions[0].CummProbability * 100);
            demandDistributionTable[0].DayTypeDistributions[1].CummProbability = demandDistributionTable[0].DayTypeDistributions[1].Probability;
            demandDistributionTable[0].DayTypeDistributions[1].MinRange = 1;
            demandDistributionTable[0].DayTypeDistributions[1].MaxRange = (int)(demandDistributionTable[0].DayTypeDistributions[1].CummProbability * 100);
            demandDistributionTable[0].DayTypeDistributions[2].CummProbability = demandDistributionTable[0].DayTypeDistributions[2].Probability;
            demandDistributionTable[0].DayTypeDistributions[2].MinRange = 1;
            demandDistributionTable[0].DayTypeDistributions[2].MaxRange = (int)(demandDistributionTable[0].DayTypeDistributions[2].CummProbability * 100);
            for (int i = 1; i < demandDistributionTable.Count; i++)
            {
                demandDistributionTable[i].DayTypeDistributions[0].CummProbability = demandDistributionTable[i].DayTypeDistributions[0].Probability + demandDistributionTable[i - 1].DayTypeDistributions[0].CummProbability;
                demandDistributionTable[i].DayTypeDistributions[0].MinRange = (demandDistributionTable[i - 1].DayTypeDistributions[0].MaxRange) + 1;
                demandDistributionTable[i].DayTypeDistributions[0].MaxRange = (int)(demandDistributionTable[i].DayTypeDistributions[0].CummProbability * 100);
                demandDistributionTable[i].DayTypeDistributions[1].CummProbability = demandDistributionTable[i].DayTypeDistributions[1].Probability + demandDistributionTable[i - 1].DayTypeDistributions[1].CummProbability;
                demandDistributionTable[i].DayTypeDistributions[1].MinRange = (demandDistributionTable[i - 1].DayTypeDistributions[1].MaxRange) + 1;
                demandDistributionTable[i].DayTypeDistributions[1].MaxRange = (int)(demandDistributionTable[i].DayTypeDistributions[1].CummProbability * 100);
                demandDistributionTable[i].DayTypeDistributions[2].CummProbability = demandDistributionTable[i].DayTypeDistributions[2].Probability + demandDistributionTable[i - 1].DayTypeDistributions[2].CummProbability;
                demandDistributionTable[i].DayTypeDistributions[2].MinRange = (demandDistributionTable[i - 1].DayTypeDistributions[2].MaxRange) + 1;
                demandDistributionTable[i].DayTypeDistributions[2].MaxRange = (int)(demandDistributionTable[i].DayTypeDistributions[2].CummProbability * 100);
            }
            return demandDistributionTable;
        }
        public static List<DayTypeDistribution> Get_probTable(List<DayTypeDistribution> Table)
        {
            Table[0].CummProbability = Table[0].Probability;
            Table[0].MinRange = 1;
            Table[0].MaxRange = (int)(Table[0].CummProbability * 100);

            for (int i = 1; i < Table.Count; i++)
            {
                Table[i].CummProbability = Table[i].Probability + Table[i - 1].CummProbability;
                Table[i].MinRange = (Table[i - 1].MaxRange) + 1;
                Table[i].MaxRange = (int)(Table[i].CummProbability * 100);
            }
            return Table;

        }

    }
}

