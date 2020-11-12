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


        public decimal Calc_AverageWaitingTime(int TotalTime_CusWaitedinQueue, int ncustomers_Total)
        {
            decimal Avg = (decimal)TotalTime_CusWaitedinQueue / ncustomers_Total;
            return Avg;
        }

        public decimal Calc_WaitingProbability(int nCustomers_WaitedInQueue, int ncustomers_Total)
        {
            decimal wait = (decimal)nCustomers_WaitedInQueue / ncustomers_Total;
            return wait;
        }
    }
}
