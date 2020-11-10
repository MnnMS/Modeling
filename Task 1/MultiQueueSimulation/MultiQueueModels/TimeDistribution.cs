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


        public void Calc_Data(List<TimeDistribution> Table)
        {
            Table[0].CummProbability = Table[0].Probability;
            Table[0].MinRange = 1;
            Table[0].MaxRange = Decimal.ToInt32(Table[0].Probability) * 100;

            for (int i = 1;i < Table.Count;i++)
            {
                for (int j = i;j >= 0; j++)
                {
                    Table[i].CummProbability += Table[j].Probability;
                }
                Table[i].MinRange = (Table[i-1].MaxRange) + 1;
                Table[i].MaxRange = Decimal.ToInt32(Table[i].Probability) * 100;
            }
        }
    }
}
