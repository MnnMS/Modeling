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
    }
}
