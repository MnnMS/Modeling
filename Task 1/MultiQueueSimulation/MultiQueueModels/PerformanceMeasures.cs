using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class PerformanceMeasures
    {
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        public decimal WaitingProbability { get; set; }


        public void Calc_AverageWaitingTime(int TotalTime_CusWaitedinQueue, int ncustomers_Total)
        {
            AverageWaitingTime = (decimal)TotalTime_CusWaitedinQueue / ncustomers_Total;
        }

        public void Calc_WaitingProbability(int nCustomers_WaitedInQueue, int ncustomers_Total)
        {
            WaitingProbability = (decimal)nCustomers_WaitedInQueue / ncustomers_Total;
        }
    }
}
