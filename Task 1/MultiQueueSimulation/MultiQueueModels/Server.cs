using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }


        public List<Server> calc_serverPerformance (List<Server> servers,int Simulation_runTime, List<int> idleTimeOFserver, List<int> serviceTime, List<int> nCustomers_server, List<int> TimeOnCalls_server)
        {
            for (int i = 0;i < servers.Count; i++)
            {
                servers[i].IdleProbability = (decimal)idleTimeOFserver[i] / Simulation_runTime;
                servers[i].AverageServiceTime = (decimal)serviceTime[i] / nCustomers_server[i];
                servers[i].Utilization = (decimal)TimeOnCalls_server[i] / Simulation_runTime;
            }
            return servers;
        }
    }
}
