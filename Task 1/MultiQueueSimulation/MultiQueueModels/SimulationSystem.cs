using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }

        public SimulationSystem(int nServers, int stoppingN, List<Server> servers, List<TimeDistribution> dist, Enums.StoppingCriteria stopping, Enums.SelectionMethod selection)
        {
            this.NumberOfServers = nServers;
            this.StoppingNumber = stoppingN;
            this.Servers = servers;
            this.InterarrivalDistribution = dist;
            this.StoppingCriteria = stopping;
            this.SelectionMethod = selection;
        }
        
        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }
        

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

    }
}
