using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SystemHelper
    {
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
