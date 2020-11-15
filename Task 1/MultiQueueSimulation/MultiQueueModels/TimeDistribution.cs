using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class TimeDistribution
    {
        public int Time { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }


        public static List<TimeDistribution> Get_DistributionTable(List<TimeDistribution> Table)
        {
            Table[0].CummProbability = Table[0].Probability;
            Table[0].MinRange = 1;
            Table[0].MaxRange = (int)(Table[0].CummProbability * 100);

            for (int i = 1;i < Table.Count;i++)
            {
                Table[i].CummProbability = Table[i].Probability + Table[i-1].CummProbability;
                Table[i].MinRange = (Table[i-1].MaxRange) + 1;
                Table[i].MaxRange = (int)(Table[i].CummProbability * 100);
            }
            return Table;
        }
    }
}
