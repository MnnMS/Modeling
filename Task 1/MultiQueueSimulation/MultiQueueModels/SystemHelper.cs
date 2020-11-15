using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueModels
{
    public static class SystemHelper
    {
        public static int TotalTime_CusWaitedinQueue;
        public static int nCustomers_Total;
        public static int nCustomers_WaitedInQueue;
        public static int Simulation_runTime;
        public static int mx_QueueLength;
        public static Dictionary<int,int> queue = new Dictionary<int, int>();

        //to save all start , end time service and server id
        public static List<Serviceinfo> servicesinfo;

        public static List<TimeDistribution> Get_DistributionTable(List<TimeDistribution> Table)
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
