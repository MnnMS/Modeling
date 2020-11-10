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
        public static List<Server> Servers = new List<Server>();
        public static List<TimeDistribution> InterarrivalDistribution = new List<TimeDistribution>();
        public static Enums.StoppingCriteria StoppingCriteria;
        public static Enums.SelectionMethod SelectionMethod;

        public static void start(SimulationSystem system)
        {
            for(int i = 1; i <= NumberOfServers; i++)
            {
                Server server = new Server();
                server.ID = i;
                server.FinishTime = 0;
            }
            system = new SimulationSystem(NumberOfServers, StoppingNumber, Servers, InterarrivalDistribution, StoppingCriteria, SelectionMethod);
            system.SimulationTable = SimulationCase.getTable(StoppingNumber, system);
        }
    }

    
}
