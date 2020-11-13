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

        // equations vars
        public int idleTime;
        public int nCustomers_served;


        public void calc_serverPerformance()
        {
            IdleProbability = (decimal)(SystemHelper.Simulation_runTime - TotalWorkingTime) / SystemHelper.Simulation_runTime;
            AverageServiceTime = (decimal)TotalWorkingTime / nCustomers_served;
            Utilization = (decimal)TotalWorkingTime / SystemHelper.Simulation_runTime;
        }
    }
}
