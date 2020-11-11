using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public static class SystemHelper
    {
        public static int  NumberOfServers;
        public static int StoppingNumber;
        public static List<Server> Servers;
        public static List<TimeDistribution> InterarrivalDistribution;
        public static Enums.StoppingCriteria StoppingCriteria;
        public static Enums.SelectionMethod SelectionMethod;
        public static int TotalTime_CusWaitedinQueue;
        public static int ncustomers_Total;
        public static int nCustomers_WaitedInQueue;
        public static int Simulation_runTime;
        public static int mx_QueueLength;

        //to save all start , end time service and server id
        public static List<Serviceinfo> servicesinfo;

       //Variables for every server
        public static List<int> idleTimeOFserver = new List<int>();
        public static List<int> serviceTime = new List<int>();
        public static List<int> nCustomers_server = new List<int>();
        public static List<int> TimeOnCalls_server = new List<int>();

    }
}
