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

        public void initSevers()
        {
            for (int i = 1; i <= NumberOfServers; i++)
            {
                Server server = new Server
                {
                    ID = i,
                    FinishTime = 0,
                    idleTime = 0,
                    TotalWorkingTime = 0,
                    nCustomers_served = 0
                };
                Servers.Add(server);
            }
        }

        public void genTable()
        {
            Random rnd = new Random();
            for (int i = 0; i < StoppingNumber; i++)
            {
                SimulationCase prevRow = new SimulationCase();
                if (i > 0)
                {
                    prevRow = SimulationTable[i - 1];
                }
                SimulationCase row = new SimulationCase();
                row.CustomerNumber = i + 1;
                row.RandomInterArrival = rnd.Next(1, 100);
                row.InterArrival = mapValue(row.RandomInterArrival, InterarrivalDistribution);
                row.ArrivalTime = (i == 0 ? 0 : prevRow.ArrivalTime + row.InterArrival);
                
                if (i == 0)
                {
                    row.RandomInterArrival = 1;
                    row.InterArrival = 0;
                    row.ArrivalTime = 0;
                }


                row.TimeInQueue = 0;
                var x = SelectionMethod;
                int serverIndex = 0;
                if (x == Enums.SelectionMethod.HighestPriority)
                {
                    if (i == 0)
                        row.AssignedServer = Servers[0];
                    else
                    {
                        bool found = false;
                        for (int j = 0; j < Servers.Count; j++)
                        {
                            if (row.ArrivalTime >= Servers[j].FinishTime)
                            {
                                found = true;
                                serverIndex = j;
                                break;
                            }
                        }
                        if (!found)
                        {
                            row.AssignedServer = getFirstServer(Servers);
                            row.TimeInQueue = row.AssignedServer.FinishTime - row.ArrivalTime;
                        }
                        else
                            row.AssignedServer = Servers[serverIndex];
                    }
                }
                else if (x == Enums.SelectionMethod.Random)
                {
                    serverIndex = rnd.Next(0, Servers.Count - 1);
                    if (i == 0)
                        row.AssignedServer = Servers[serverIndex];
                    List<Server> freeServers = new List<Server>();
                    bool found = false;
                    for (int k = 0; k < Servers.Count; k++)
                    {
                        if(row.ArrivalTime >= Servers[k].FinishTime)
                        {
                            freeServers.Add(Servers[k]);
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        row.AssignedServer = getFirstServer(Servers);
                        row.TimeInQueue = row.AssignedServer.FinishTime - row.ArrivalTime;
                    }
                    else
                    {
                        serverIndex = rnd.Next(0, freeServers.Count - 1);
                        row.AssignedServer = freeServers[serverIndex];
                    }      
                }
                /* else utilization [bonus]
                {

                }*/
                row.RandomService = rnd.Next(1, 100);
                row.ServiceTime = mapValue(row.RandomService, row.AssignedServer.TimeDistribution);
                row.StartTime = row.ArrivalTime + row.TimeInQueue;
                row.EndTime = row.StartTime + row.ServiceTime;
                row.AssignedServer.FinishTime = row.EndTime;
                SimulationTable.Add(row);

                /*Calculations for equations*/
                SystemHelper.TotalTime_CusWaitedinQueue += row.TimeInQueue;
                SystemHelper.nCustomers_Total = row.CustomerNumber;
                if (row.TimeInQueue > 0)
                    SystemHelper.nCustomers_WaitedInQueue += 1;
                SystemHelper.Simulation_runTime = Math.Max(row.EndTime, SystemHelper.Simulation_runTime);
                for(int k = row.ArrivalTime; k < row.StartTime; k++)
                {
                    if (SystemHelper.queue.ContainsKey(k))
                        SystemHelper.queue[k]++;
                    else
                        SystemHelper.queue.Add(k, 1);
                    SystemHelper.mx_QueueLength = Math.Max(SystemHelper.mx_QueueLength, SystemHelper.queue[k]);
                }
                row.AssignedServer.TotalWorkingTime += row.ServiceTime;
                row.AssignedServer.nCustomers_served += 1;
            }
        }

        public void calc_performance()
        {
            int cnt = Servers.Count;
            for (int i = 0; i < cnt; i++)
            {
                Servers[i].calc_serverPerformance();
            }
        }

        public Server getFirstServer(List<Server> servers)
        {
            int mnFinishTime = int.MaxValue;
            int mnFinishTime_index = 0;
            for (int j = 0; j < servers.Count; j++)
            {
                if (servers[j].FinishTime < mnFinishTime)
                {
                    mnFinishTime = servers[j].FinishTime;
                    mnFinishTime_index = j;
                }
            }
            return servers[mnFinishTime_index];
        }

        public int mapValue(int value, List<TimeDistribution> distributions)
        {
            for (int i = 0; i < distributions.Count; i++)
            {
                TimeDistribution distribution = distributions[i];
                if (value >= distribution.MinRange && value <= distribution.MaxRange)
                {
                    return distribution.Time;
                }
            }
            return -1;
        }

    }
}
