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
    }

    

    
}
